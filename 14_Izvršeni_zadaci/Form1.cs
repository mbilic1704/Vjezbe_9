using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Izvršeni_zadaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPriority.DataSource = GetPriority();
            RefreshForm();
        }

        private List<int> GetPriority()
        {
            using(var context = new Database())
            {
              return context.Tasks.Select(t=>t.Priority).Distinct().ToList();
            }
        }

        private void RefreshForm()
        {
            dgvIzvrseni.DataSource = GetDoneTasks();
            dgvIzvrseni.Columns["Employee"].Visible = false;

            dgvOtvoreni.DataSource = GetNotDoneTasks();
            dgvOtvoreni.Columns["Employee"].Visible = false;
        }

        private List<Task> GetDoneTasks()
        {
            using (var context = new Database())
            {
                return context.Tasks.Where(t => t.Completed == true).ToList();
               
            }
        }

        private List<Task> GetNotDoneTasks()
        {
            using (var context = new Database())
            {
                return context.Tasks.Where(t => t.Completed == false).ToList();

            }
        }

        private void btMark_Click(object sender, EventArgs e)
        {
            Task choosenTask = dgvOtvoreni.CurrentRow.DataBoundItem as Task;

            using(var context = new Database())
            {
                context.Tasks.Attach(choosenTask);
                choosenTask.Completed = true;
                context.SaveChanges();
            }

            RefreshForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int priority = int.Parse(cmbPriority.SelectedItem.ToString());

            using(var context = new Database())
            {
                Task newTask = new Task()
                {
                    Description = txtDescription.Text,
                    Priority = priority,
                    Completed = false
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
