using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonDatabase.Context;
using PersonDatabase.Operations;

namespace PersonApplication
{
    public partial class Display : Form
    {
        public Display()
        {
            
            InitializeComponent();
            
        }

        private void Display_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PersonDatabase_Context_PersonContextDataSet.People' table. You can move, or remove it, as needed.
            using (var context = new PersonContext())
            {
                var list = context.Persons.ToList();
                this.peopleBindingSource.DataSource = list;
               
            }

        }

        private void peopleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddPerson f2 = new AddPerson();
            f2.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
