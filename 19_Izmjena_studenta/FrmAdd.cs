using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Izmjena_studenta
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            cmbGroup.DataSource = GetGroups();
        }

        public List<Group> GetGroups()
        {
            using(var context = new Database())
            {
                return context.Groups.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fName = txtFname.Text;
            string lName = txtLname.Text;
            Group choosenGroup = cmbGroup.SelectedItem as Group;

            using(var context = new Database())
            {
                Student newStudent = new Student()
                {
                    FirstName = fName,
                    LastName = lName,
                    Group = choosenGroup
                };

                context.Students.Add(newStudent);
                context.SaveChanges();
            }

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
