using InventoryManager.Infrastructure;
using InventoryManager.Infrastructure.Models;
using InventoryManager.Models;
using InventoryManager.Repositories.Interfaces;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
namespace InventoryManager
{
    public partial class AddItem : UserControl
    {
        //private IProductRepository _productRepository;

        public AddItem()
        {
            InitializeComponent();
        }
        public async void SetProductRepository()
        {
            await RefreshData();
        }
        public async Task LoadProductData()
        {
            var products = await GetAllProducts();

            dataGridView1.DataSource = products;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า TextBox ต้องไม่ว่าง
            if (string.IsNullOrWhiteSpace(ProductName_input.Text) ||
                string.IsNullOrWhiteSpace(Unit_input.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่า Quantity เป็นตัวเลข
            if (!int.TryParse(Unit_input.Text, out int quantity))
            {
                MessageBox.Show("กรุณากรอกจำนวนเป็นตัวเลข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var UpdateP = new ProductModelInput()
            {
                ProductName = ProductName_input.Text,
                Unit = int.Parse(Unit_input.Text)
            };

            AddProductApi(UpdateP);
        }

        public async Task AddProductApi(ProductModelInput UpdateP)
        {
            var httpClient = new HttpClient();
            var json = JsonSerializer.Serialize(UpdateP);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:5096/Api/Products/AddProduct", content);

            if (response.IsSuccessStatusCode)
            {

                MessageBox.Show("เพิ่มสินค้าเรียบร้อย");
                await RefreshData();
                
            }
            else
            {
                MessageBox.Show("เกิดข้อผิดพลาด");
                await RefreshData();
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

            comboBoxListItem.DataSource = products;
            comboBoxListItem.DisplayMember = "ProductName";
            comboBoxListItem.ValueMember = "ProductId";

            comboBoxListItem.SelectedIndexChanged += comboBoxListItem_SelectedIndexChanged;
        }

        private void comboBoxListItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = comboBoxListItem.SelectedItem as ProductModelOutput;

            if (selectedProduct != null && selectedProduct.ProductId != 0)
            {
                ProductName_input.Text = selectedProduct.ProductName;
            }
            else
            {
                ProductName_input.Text = string.Empty;
                Unit_input.Text = string.Empty;
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
