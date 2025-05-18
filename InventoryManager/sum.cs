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
    public partial class sum : UserControl
    {
        private IProductRepository _productRepository;
        public sum()
        {
            InitializeComponent();
        }
        public void SetProductRepository(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            RefreshData();

            // ตั้งค่า DateTimePicker ให้รองรับการเปิด/ปิด filter
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Checked = false;
            //dateTimePicker1.ShowCheckBox = true;
            //dateTimePicker1.Value = null;

        }
        public void LoadProductData(FilterModel filter = null)
        {
            var products = _productRepository.GetAllStockTransaction(filter)
                .Select(p => new
                {
                    p.ProductId,
                    ProductName = p.Product != null ? p.Product.ProductName : "",  // ดึงจาก navigation
                    p.TransactionType,
                    TransactionDate = p.TransactionDate.ToString("yyyy-MM-dd HH:mm:ss")
                })
                .ToList();

            dataGridViewStockTransaction.DataSource = products;

            dataGridViewStockTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            comboBoxProTransaction.DataSource = products;
            comboBoxProTransaction.DisplayMember = "ProductName";
            comboBoxProTransaction.ValueMember = "ProductId";
        }
        private void LoadTransactionTypeComboBox()
        {
            comBoxType.Items.Clear();
            comBoxType.Items.Add("---");       // ค่า default หรือ placeholder
            comBoxType.Items.Add("In");
            comBoxType.Items.Add("Out");

            comBoxType.SelectedIndex = 0;     // ตั้งให้เลือก "---" เป็นค่าเริ่มต้น
        }

        private void ref_btn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            LoadProductComboBox();
            LoadProductData();
            LoadTransactionTypeComboBox();
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            var filter = new FilterModel
            {
                ProductName = comboBoxProTransaction.Text != "---" ? comboBoxProTransaction.Text : null,
                TransactionType = comBoxType.Text != "---" ? comBoxType.Text : null,
                TransactionDate = dateTimePicker1.Checked ? dateTimePicker1.Value : null
            };

            LoadProductData(filter);
        }

        private void checkBoxFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBoxFilterDate.Checked;
        }

    }
}
