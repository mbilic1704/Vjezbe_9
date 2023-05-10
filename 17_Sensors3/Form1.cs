using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Sensors3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddSensor frmSensor = new FrmAddSensor();
            frmSensor.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            dgvSensors.DataSource = GetSensors();
            dgvSensors.Columns["SensorType"].Visible = false;
            dgvSensors.Columns["MeasurementUnit"].Visible = false;
        }

        private List<Sensor> GetSensors()
        {
            using(var context = new Database())
            {
                return context.Sensors.ToList();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
