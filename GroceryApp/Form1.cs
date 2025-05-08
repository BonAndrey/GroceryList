using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class Form1 : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "shoppinglist.json");

        public Form1()
        {
            InitializeComponent();
            LoadShoppingList();
        }

        private void LoadShoppingList()
        {
            listBox1.Items.Clear();

            if (!File.Exists(filePath))
            {
                listBox1.Items.Add("No grocery list found. Please add items.");
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(json))
                {
                    listBox1.Items.Add("Grocery list is empty.");
                    return;
                }

                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                if (products != null && products.Count > 0)
                {
                    foreach (var product in products)
                    {
                        listBox1.Items.Add($"{product.Name} - ₱{product.Price:F2}");
                    }
                }
                else
                {
                    listBox1.Items.Add("Grocery list is empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void btnOpenAddForm_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            LoadShoppingList(); // refresh after adding
        }
    }
}
