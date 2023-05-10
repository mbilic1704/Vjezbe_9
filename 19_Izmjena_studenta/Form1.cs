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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            dgvStudents.DataSource = GetStudents();
            dgvStudents.Columns["Group"].Visible = false;   
        }

        private List<Student> GetStudents()
        {
            using(var context = new Database())
            {
                return context.Students.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student choosenStudent = new Student();
            choosenStudent = dgvStudents.CurrentRow.DataBoundItem as Student;

            FrmEdit frmEdit = new FrmEdit(choosenStudent);
            frmEdit.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Student choosenStudent = new Student();
            choosenStudent = dgvStudents.CurrentRow.DataBoundItem as Student;

            using(var context = new Database())
            {
                context.Students.Attach(choosenStudent);
                context.Students.Remove(choosenStudent);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
