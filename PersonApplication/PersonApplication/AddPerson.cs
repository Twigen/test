using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonDatabase.Operations;
using PersonDatabase.Entity;

namespace PersonApplication
{
    public partial class AddPerson : Form
    {
        

        public AddPerson ()
        {
            InitializeComponent();
        }

        
        

        private void telAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            List<string> list = telNumberList.Items.Cast<string>().ToList();
            List<string> listA = telNumberList.Items.Cast<string>().ToList();
            if (nameTb.Text != "" && surnameTb.Text != "" && list.Count != 0 && listA.Count != 0)
            {
                
                person = PersonOperations.AddPerson(nameTb.Text, surnameTb.Text, addressTb.Text);
                TelephoneOperations.AddTelephone(person,list);
                MessageBox.Show("Data saved");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            telNumberList.Items.Add(newTelNumberTb.Text);
            
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            this.telNumbersBindingSource.DataSource = new List<string>();
        }
    }
}
