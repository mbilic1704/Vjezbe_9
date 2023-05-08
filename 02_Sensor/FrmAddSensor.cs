using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _02_Sensor
{
    public partial class FrmAddSensor : Form
    {
        public FrmAddSensor()
        {
            InitializeComponent();
        }

        private void FrmAddSensor_Load(object sender, EventArgs e)
        {
            FillType();
            FillUnit();
        }

        private void FillUnit()
        {
            List<MeasurementUnit> units;

            using (var context = new Database())
            {
                units = context.MeasurementUnits.ToList();
            }

            cmbUnit.DataSource = units;
        }

        private void FillType()
        {
            List<SensorType> typeList;

            using (var context = new Database())
            {
                typeList = context.SensorTypes.ToList();
            }

            cmbType.DataSource = typeList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new Database())
            {
                string name = txtName.Text;
                SensorType type = cmbType.SelectedItem as SensorType;
                context.SensorTypes.Attach(type);
                MeasurementUnit unit = cmbUnit.SelectedItem as MeasurementUnit;
                context.MeasurementUnits.Attach(unit);

                Sensor newSenosr = new Sensor()
                {
                    Name = name,
                    SensorType = type,
                    MeasurementUnit = unit

                };

                context.Sensors.Add(newSenosr);
                context.SaveChanges();
            }

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
