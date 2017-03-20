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
    public partial class Itemedit : Form
    {
        public readfile.readfile pro = new readfile.readfile();
        public int index;
        public Itemedit(int i)
        {
            index = i;
            InitializeComponent();
        }

        private void acbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                int resever1 = int.Parse(item_numberbox.Text);
                pro.price[index] = double.Parse(Costbox.Text);
                if (resever1 > pro.number[index])
                {
                    int i = resever1 - pro.number[index];
                    double log = i * pro.price[index];
                    Buildlogfile(index, i, log);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("กรุณากำหนดจำนวนสินค้ามากว่าเก่า", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Itemedit_Load(object sender, EventArgs e)
        {
            pro.readfiledata();
            item_namebox.Text = pro.name[index];
            item_numberbox.Text = Convert.ToString(pro.number[index]);
            pricebox.Text = Convert.ToString(pro.price[index]);
            Costbox.Text = Convert.ToString(pro.cash[index]);
        }
        public void Buildlogfile(int index , int n,double total)
        {
            StreamWriter log = new StreamWriter("history.txt");
            log.WriteLine(pro.name[index]);
            log.WriteLine(n);
            log.WriteLine("-");
            log.WriteLine(total);
            log.Close();
        }
    }

    public class writefile
    {
        public readfile.readfile pro = new readfile.readfile();

    }
}
