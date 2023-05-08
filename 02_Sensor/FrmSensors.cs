using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Sensor
{
    public partial class FrmSensors : Form
    {
        public FrmSensors()
        {
            InitializeComponent();
        }

        private void Sensors_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            dgvSensors.DataSource = GetSensors();
            dgvSensors.Columns["SensorType"].Visible = false;
            dgvSensors.Columns["MeasurementUnit"].Visible = false;
        }
        private object GetSensors()
        {
            using (var context = new Database())
            {
                return context.Sensors.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddSensor frmAddSensor = new FrmAddSensor(); 
            frmAddSensor.ShowDialog();  
        }

        private void FrmSensors_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Sensor selectedSenosor = dgvSensors.CurrentRow.DataBoundItem as Sensor;

            using(var context = new Database())
            {
                context.Sensors.Attach(selectedSenosor);
                context.Sensors.Remove(selectedSenosor);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
