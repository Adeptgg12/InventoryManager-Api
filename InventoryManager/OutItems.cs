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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class OutItems : UserControl
    {
        private IProductRepository _productRepository;
        public OutItems()
        {
            InitializeComponent();
        }
        public void SetProductRepository(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            RefreshData();
            ProductName_input_out.Enabled = false;
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

            dataGridViewOut.DataSource = products;
            dataGridViewOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            comboBoxListItemOut.DataSource = products;
            comboBoxListItemOut.DisplayMember = "ProductName";
            comboBoxListItemOut.ValueMember = "ProductId";

            comboBoxListItemOut.SelectedIndexChanged += comboBoxListItem_SelectedIndexChanged;
        }

        private void comboBoxListItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = comboBoxListItemOut.SelectedItem as ProductModel;

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
            var result = _productRepository.OutProduct(UpdateP);
            if (result == 1)
            {
                MessageBox.Show("Product Outed successfully");
                LoadProductData();
                LoadProductComboBox();
            }
            else if (result == 2)
            {
                MessageBox.Show("ไม่สามารถลบสินค้าได้เนื่องจากจำนวนสินค้าในคลังไม่เพียงพอ");
            }
            else if (result == 3)
            {
                MessageBox.Show("ไม่พบสินค้าที่ต้องการลบ");
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
