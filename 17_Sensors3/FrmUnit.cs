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
    public partial class FrmUnit : Form
    {
       
        public FrmUnit()
        {
            
            InitializeComponent();
        }

        private void FrmUnit_Load(object sender, EventArgs e)
        {
            dgvUnits.DataSource =  GetUnits();
            dgvUnits.Columns["Sensors"].Visible = false;
        }
        private List<MeasurementUnit> GetUnits()
        {
            using (var context = new Database())
            {
                return context.MeasurementUnits.ToList();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            FrmAddSensor.wantedUnit = dgvUnits.CurrentRow.DataBoundItem as MeasurementUnit;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
