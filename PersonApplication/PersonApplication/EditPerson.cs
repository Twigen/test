using PersonDatabase.Entity;
using PersonDatabase.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApplication
{
    public partial class EditPerson : Form
    {
        private int personId;



        public EditPerson(int personId)
        {
            this.personId = personId;
            InitializeComponent();

        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            Person edit = PersonOperations.GetPerson(personId);
            nameTbEp.Text = edit.name;
            surnameTbEp.Text = edit.surname;
            addressTbEp.Text = edit.address;
            List<Telephone> teleEdit = PersonOperations.GetTelephone(personId);
            foreach (Telephone t in teleEdit)
            {
                telephoneEditList.Items.Add(t.Number);
            }
        }

        private void editBtnEditPerson_Click(object sender, EventArgs e)
        {
            Person edit = new Person
            {
                address = addressTbEp.Text,
                name = nameTbEp.Text,
                surname = surnameTbEp.Text,
                PersonId = personId

            };
            PersonOperations.Update(edit);
            List<int> telephoneNumberList = new List<int>();

            foreach (DataRowView drv in telephoneEditList.Items)
            {
                telephoneNumberList.Add( int.Parse(drv.Row[telephoneEditList.ValueMember].ToString()));
                
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void editTelephoneBtn_Click(object sender, EventArgs e)
        {
            telephoneEditList.Items[telephoneEditList.SelectedIndex] = telephoneEditTb.Text;
        }
    }
}
