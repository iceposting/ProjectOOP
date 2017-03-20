namespace ProjectOOP
{
    partial class Edititem
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
            this.list_item = new System.Windows.Forms.ListBox();
            this.Cashies = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_item
            // 
            this.list_item.FormattingEnabled = true;
            this.list_item.Location = new System.Drawing.Point(10, 68);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(318, 199);
            this.list_item.TabIndex = 0;
            this.list_item.SelectedIndexChanged += new System.EventHandler(this.list_item_SelectedIndexChanged);
            // 
            // Cashies
            // 
            this.Cashies.Location = new System.Drawing.Point(13, 273);
            this.Cashies.Name = "Cashies";
            this.Cashies.Size = new System.Drawing.Size(75, 23);
            this.Cashies.TabIndex = 1;
            this.Cashies.Text = "หน้าร้าน";
            this.Cashies.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(94, 273);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(75, 23);
            this.Account.TabIndex = 2;
            this.Account.Text = "บัญชี";
            this.Account.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(175, 273);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(75, 23);
            this.Stock.TabIndex = 3;
            this.Stock.Text = "คลังสินค้า";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(256, 273);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "แก้ไข";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Edititem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Cashies);
            this.Controls.Add(this.list_item);
            this.Name = "Edititem";
            this.Text = "แก้ไขสินค้า";
            this.Load += new System.EventHandler(this.Edititem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_item;
        private System.Windows.Forms.Button Cashies;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button Edit;
    }
}