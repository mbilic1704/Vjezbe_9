using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class FrmGroupParticipants : Form
    {
        public FrmGroupParticipants()
        {
            InitializeComponent();
        }

        private void FrmGroupParticipants_Load(object sender, EventArgs e)
        {
            txtGroupName.Text = Form1.choosenGroup.Name;
            RefreshForm();

        }

        private void RefreshForm()
        {
            dgvUnassigned.DataSource = GetUnassignedStudents();
            dgvUnassigned.Columns["Group"].Visible = false;

            dgvAssigned.DataSource = GetAssignedStudents();
            dgvAssigned.Columns["Group"].Visible = false;
        }

        private List<Student> GetUnassignedStudents()
        {
            using(var context = new Database())
            {
                return context.Students.Where(s=>s.IdGroups == null).ToList();  
            }
        }

        private List<Student> GetAssignedStudents()
        {
            using(var context = new Database())
            {
                return context.Students.Where(s=>s.IdGroups == Form1.choosenGroup.Id).ToList();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Student choosenStudent = dgvUnassigned.CurrentRow.DataBoundItem as Student;

            using(var context = new Database())
            {
                context.Students.Attach(choosenStudent);
                choosenStudent.IdGroups = Form1.choosenGroup.Id;
                context.SaveChanges();
            }

            RefreshForm();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            Student choosenStudent = dgvAssigned.CurrentRow.DataBoundItem as Student;

            using (var context = new Database())
            {
                context.Students.Attach(choosenStudent);
                choosenStudent.IdGroups = null;
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
