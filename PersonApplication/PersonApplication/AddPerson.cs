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
        public AddPerson()
        {
            InitializeComponent();
        }

        private void telAdd_Click(object sender, EventArgs e)
        {
            PersonOp.TelAdd(nameTb.Text,surnameTb.Text, telephoneTb.Text,addressTb.Text);
        }
    }
}
