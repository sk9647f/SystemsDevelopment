namespace TicketBookingSystem
{
    partial class BasketForm
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
            this.Listl = new System.Windows.Forms.Label();
            this.Confirmb = new System.Windows.Forms.Button();
            this.DeleteOrderB = new System.Windows.Forms.Button();
            this.OrderBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinalPricel = new System.Windows.Forms.Label();
            this.InputDiscountb = new System.Windows.Forms.Button();
            this.DiscountBox = new System.Windows.Forms.TextBox();
            this.Discountl = new System.Windows.Forms.Label();
            this.ConfirmDetailsl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listl
            // 
            this.Listl.Location = new System.Drawing.Point(12, 33);
            this.Listl.Name = "Listl";
            this.Listl.Size = new System.Drawing.Size(350, 430);
            this.Listl.TabIndex = 25;
            // 
            // Confirmb
            // 
            this.Confirmb.Location = new System.Drawing.Point(407, 256);
            this.Confirmb.Name = "Confirmb";
            this.Confirmb.Size = new System.Drawing.Size(95, 23);
            this.Confirmb.TabIndex = 26;
            this.Confirmb.Text = "Confirm Order";
            this.Confirmb.UseVisualStyleBackColor = true;
            this.Confirmb.Click += new System.EventHandler(this.Confirmb_Click);
            // 
            // DeleteOrderB
            // 
            this.DeleteOrderB.Location = new System.Drawing.Point(407, 227);
            this.DeleteOrderB.Name = "DeleteOrderB";
            this.DeleteOrderB.Size = new System.Drawing.Size(95, 23);
            this.DeleteOrderB.TabIndex = 27;
            this.DeleteOrderB.Text = "Delete Order";
            this.DeleteOrderB.UseVisualStyleBackColor = true;
            this.DeleteOrderB.Click += new System.EventHandler(this.DeleteOrderB_Click);
            // 
            // OrderBox
            // 
            this.OrderBox.FormattingEnabled = true;
            this.OrderBox.Location = new System.Drawing.Point(393, 118);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(121, 21);
            this.OrderBox.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FinalPricel);
            this.panel1.Controls.Add(this.InputDiscountb);
            this.panel1.Controls.Add(this.DiscountBox);
            this.panel1.Controls.Add(this.Discountl);
            this.panel1.Controls.Add(this.ConfirmDetailsl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 480);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // FinalPricel
            // 
            this.FinalPricel.AutoSize = true;
            this.FinalPricel.Location = new System.Drawing.Point(3, 282);
            this.FinalPricel.Name = "FinalPricel";
            this.FinalPricel.Size = new System.Drawing.Size(56, 13);
            this.FinalPricel.TabIndex = 4;
            this.FinalPricel.Text = "Final Price";
            // 
            // InputDiscountb
            // 
            this.InputDiscountb.Location = new System.Drawing.Point(83, 158);
            this.InputDiscountb.Name = "InputDiscountb";
            this.InputDiscountb.Size = new System.Drawing.Size(90, 23);
            this.InputDiscountb.TabIndex = 3;
            this.InputDiscountb.Text = "Input Discount";
            this.InputDiscountb.UseVisualStyleBackColor = true;
            this.InputDiscountb.Click += new System.EventHandler(this.InputDiscountb_Click);
            // 
            // DiscountBox
            // 
            this.DiscountBox.Location = new System.Drawing.Point(16, 132);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(157, 20);
            this.DiscountBox.TabIndex = 2;
            // 
            // Discountl
            // 
            this.Discountl.AutoSize = true;
            this.Discountl.Location = new System.Drawing.Point(13, 106);
            this.Discountl.Name = "Discountl";
            this.Discountl.Size = new System.Drawing.Size(160, 13);
            this.Discountl.TabIndex = 1;
            this.Discountl.Text = "Enter any Discount codes below";
            // 
            // ConfirmDetailsl
            // 
            this.ConfirmDetailsl.AutoSize = true;
            this.ConfirmDetailsl.Location = new System.Drawing.Point(13, 21);
            this.ConfirmDetailsl.Name = "ConfirmDetailsl";
            this.ConfirmDetailsl.Size = new System.Drawing.Size(35, 13);
            this.ConfirmDetailsl.TabIndex = 0;
            this.ConfirmDetailsl.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Confirm Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderBox);
            this.Controls.Add(this.DeleteOrderB);
            this.Controls.Add(this.Confirmb);
            this.Controls.Add(this.Listl);
            this.Name = "BasketForm";
            this.Text = "Basket View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Listl;
        private System.Windows.Forms.Button Confirmb;
        private System.Windows.Forms.Button DeleteOrderB;
        private System.Windows.Forms.ComboBox OrderBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FinalPricel;
        private System.Windows.Forms.Button InputDiscountb;
        private System.Windows.Forms.TextBox DiscountBox;
        private System.Windows.Forms.Label Discountl;
        private System.Windows.Forms.Label ConfirmDetailsl;
        private System.Windows.Forms.Button button1;
    }
}