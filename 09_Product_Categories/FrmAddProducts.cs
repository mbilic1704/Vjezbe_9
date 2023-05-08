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
    public partial class FrmAddProducts : Form
    {
        public FrmAddProducts()
        {
            InitializeComponent();
        }

        private void FrmAddProducts_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = GetCategories();
        }

        private List<Category> GetCategories()
        {
            using(var context = new Database())
            {
                return context.Categories.ToList();
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int quantity = int.Parse(tbQuantity.Text);
            double unitPrice = double.Parse(tbUnitPrice.Text);  
            Category choosenCatgory = cmbCategory.SelectedItem as Category;

            using(var context = new Database())
            {
                Product newProduct = new Product()
                {
                    Name = name,
                    UnitPrice = unitPrice,
                    Quantity = quantity,
                    Category = choosenCatgory
                };

                context.Products.Add(newProduct);
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
