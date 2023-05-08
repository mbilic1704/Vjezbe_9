using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Kategorije_proizvoda
{
    public partial class Categories_Products : Form
    {
        public Category choosenCategory;
        public Categories_Products()
        {
            InitializeComponent();
        }

        private void Categories_Products_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = GetCategories();
            dgvCategory.Columns["Products"].Visible = false;

           
        }

        private List<Category> GetCategories()
        {
            using(var context = new Database())
            {
                return context.Categories.ToList();
            }
        }

        private List<Product> GetProductsByCategory()
        {
            using(var context = new Database())
            {
                context.Categories.Attach(choosenCategory);
                return choosenCategory.Products.ToList();
            }
            
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            choosenCategory = dgvCategory.CurrentRow.DataBoundItem as Category;

            dgvProducts.DataSource = GetProductsByCategory();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using(var context = new Database())
            {
                string name = tbName.Text;
                int quantity = int.Parse(tbQuantity.Text);
                double unitPrice = double.Parse(tbUnitPrice.Text);


                Product newProduct = new Product()
                {
                    Name = name,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    Category = choosenCategory
                };

                context.Products.Add(newProduct);
                context.SaveChanges();
            }

            RefreshForm();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Product choosenProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

            using(var context = new Database())
            {
                context.Products.Attach(choosenProduct);
                context.Products.Remove(choosenProduct);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
