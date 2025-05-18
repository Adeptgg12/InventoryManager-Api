namespace InventoryManager
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Sum_Btn = new Button();
            Out_Btn = new Button();
            Add_Btn = new Button();
            panel2 = new Panel();
            sum1 = new sum();
            addItem1 = new AddItem();
            outItems1 = new OutItems();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Sum_Btn);
            panel1.Controls.Add(Out_Btn);
            panel1.Controls.Add(Add_Btn);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Aquamarine;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 786);
            panel1.TabIndex = 0;
            // 
            // Sum_Btn
            // 
            Sum_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Sum_Btn.BackColor = Color.CornflowerBlue;
            Sum_Btn.ForeColor = Color.Transparent;
            Sum_Btn.Location = new Point(13, 423);
            Sum_Btn.Margin = new Padding(4, 3, 4, 3);
            Sum_Btn.Name = "Sum_Btn";
            Sum_Btn.Size = new Size(203, 61);
            Sum_Btn.TabIndex = 2;
            Sum_Btn.Text = "Sum";
            Sum_Btn.UseVisualStyleBackColor = false;
            Sum_Btn.Click += Sum_Btn_Click;
            // 
            // Out_Btn
            // 
            Out_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Out_Btn.BackColor = Color.CornflowerBlue;
            Out_Btn.ForeColor = Color.Transparent;
            Out_Btn.Location = new Point(13, 342);
            Out_Btn.Margin = new Padding(4, 3, 4, 3);
            Out_Btn.Name = "Out_Btn";
            Out_Btn.Size = new Size(203, 61);
            Out_Btn.TabIndex = 1;
            Out_Btn.Text = "Out";
            Out_Btn.UseVisualStyleBackColor = false;
            Out_Btn.Click += Out_Btn_Click;
            // 
            // Add_Btn
            // 
            Add_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Add_Btn.BackColor = Color.CornflowerBlue;
            Add_Btn.ForeColor = Color.Transparent;
            Add_Btn.Location = new Point(13, 256);
            Add_Btn.Margin = new Padding(4, 3, 4, 3);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(203, 61);
            Add_Btn.TabIndex = 0;
            Add_Btn.Text = "Add";
            Add_Btn.UseVisualStyleBackColor = false;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(sum1);
            panel2.Controls.Add(addItem1);
            panel2.Controls.Add(outItems1);
            panel2.Location = new Point(224, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 786);
            panel2.TabIndex = 1;
            // 
            // sum1
            // 
            sum1.Location = new Point(0, 0);
            sum1.Name = "sum1";
            sum1.Size = new Size(764, 786);
            sum1.TabIndex = 2;
            // 
            // addItem1
            // 
            addItem1.Location = new Point(0, 0);
            addItem1.Margin = new Padding(5, 3, 5, 3);
            addItem1.Name = "addItem1";
            addItem1.Size = new Size(713, 786);
            addItem1.TabIndex = 1;
            addItem1.Load += addItem1_Load;
            // 
            // outItems1
            // 
            outItems1.Location = new Point(0, 0);
            outItems1.Margin = new Padding(5, 3, 5, 3);
            outItems1.Name = "outItems1";
            outItems1.Size = new Size(713, 786);
            outItems1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 786);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ProductCheckList";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Out_Btn;
        private System.Windows.Forms.Button Sum_Btn;
        private System.Windows.Forms.Panel panel2;
        private AddItem addItem1;
        private OutItems outItems1;
        private sum sum1;
    }
}

