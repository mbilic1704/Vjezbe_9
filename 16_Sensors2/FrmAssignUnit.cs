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
    public partial class FrmAssignUnit : Form
    {
        Sensor selectedSensor;
        public FrmAssignUnit(Sensor sensor)
        {
            selectedSensor = sensor;
            InitializeComponent();
        }

        private void FrmAssignUnit_Load(object sender, EventArgs e)
        {
            cmbUnit.DataSource = GetUnits();
        }

        private List<MeasurementUnit> GetUnits()
        {
            using (var context = new Database())
            {
                return context.MeasurementUnits.ToList();
            }
        }

        private void btAssign_Click(object sender, EventArgs e)
        {
            MeasurementUnit newUnit = cmbUnit.SelectedItem as MeasurementUnit;
            
            using(var context = new Database())
            {
                context.Sensors.Attach(selectedSensor);
                context.MeasurementUnits.Attach(newUnit);
                selectedSensor.MeasurementUnit = newUnit;
                context.SaveChanges();
            }

            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
