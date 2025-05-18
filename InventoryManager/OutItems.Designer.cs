namespace InventoryManager
{
    partial class OutItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutItems));
            panel1 = new Panel();
            ref_btn = new Button();
            dataGridViewOut = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            Out_btn = new Button();
            comboBoxListItemOut = new ComboBox();
            Unit_input_out = new TextBox();
            label5 = new Label();
            ProductName_input_out = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ref_btn);
            panel1.Controls.Add(dataGridViewOut);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 39);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 243);
            panel1.TabIndex = 2;
            // 
            // ref_btn
            // 
            ref_btn.Image = (Image)resources.GetObject("ref_btn.Image");
            ref_btn.Location = new Point(607, 12);
            ref_btn.Name = "ref_btn";
            ref_btn.Size = new Size(25, 25);
            ref_btn.TabIndex = 12;
            ref_btn.UseVisualStyleBackColor = true;
            ref_btn.Click += ref_btn_Click;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(26, 43);
            dataGridViewOut.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(606, 189);
            dataGridViewOut.TabIndex = 1;
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
            panel2.Controls.Add(Out_btn);
            panel2.Controls.Add(comboBoxListItemOut);
            panel2.Controls.Add(Unit_input_out);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ProductName_input_out);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(46, 315);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 451);
            panel2.TabIndex = 3;
            // 
            // Out_btn
            // 
            Out_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Out_btn.Location = new Point(299, 247);
            Out_btn.Margin = new Padding(4, 3, 4, 3);
            Out_btn.Name = "Out_btn";
            Out_btn.Size = new Size(88, 27);
            Out_btn.TabIndex = 11;
            Out_btn.Text = "Out";
            Out_btn.UseVisualStyleBackColor = true;
            Out_btn.Click += Out_btn_Click;
            // 
            // comboBoxListItemOut
            // 
            comboBoxListItemOut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxListItemOut.FormattingEnabled = true;
            comboBoxListItemOut.Location = new Point(178, 51);
            comboBoxListItemOut.Margin = new Padding(4, 3, 4, 3);
            comboBoxListItemOut.Name = "comboBoxListItemOut";
            comboBoxListItemOut.Size = new Size(428, 23);
            comboBoxListItemOut.TabIndex = 10;
            // 
            // Unit_input_out
            // 
            Unit_input_out.Location = new Point(178, 151);
            Unit_input_out.Margin = new Padding(4, 3, 4, 3);
            Unit_input_out.Name = "Unit_input_out";
            Unit_input_out.Size = new Size(40, 23);
            Unit_input_out.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 159);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 6;
            label5.Text = "Out Unit";
            // 
            // ProductName_input_out
            // 
            ProductName_input_out.Location = new Point(178, 99);
            ProductName_input_out.Margin = new Padding(4, 3, 4, 3);
            ProductName_input_out.Name = "ProductName_input_out";
            ProductName_input_out.Size = new Size(428, 23);
            ProductName_input_out.TabIndex = 3;
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
            // OutItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OutItems";
            Size = new Size(733, 786);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewOut;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBoxListItemOut;
        private TextBox Unit_input_out;
        private Label label5;
        private TextBox ProductName_input_out;
        private Label label3;
        private Label label2;
        private Button Out_btn;
        private Button ref_btn;
    }
}
