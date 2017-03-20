using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using readfile;

namespace ProjectOOP
{
    public partial class Stock : Form
    {
        public readfile.readfile pro = new readfile.readfile();

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            pro.readfiledata();
            for (int index = 0;index <= 11;index++)
            {
                if (pro.name[index] != null)
                {
                    Stocklist.Items.Add(pro.name[index] + "\t\t" + pro.number[index] + " ชิ้น\t\t" + pro.price[index] + "/ชิ้น\t\t" + pro.cash[index] + "/ชิ้น");
                }
            }
        }

        private void CashierButton_Click(object sender, EventArgs e)
        {
            Cashier page1 = new Cashier();
            this.Close();
        }

        private void Edititembutton_Click(object sender, EventArgs e)
        {
            int selectindex = Stocklist.SelectedIndex;
            if (selectindex != -1)
            {
                Itemedit page = new Itemedit(selectindex);
                page.ShowDialog();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการแก้ไข", "Error!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

    }
}
