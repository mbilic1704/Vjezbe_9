using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Employees_Task
{
    public partial class Form1 : Form
    {
        Employee choosenEmployee;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPriority.DataSource = GetPriorty();
            RefreshForm();
        }

        private List<Task> GetPriorty()
        {
            using(var context = new Database())
            {
                return context.Tasks.ToList();
            }
        }

        private void RefreshForm()
        {
            dgvEmployees.DataSource = GetEmployees();
            dgvEmployees.Columns["Tasks"].Visible = false;
            dgvTasks.DataSource = GetTasks();


        }

        private List<Employee> GetEmployees()
        {
            using(var context = new Database())
            {
                return context.Employees.ToList();
            }
        }

        private List<Task> GetTasks()
        {
            using(var context = new Database())
            {
                context.Employees.Attach(choosenEmployee);
                return choosenEmployee.Tasks.ToList();
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            choosenEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employee;

            dgvTasks.DataSource = GetTasks();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            using(var context = new Database())
            {
                Employee newEmpl = new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName,
                };

                context.Employees.Add(newEmpl);
                context.SaveChanges();
            }

            RefreshForm();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            Task task = cmbPriority.SelectedItem as Task;

            using(var context = new Database())
            {
                Task task1 = new Task()
                {
                    Description = description,
                    Priority = task.Priority,
                    Employee = choosenEmployee

                };

                context.Tasks.Add(task1);
                context.SaveChanges();
            }

            RefreshForm();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Task choosenTask = dgvTasks.CurrentRow.DataBoundItem as Task;

            using(var conte = new Database())
            {
                conte.Tasks.Attach(choosenTask);
                conte.Tasks.Remove(choosenTask);
                conte.SaveChanges();
            }

            RefreshForm();
        }
    }
}
