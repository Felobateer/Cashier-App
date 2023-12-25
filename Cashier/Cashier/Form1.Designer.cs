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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(230, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 99);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Inventory
            // 
            Inventory.AutoSize = true;
            Inventory.Location = new Point(967, 96);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(57, 15);
            Inventory.TabIndex = 1;
            Inventory.Text = "Inventory";
            Inventory.Click += label1_Click;
            // 
            // Checkout
            // 
            Checkout.AutoSize = true;
            Checkout.Location = new Point(1178, 96);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(58, 15);
            Checkout.TabIndex = 2;
            Checkout.Text = "Checkout";
            // 
            // Cashier
            // 
            Cashier.AutoSize = true;
            Cashier.Location = new Point(1077, 96);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(46, 15);
            Cashier.TabIndex = 3;
            Cashier.Text = "Cashier";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 699);
            Controls.Add(Cashier);
            Controls.Add(Checkout);
            Controls.Add(Inventory);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Inventory;
        private Label Checkout;
        private Label Cashier;
    }
}
