using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Product_Categories
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            using(var context = new Database())
            {
                dgvProducts.DataSource = context.Products.ToList();
                dgvProducts.Columns["Category"].Visible = false;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FrmAddProducts frmAdd = new FrmAddProducts();
            frmAdd.ShowDialog();
        }

        private void FrmProducts_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;  

            using(var context = new Database())
            {
                context.Products.Attach(selectedProduct);
                context.Products.Remove(selectedProduct);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
