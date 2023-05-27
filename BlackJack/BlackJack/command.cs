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
    public partial class command : Form
    {
        Boolean moneycommand = false;
        public command()
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
                if (moneycommand)
                {
                    long getmoney = long.Parse(textBox1.Text);
                    Form1.money += getmoney;
                    moneycommand = false;
                    Properties.Settings.Default.moneyData = Form1.money;
                    Properties.Settings.Default.Save();
                    MessageBox.Show(getmoney + "money獲得しました","成功");
                }
                else if(textBox1.Text == "get money")
                {
                    MessageBox.Show("必要なmoneyを数字で入力してください");
                    moneycommand = true;
                }
                else if(textBox1.Text == "loan clear")
                {
                    MessageBox.Show("借金を帳消しにしました", "成功");
                    loan.loantotal = 0;
                    loan.interesttotal = 0;
                    payback.del = 0;
                    loan.deadline = 10;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;

            title t = new title();
            t.Show();
        }
    }
}
