using InventoryManager.Infrastructure;
using InventoryManager.Infrastructure.Models;
using InventoryManager.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Form1 : Form
    {
        public string productName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            addItem1.Visible = true;
            outItems1.Visible = false;
            sum1.Visible = false;
            addItem1.RefreshData();
            sum1.RefreshData();

        }

        private void Out_Btn_Click(object sender, EventArgs e)
        {
            addItem1.Visible = false;
            outItems1.Visible = true;
            sum1.Visible = false;
            outItems1.RefreshData();
            sum1.RefreshData();

        }

        private void Sum_Btn_Click(object sender, EventArgs e)
        {
            addItem1.Visible = false;
            outItems1.Visible = false;
            sum1.Visible = true;
            outItems1.RefreshData();
            sum1.RefreshData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productRepository = Connection();
            addItem1.SetProductRepository(productRepository);
            outItems1.SetProductRepository(productRepository);
            sum1.SetProductRepository(productRepository);
        }

        public ProductRepository Connection()
        {
            var connectionString = "Server=DESKTOP-DHD9UCL\\SQLEXPRESS;Database=InventoryDb;Trusted_Connection=True;TrustServerCertificate=True;";

            var options = new DbContextOptionsBuilder<InventoryManagerDbContext>()
                .UseSqlServer(connectionString, opts => opts.CommandTimeout(600))
                .Options;

            var dbContext = new InventoryManagerDbContext(options);
            var productRepo = new ProductRepository(dbContext);
            return productRepo;
        }

        private void addItem1_Load(object sender, EventArgs e)
        {

        }

    }
}
