namespace ProjectOOP
{
    partial class Stock
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
            this.Stocklist = new System.Windows.Forms.ListBox();
            this.CashierButton = new System.Windows.Forms.Button();
            this.Accountbutton = new System.Windows.Forms.Button();
            this.Costbutton = new System.Windows.Forms.Button();
            this.Edititembutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stocklist
            // 
            this.Stocklist.FormattingEnabled = true;
            this.Stocklist.Location = new System.Drawing.Point(13, 38);
            this.Stocklist.Name = "Stocklist";
            this.Stocklist.Size = new System.Drawing.Size(360, 199);
            this.Stocklist.TabIndex = 0;
            // 
            // CashierButton
            // 
            this.CashierButton.Location = new System.Drawing.Point(13, 243);
            this.CashierButton.Name = "CashierButton";
            this.CashierButton.Size = new System.Drawing.Size(75, 23);
            this.CashierButton.TabIndex = 1;
            this.CashierButton.Text = "หน้าร้าน";
            this.CashierButton.UseVisualStyleBackColor = true;
            this.CashierButton.Click += new System.EventHandler(this.CashierButton_Click);
            // 
            // Accountbutton
            // 
            this.Accountbutton.Location = new System.Drawing.Point(105, 243);
            this.Accountbutton.Name = "Accountbutton";
            this.Accountbutton.Size = new System.Drawing.Size(75, 23);
            this.Accountbutton.TabIndex = 2;
            this.Accountbutton.Text = "บัญชี";
            this.Accountbutton.UseVisualStyleBackColor = true;
            // 
            // Costbutton
            // 
            this.Costbutton.Location = new System.Drawing.Point(200, 243);
            this.Costbutton.Name = "Costbutton";
            this.Costbutton.Size = new System.Drawing.Size(75, 23);
            this.Costbutton.TabIndex = 3;
            this.Costbutton.Text = "ราคากลาง";
            this.Costbutton.UseVisualStyleBackColor = true;
            // 
            // Edititembutton
            // 
            this.Edititembutton.Location = new System.Drawing.Point(298, 243);
            this.Edititembutton.Name = "Edititembutton";
            this.Edititembutton.Size = new System.Drawing.Size(75, 23);
            this.Edititembutton.TabIndex = 4;
            this.Edititembutton.Text = "แก้ไขสินค้า";
            this.Edititembutton.UseVisualStyleBackColor = true;
            this.Edititembutton.Click += new System.EventHandler(this.Edititembutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "รายการ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "จำนวน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ต้นทุน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ราคาขาย";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edititembutton);
            this.Controls.Add(this.Costbutton);
            this.Controls.Add(this.Accountbutton);
            this.Controls.Add(this.CashierButton);
            this.Controls.Add(this.Stocklist);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Stocklist;
        private System.Windows.Forms.Button CashierButton;
        private System.Windows.Forms.Button Accountbutton;
        private System.Windows.Forms.Button Costbutton;
        private System.Windows.Forms.Button Edititembutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}