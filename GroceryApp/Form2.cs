using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroceryApp
{
    public partial class Form2 : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "shoppinglist.json");

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in both name and price.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            var newProduct = new Product { Name = txtName.Text, Price = price };
            List<Product> products = new List<Product>();

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    products = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
                }

                products.Add(newProduct);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(products, Formatting.Indented));
                MessageBox.Show("Item added successfully!");
                this.Close(); // Close Form2 after adding
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message);
            }
        }
    }
}
