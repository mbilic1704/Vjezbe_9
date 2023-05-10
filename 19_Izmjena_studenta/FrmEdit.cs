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
    public partial class FrmEdit : Form
    {
        Student choosenStudent;
        public FrmEdit(Student choosenStudent)
        {
            InitializeComponent();
            this.choosenStudent = choosenStudent;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            txtId.Text = choosenStudent.Id.ToString();
            txtFname.Text = choosenStudent.FirstName;
            txtLname.Text = choosenStudent.LastName;

            FillGroup();
            

           
        }

        public void FillGroup()
        {
            List<Group> groups = new List<Group>();
            using (var context = new Database())
            {
                groups = context.Groups.ToList();
            }

            cmbGroup.DataSource = groups;

            for(int i = 0; i<cmbGroup.Items.Count; i++)
            {
                if((cmbGroup.SelectedItem as Group).Id == choosenStudent.IdGroups) 
                {
                    cmbGroup.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(var context = new Database())
            {
                string fName = txtFname.Text;
                string lName = txtLname.Text;
                Group group = cmbGroup.SelectedItem as Group;
                context.Groups.Attach(group);

                context.Students.Attach(choosenStudent);

                choosenStudent.FirstName = fName;
                choosenStudent.LastName = lName;
                choosenStudent.Group = group;

                context.SaveChanges();  
            }

            Close();
        }
    }
}
