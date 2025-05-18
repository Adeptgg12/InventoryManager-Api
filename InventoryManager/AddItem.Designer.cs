namespace InventoryManager
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            panel1 = new Panel();
            ref_btn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            comboBoxListItem = new ComboBox();
            ADD_btn = new Button();
            Unit_input = new TextBox();
            label5 = new Label();
            ProductName_input = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ref_btn);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 39);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 243);
            panel1.TabIndex = 0;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 43);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(606, 189);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Products Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxListItem);
            panel2.Controls.Add(ADD_btn);
            panel2.Controls.Add(Unit_input);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ProductName_input);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(46, 315);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 451);
            panel2.TabIndex = 1;
            // 
            // comboBoxListItem
            // 
            comboBoxListItem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxListItem.FormattingEnabled = true;
            comboBoxListItem.Location = new Point(178, 51);
            comboBoxListItem.Margin = new Padding(4, 3, 4, 3);
            comboBoxListItem.Name = "comboBoxListItem";
            comboBoxListItem.Size = new Size(428, 23);
            comboBoxListItem.TabIndex = 10;
            // 
            // ADD_btn
            // 
            ADD_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ADD_btn.Location = new Point(299, 247);
            ADD_btn.Margin = new Padding(4, 3, 4, 3);
            ADD_btn.Name = "ADD_btn";
            ADD_btn.Size = new Size(88, 27);
            ADD_btn.TabIndex = 9;
            ADD_btn.Text = "ADD";
            ADD_btn.UseVisualStyleBackColor = true;
            ADD_btn.Click += ADD_btn_Click;
            // 
            // Unit_input
            // 
            Unit_input.Location = new Point(178, 151);
            Unit_input.Margin = new Padding(4, 3, 4, 3);
            Unit_input.Name = "Unit_input";
            Unit_input.Size = new Size(40, 23);
            Unit_input.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 159);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 6;
            label5.Text = "Add Unit";
            // 
            // ProductName_input
            // 
            ProductName_input.Location = new Point(178, 99);
            ProductName_input.Margin = new Padding(4, 3, 4, 3);
            ProductName_input.Name = "ProductName_input";
            ProductName_input.Size = new Size(428, 23);
            ProductName_input.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "ProductName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "List Products";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddItem";
            Size = new Size(764, 786);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductName_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.TextBox Unit_input;
        private System.Windows.Forms.ComboBox comboBoxListItem;
        private Button ref_btn;
    }
}
