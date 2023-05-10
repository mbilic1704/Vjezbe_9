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
    public partial class Form1 : Form
    {
        public static Group choosenGroup;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddRemove_Click(object sender, EventArgs e)
        {
            choosenGroup = dgvGroups.CurrentRow.DataBoundItem as Group;
            FrmGroupParticipants frm = new FrmGroupParticipants();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
           dgvGroups.DataSource = GetGroups();
           dgvGroups.Columns["Students"].Visible = false;
        }

        private List<Group> GetGroups()
        {
            using (var context = new Database())
            {
                return context.Groups.ToList();
            }
        }
    }
}
