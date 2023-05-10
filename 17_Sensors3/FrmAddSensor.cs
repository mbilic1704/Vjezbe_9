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
    public partial class FrmAddSensor : Form
    {
        public static MeasurementUnit wantedUnit;
        public static SensorType wantedType;
        public FrmAddSensor()
        {
            InitializeComponent();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            FrmUnit frmUnit = new FrmUnit();
            frmUnit.ShowDialog();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            FrmType frmType = new FrmType();
            frmType.ShowDialog();
        }

        private void FrmAddSensor_Activated(object sender, EventArgs e)
        {
            if (wantedType!= null )
            {
                txtType.Text = wantedType.ToString();
            }
            if(wantedUnit!= null )
            {
                txtUnit.Text = wantedUnit.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            using(var context = new Database())
            {
                context.MeasurementUnits.Attach(wantedUnit);
                context.SensorTypes.Attach(wantedType);

                Sensor newSensor = new Sensor()
                {
                    Name = name,
                    MeasurementUnit = wantedUnit,
                    SensorType = wantedType
                };

                context.Sensors.Add(newSensor);
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
