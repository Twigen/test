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

namespace PersonApplication
{
    public partial class AddPerson : Form
    {
        private int personId;



        public AddPerson(int personId)
        {
            this.personId = personId;
            InitializeComponent();

        }
        

        private void telAdd_Click(object sender, EventArgs e)
        {
            List<string> list = telNumberList.Items.Cast<string>().ToList();
            PersonOperations.AddPerson(nameTb.Text,surnameTb.Text, addressTb.Text, list, personId);
            MessageBox.Show("Data saved");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            telNumberList.Items.Add(newTelNumberTb.Text);
            //var telNumbers = this.telNumbersBindingSource.DataSource as List<string>;
            //telNumbers.Add(this.newTelNumberTb.Text);
            //this.telNumbersBindingSource.DataSource = telNumbers;
            //this.newTelNumberTb.Text = string.Empty;
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            this.telNumbersBindingSource.DataSource = new List<string>();
        }
    }
}
