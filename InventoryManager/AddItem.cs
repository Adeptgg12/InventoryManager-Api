using InventoryManager.Infrastructure;
using InventoryManager.Infrastructure.Models;
using InventoryManager.Models;
using InventoryManager.Repositories.Interfaces;
using System.Diagnostics;
using System.Xml.Linq;
namespace InventoryManager
{
    public partial class AddItem : UserControl
    {
        private IProductRepository _productRepository;

        public AddItem()
        {
            InitializeComponent();
        }
        public void SetProductRepository(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            RefreshData();
        }
        public void LoadProductData()
        {
            var products = _productRepository.GetAllProducts()
             .Select(p => new
             {
                 p.ProductId,
                 p.ProductName,
                 p.Unit,
                 p.CreatedAt
             })
             .ToList();

            dataGridView1.DataSource = products;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            var result = _productRepository.AddProduct(UpdateP);
            if (result > 0)
            {
                MessageBox.Show("Product added successfully");
                LoadProductData();
                LoadProductComboBox();
            }
            else
            {
                MessageBox.Show("Failed to add product");
            }
        }
        public void LoadProductComboBox()
        {
            var products = _productRepository.GetAllProducts();
            // เพิ่มรายการเปล่าไว้ลำดับแรก
            products.Insert(0, new ProductModel
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
            var selectedProduct = comboBoxListItem.SelectedItem as ProductModel;

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

        private void ref_btn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            LoadProductComboBox();
            LoadProductData();
        }
    }
}
