namespace ProjectOOP
{
    partial class MarketCost
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
            this.MarketCostlist = new System.Windows.Forms.ListBox();
            this.botton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MarketCostlist
            // 
            this.MarketCostlist.FormattingEnabled = true;
            this.MarketCostlist.Location = new System.Drawing.Point(13, 54);
            this.MarketCostlist.Name = "MarketCostlist";
            this.MarketCostlist.Size = new System.Drawing.Size(318, 199);
            this.MarketCostlist.TabIndex = 0;
            // 
            // botton1
            // 
            this.botton1.Location = new System.Drawing.Point(12, 259);
            this.botton1.Name = "botton1";
            this.botton1.Size = new System.Drawing.Size(75, 23);
            this.botton1.TabIndex = 1;
            this.botton1.Text = "หน้าร้าน";
            this.botton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "บัญชี";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "คลังสินค้า";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "แก้ไขสินค้า";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MarketCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 289);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botton1);
            this.Controls.Add(this.MarketCostlist);
            this.Name = "MarketCost";
            this.Text = "ราคากลาง";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MarketCostlist;
        private System.Windows.Forms.Button botton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}