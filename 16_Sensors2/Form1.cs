using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Sensors2
{
    public partial class Form1 : Form
    {
        Sensor choosenSensor;
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
            using(var context = new Database())
            {
                dgvSensors.DataSource = context.Sensors.ToList();
                dgvSensors.Columns["SensorType"].Visible = false;
                dgvSensors.Columns["MeasurementUnit"].Visible = false;
            }
        }

        private void btAssignUnit_Click(object sender, EventArgs e)
        {
            choosenSensor = dgvSensors.CurrentRow.DataBoundItem as Sensor;

            FrmAssignUnit frmAssignUnit = new FrmAssignUnit(choosenSensor);
            frmAssignUnit.ShowDialog();
        }

        private void btAddSensor_Click(object sender, EventArgs e)
        {
            FrmAddSensor frmAddSensor = new FrmAddSensor();
            frmAddSensor.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btRemoveSensor_Click(object sender, EventArgs e)
        {
            Sensor selectedSensor = dgvSensors.CurrentRow.DataBoundItem as Sensor;

            using(var context = new Database())
            {
                context.Sensors.Attach(selectedSensor);
                context.Sensors.Remove(selectedSensor);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
