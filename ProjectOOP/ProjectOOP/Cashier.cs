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
    public partial class Cashier : Form
    {
        public double Included;
        public int index;
        public readfile.readfile pro = new readfile.readfile();
        private StreamReader readdata;
        private StreamWriter writedata;
        private StreamWriter printpage;
        public Cashier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pro.readfiledata();
            int i=0;
            button1.Text = pro.name[i];
            button2.Text = pro.name[++i];
            button3.Text = pro.name[++i];
            button4.Text = pro.name[++i];
            button5.Text = pro.name[++i];
            button6.Text = pro.name[++i];
            button7.Text = pro.name[++i];
            button8.Text = pro.name[++i];
            button9.Text = pro.name[++i];
            button10.Text = pro.name[++i];
            button11.Text = pro.name[++i];
            button12.Text = pro.name[++i];
        }
        private void Stock_Click(object sender, EventArgs e)
        {
            Stock page2 = new Stock();
            page2.Show();
        }

        private void Accountbutton_Click(object sender, EventArgs e)
        {
            Account page3 = new Account();
            page3.Show();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Listitem.Items.Clear();
            Included = 0.00;
            includelabel.Text = Convert.ToString(Included+".00");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void itemtotal(int x)
        {
            Included += pro.price[x];
            includelabel.Text = Convert.ToString(Included);
        }
        private void probutton(int x)
        {
            if (pro.number[x] >= 1)
            {
                Listitem.Items.Add(pro.name[x] + "\t\t\t\t" + pro.price[x]);
                itemtotal(x);
                pro.number[x] -= 1;
            }
            else
            {
                Error();
            }
        }
        private void Error()
        {
            MessageBox.Show("สินค้าหมด", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // button
        //

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(3);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(4);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(6);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(7);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(8);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(9);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(10);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button1.Text != null)
            {
                probutton(11);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {

        }
    }
}
