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
using Inventorymanager.Models;

namespace InventoryManager
{
    public partial class sum : UserControl
    {
        public sum()
        {
            InitializeComponent();
        }
        public async void SetProductRepository()
        {

            await RefreshData();

            dateTimePicker1.Enabled = false;
            dateTimePicker1.Checked = false;


        }
        public async Task LoadProductData(FilterModel filter)
        {
            var products = await GetAllStockTransaction(filter);
        
            dataGridViewStockTransaction.DataSource = products;
            dataGridViewStockTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        
        public async Task<List<AllStockTransactionModel>> GetAllStockTransaction(FilterModel filter)
        {
            try
            {
                var httpClient = new HttpClient();
                var json = JsonSerializer.Serialize(filter);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://localhost:5096/Api/Products/GetAllStockTransaction", content);
                var jsonRespose = await response.Content.ReadAsStringAsync();

                var products = JsonSerializer.Deserialize<List<AllStockTransactionModel>>(jsonRespose, new JsonSerializerOptions
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

            products.Insert(0, new ProductModelOutput
            {
                ProductId = 0,
                ProductName = "---"
            });

            comboBoxProTransaction.DataSource = products;
            comboBoxProTransaction.DisplayMember = "ProductName";
            comboBoxProTransaction.ValueMember = "ProductId";
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
        private void LoadTransactionTypeComboBox()
        {
            comBoxType.Items.Clear();
            comBoxType.Items.Add("---");
            comBoxType.Items.Add("In");
            comBoxType.Items.Add("Out");

            comBoxType.SelectedIndex = 0;
        }

        private async void ref_btn_Click(object sender, EventArgs e)
        {
            await RefreshData();
        }
        public async Task RefreshData()
        {
            var nullfilter = new FilterModel
            {
                ProductName = null,
                TransactionType = null,
                TransactionDate = null
            };
            await LoadProductComboBox();
            await LoadProductData(nullfilter);
            LoadTransactionTypeComboBox();
        }

        private async void Filter_btn_Click(object sender, EventArgs e)
        {
            var filter = new FilterModel
            {
                ProductName = comboBoxProTransaction.Text != "---" ? comboBoxProTransaction.Text : null,
                TransactionType = comBoxType.Text != "---" ? comBoxType.Text : null,
                TransactionDate = dateTimePicker1.Checked ? dateTimePicker1.Value : null
            };
        
            await LoadProductData(filter);
        }

        private void checkBoxFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBoxFilterDate.Checked;
        }

    }
}
