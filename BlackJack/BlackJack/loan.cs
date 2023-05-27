using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class loan : Form
    {
        public static long loantotal = 0;
        public static long principal;
        public static long interest;
        public static long interesttotal;
        public static int deadline = 10;
        public loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("値が入力されていません", "エラー");
            }
            else
            {
                principal = long.Parse(textBox1.Text);
                Form1.money += principal;
                loantotal += principal;
                interest = loantotal / 20;
                MessageBox.Show(principal + "moneyをご融資しました。返済期限は" + deadline + "ゲーム後です。", "完了");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;

            financing f = new financing();
            f.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\b')
            {
                return;
            }

            if((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;   
            }
        }
    }
}
