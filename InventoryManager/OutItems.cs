using InventoryManager.Infrastructure.Models;
using InventoryManager.Models;
using InventoryManager.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class OutItems : UserControl
    {
        public OutItems()
        {
            InitializeComponent();
        }
        public async void SetProductRepository()
        {
            await RefreshData();
            ProductName_input_out.Enabled = false;
        }
        public async Task LoadProductData()
        {
            var products = await GetAllProducts();

            dataGridViewOut.DataSource = products;
            dataGridViewOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public async Task<List<ProductModelOutput>> GetAllProducts()
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync("http://localhost:5096/Api/Products/GetAllProducts");
                var json = await response.Content.ReadAsStringAsync();
                var products = JsonSerializer.Deserialize<List<ProductModelOutput>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return products;
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
           
            
        }
        public async Task LoadProductComboBox()
        {
            var products = await GetAllProducts();
            // เพิ่มรายการเปล่าไว้ลำดับแรก
            products.Insert(0, new ProductModelOutput
            {
                ProductId = 0,
                ProductName = "---"
            });

            comboBoxListItemOut.DataSource = products;
            comboBoxListItemOut.DisplayMember = "ProductName";
            comboBoxListItemOut.ValueMember = "ProductId";

            comboBoxListItemOut.SelectedIndexChanged += comboBoxListItem_SelectedIndexChanged;
        }

        private void comboBoxListItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = comboBoxListItemOut.SelectedItem as ProductModelOutput;

            if (selectedProduct != null && selectedProduct.ProductId != 0)
            {
                ProductName_input_out.Text = selectedProduct.ProductName;
                comboBoxListItemOut.Text = selectedProduct.ProductName;
            }
            else
            {
                ProductName_input_out.Text = string.Empty;
                Unit_input_out.Text = string.Empty;
            }
        }

        private void Out_btn_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า TextBox ต้องไม่ว่าง
            if (string.IsNullOrWhiteSpace(ProductName_input_out.Text) ||
                string.IsNullOrWhiteSpace(Unit_input_out.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า Quantity เป็นตัวเลข
            if (!int.TryParse(Unit_input_out.Text, out int quantity))
            {
                MessageBox.Show("กรุณากรอกจำนวนเป็นตัวเลข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var UpdateP = new ProductModelInput()
            {
                ProductName = ProductName_input_out.Text,
                Unit = int.Parse(Unit_input_out.Text)
            };
            OutProductApi(UpdateP);
        }
        public async Task OutProductApi(ProductModelInput UpdateP)
        {
            var httpClient = new HttpClient();
            var json = JsonSerializer.Serialize(UpdateP);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:5096/Api/Products/OutProduct", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseContent);
                await RefreshData();
                
            }
            else
            {
                MessageBox.Show("เกิดข้อผิดพลาด");
                await RefreshData();
            }
        }

        private async void ref_btn_Click(object sender, EventArgs e)
        {
            await RefreshData();
        }
        public async Task RefreshData()
        {
            await LoadProductComboBox();
            await LoadProductData();
        }
    }
}
