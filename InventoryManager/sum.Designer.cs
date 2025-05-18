namespace InventoryManager
{
    partial class sum
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sum));
            panel1 = new Panel();
            checkBoxFilterDate = new CheckBox();
            Filter_btn = new Button();
            comBoxType = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBoxProTransaction = new ComboBox();
            ref_btn = new Button();
            dataGridViewStockTransaction = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockTransaction).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(checkBoxFilterDate);
            panel1.Controls.Add(Filter_btn);
            panel1.Controls.Add(comBoxType);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxProTransaction);
            panel1.Controls.Add(ref_btn);
            panel1.Controls.Add(dataGridViewStockTransaction);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 39);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 724);
            panel1.TabIndex = 1;
            // 
            // checkBoxFilterDate
            // 
            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Location = new Point(350, 25);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Size = new Size(76, 19);
            checkBoxFilterDate.TabIndex = 18;
            checkBoxFilterDate.Text = "FilterDate";
            checkBoxFilterDate.UseVisualStyleBackColor = true;
            checkBoxFilterDate.CheckedChanged += checkBoxFilterDate_CheckedChanged;
            // 
            // Filter_btn
            // 
            Filter_btn.Location = new Point(590, 50);
            Filter_btn.Name = "Filter_btn";
            Filter_btn.Size = new Size(75, 23);
            Filter_btn.TabIndex = 17;
            Filter_btn.Text = "Filter";
            Filter_btn.UseVisualStyleBackColor = true;
            Filter_btn.Click += Filter_btn_Click;
            // 
            // comBoxType
            // 
            comBoxType.DisplayMember = "In";
            comBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxType.FormattingEnabled = true;
            comBoxType.Location = new Point(544, 50);
            comBoxType.Margin = new Padding(4, 3, 4, 3);
            comBoxType.Name = "comBoxType";
            comBoxType.Size = new Size(42, 23);
            comBoxType.TabIndex = 16;
            comBoxType.ValueMember = "In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 56);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 15;
            label4.Text = "Types";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 14;
            label3.Text = "ProductName";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(350, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 12;
            label2.Text = "ProductName";
            // 
            // comboBoxProTransaction
            // 
            comboBoxProTransaction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProTransaction.FormattingEnabled = true;
            comboBoxProTransaction.Location = new Point(115, 50);
            comboBoxProTransaction.Margin = new Padding(4, 3, 4, 3);
            comboBoxProTransaction.Name = "comboBoxProTransaction";
            comboBoxProTransaction.Size = new Size(139, 23);
            comboBoxProTransaction.TabIndex = 11;
            // 
            // ref_btn
            // 
            ref_btn.BackColor = SystemColors.Menu;
            ref_btn.Image = (Image)resources.GetObject("ref_btn.Image");
            ref_btn.Location = new Point(607, 12);
            ref_btn.Name = "ref_btn";
            ref_btn.Size = new Size(25, 25);
            ref_btn.TabIndex = 2;
            ref_btn.UseVisualStyleBackColor = false;
            ref_btn.Click += ref_btn_Click;
            // 
            // dataGridViewStockTransaction
            // 
            dataGridViewStockTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStockTransaction.Location = new Point(26, 79);
            dataGridViewStockTransaction.Margin = new Padding(4, 3, 4, 3);
            dataGridViewStockTransaction.Name = "dataGridViewStockTransaction";
            dataGridViewStockTransaction.Size = new Size(606, 469);
            dataGridViewStockTransaction.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "StockTransaction";
            // 
            // sum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "sum";
            Size = new Size(764, 786);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockTransaction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ref_btn;
        private DataGridView dataGridViewStockTransaction;
        private Label label1;
        private ComboBox comboBoxProTransaction;
        private Label label2;
        private ComboBox comBoxType;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button Filter_btn;
        private CheckBox checkBoxFilterDate;
    }
}
