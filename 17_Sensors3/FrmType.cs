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
    public partial class FrmType : Form
    {
      
        public FrmType()
        {
            
            InitializeComponent();
        }

        private void FrmType_Load(object sender, EventArgs e)
        {
            dgvType.DataSource = GetTypes();
            dgvType.Columns["Sensors"].Visible = false;
        }

        private List<SensorType> GetTypes()
        {
            using (var context = new Database())
            {
                return context.SensorTypes.ToList();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            FrmAddSensor.wantedType = dgvType.CurrentRow.DataBoundItem as SensorType;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
