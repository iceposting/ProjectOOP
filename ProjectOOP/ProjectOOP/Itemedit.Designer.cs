namespace ProjectOOP
{
    partial class Itemedit
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
            this.label1 = new System.Windows.Forms.Label();
            this.item_namebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.item_numberbox = new System.Windows.Forms.TextBox();
            this.Costbox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acbutton1 = new System.Windows.Forms.Button();
            this.ccbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // item_namebox
            // 
            this.item_namebox.Location = new System.Drawing.Point(85, 10);
            this.item_namebox.Name = "item_namebox";
            this.item_namebox.ReadOnly = true;
            this.item_namebox.Size = new System.Drawing.Size(100, 20);
            this.item_namebox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "จำนวนสินค้า";
            // 
            // item_numberbox
            // 
            this.item_numberbox.Location = new System.Drawing.Point(85, 44);
            this.item_numberbox.Name = "item_numberbox";
            this.item_numberbox.Size = new System.Drawing.Size(100, 20);
            this.item_numberbox.TabIndex = 3;
            // 
            // Costbox
            // 
            this.Costbox.Location = new System.Drawing.Point(85, 79);
            this.Costbox.Name = "Costbox";
            this.Costbox.ReadOnly = true;
            this.Costbox.Size = new System.Drawing.Size(100, 20);
            this.Costbox.TabIndex = 4;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(85, 116);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(100, 20);
            this.pricebox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ราคาต้นทุน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ราคาขาย";
            // 
            // acbutton1
            // 
            this.acbutton1.Location = new System.Drawing.Point(128, 178);
            this.acbutton1.Name = "acbutton1";
            this.acbutton1.Size = new System.Drawing.Size(100, 23);
            this.acbutton1.TabIndex = 9;
            this.acbutton1.Text = "ยืนยันการแก้ไข";
            this.acbutton1.UseVisualStyleBackColor = true;
            this.acbutton1.Click += new System.EventHandler(this.acbutton1_Click);
            // 
            // ccbutton
            // 
            this.ccbutton.Location = new System.Drawing.Point(16, 178);
            this.ccbutton.Name = "ccbutton";
            this.ccbutton.Size = new System.Drawing.Size(106, 23);
            this.ccbutton.TabIndex = 10;
            this.ccbutton.Text = "ล้างรายการ";
            this.ccbutton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "บาท/ชิ้น";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "บาท/ชิ้น";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ชิ้น";
            // 
            // Itemedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 213);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccbutton);
            this.Controls.Add(this.acbutton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.Costbox);
            this.Controls.Add(this.item_numberbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_namebox);
            this.Controls.Add(this.label1);
            this.Name = "Itemedit";
            this.Text = "แก้ไข";
            this.Load += new System.EventHandler(this.Itemedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_namebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox item_numberbox;
        private System.Windows.Forms.TextBox Costbox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button acbutton1;
        private System.Windows.Forms.Button ccbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}