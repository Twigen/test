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
using PersonDatabase.Entity;

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
            ReloadGrid();

        }

        private void ReloadGrid()
        {
          
            List<Person> persons = PersonOperations.GetAll();
          
            List<PersonViewModel> viewModels = persons.Select(p => new PersonViewModel
            {
                address = p.address,
                name = p.name,
                surname = p.surname,
                PersonId = p.PersonId,
                telNumbers = FormatTelephoneNumbers(p)
            })
            .ToList();
            this.peopleBindingSource.DataSource = viewModels;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //PersonViewModel selectedPerson = this.peopleBindingSource.Current as PersonViewModel;
            
            AddPerson f2 = new AddPerson();
            if(f2.ShowDialog() == DialogResult.OK)
            {
                ReloadGrid();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            PersonViewModel selectedPerson = this.peopleBindingSource.Current as PersonViewModel;
            
            EditPerson editPersonForm = new EditPerson(selectedPerson.PersonId);
           if(editPersonForm.ShowDialog() == DialogResult.OK)
            {
                ReloadGrid();
            }
        }

        private static string FormatTelephoneNumbers(Person p)
        {
            return p.Telephones != null ?
                string.Join(" ", p.Telephones.Select((Telephone t) => t.Number.ToString()))
                : string.Empty;
        }
    }
}
