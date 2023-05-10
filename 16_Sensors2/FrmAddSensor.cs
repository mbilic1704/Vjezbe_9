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
    public partial class FrmAddSensor : Form
    {
        public FrmAddSensor()
        {
            InitializeComponent();
        }

        private void FrmAddSensor_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = GetTypes();
        }

        private List<SensorType> GetTypes()
        {
            using (var context = new Database())
            {
                return context.SensorTypes.ToList();
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            SensorType type = cmbType.SelectedItem as SensorType;

            using (var context = new Database())
            {
                Sensor newSensor = new Sensor()
                {
                    Name = name,
                    SensorType = type
                };

                context.Sensors.Add(newSensor); 
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
