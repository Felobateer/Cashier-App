namespace Cashier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Inventory = new Label();
            Checkout = new Label();
            Cashier = new Label();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            InventoryBox = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            InventoryBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(622, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 99);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Inventory
            // 
            Inventory.AutoSize = true;
            Inventory.Location = new Point(85, 114);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(57, 15);
            Inventory.TabIndex = 1;
            Inventory.Text = "Inventory";
            Inventory.Click += label1_Click;
            // 
            // Checkout
            // 
            Checkout.AutoSize = true;
            Checkout.Location = new Point(84, 250);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(58, 15);
            Checkout.TabIndex = 2;
            Checkout.Text = "Checkout";
            // 
            // Cashier
            // 
            Cashier.AutoSize = true;
            Cashier.Location = new Point(85, 186);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(46, 15);
            Cashier.TabIndex = 3;
            Cashier.Text = "Cashier";
            // 
            // InventoryBox
            // 
            InventoryBox.Controls.Add(label5);
            InventoryBox.Controls.Add(tableLayoutPanel1);
            InventoryBox.Controls.Add(button1);
            InventoryBox.Controls.Add(label4);
            InventoryBox.Controls.Add(label3);
            InventoryBox.Controls.Add(label2);
            InventoryBox.Controls.Add(label1);
            InventoryBox.Controls.Add(textBox4);
            InventoryBox.Controls.Add(textBox3);
            InventoryBox.Controls.Add(textBox2);
            InventoryBox.Controls.Add(textBox1);
            InventoryBox.Location = new Point(298, 114);
            InventoryBox.Name = "InventoryBox";
            InventoryBox.Size = new Size(1003, 439);
            InventoryBox.TabIndex = 4;
            InventoryBox.TabStop = false;
            InventoryBox.Text = "Inventory";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(395, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(60, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(395, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 100);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 164);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 228);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 308);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(60, 391);
            button1.Name = "button1";
            button1.Size = new Size(121, 28);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Location = new Point(623, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(364, 233);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 100);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 699);
            Controls.Add(InventoryBox);
            Controls.Add(Cashier);
            Controls.Add(Checkout);
            Controls.Add(Inventory);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            InventoryBox.ResumeLayout(false);
            InventoryBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Inventory;
        private Label Checkout;
        private Label Cashier;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private GroupBox InventoryBox;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
