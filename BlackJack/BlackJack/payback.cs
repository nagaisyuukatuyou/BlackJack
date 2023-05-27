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
    public partial class payback : Form
    {
        Form1 ra = new Form1();
        public static int del = 0;
        public payback()
        {
            InitializeComponent();
        }

        private void payback_Load(object sender, EventArgs e)
        {
            label1.Text = "借金総額 " + loan.loantotal;
            label2.Text = "最低返済額 " + loan.interesttotal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loan.deadline == 0)
            {
                loan.deadline = 10;
                del++;
                loan.loantotal += loan.interesttotal;
                loan.interesttotal = 0;
                loan.interest = loan.loantotal / 20;
                MessageBox.Show("滞納しました。現在借金総額" + loan.loantotal + "moneyです。利息はこの金額から5%つきます。", "完了");

                Properties.Settings.Default.loantotalData = loan.loantotal;
                Properties.Settings.Default.moneyData = Form1.money;
                Properties.Settings.Default.deadlineData = loan.deadline;
                Properties.Settings.Default.interesttotalData = loan.interesttotal;
                Properties.Settings.Default.delData = del;

                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("まだ期限ではありません");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("値が入力されていません", "エラー");
            }
            else
            {
                long payBack = long.Parse(textBox1.Text);
                if (payBack < loan.interesttotal || payBack > Form1.money)
                {
                    MessageBox.Show("足りません", "エラー");
                }
                else
                {

                    if (payBack >= loan.loantotal)
                    {
                        Form1.money -= loan.loantotal;
                        MessageBox.Show(loan.loantotal + "money返済しました。完済おめでとうございます。", "完了");
                        loan.loantotal = 0;
                        loan.interest = 0;

                        if (Form1.money > Form1.maxmoney)
                        {
                            Form1.maxmoney = Form1.money;
                        }

                        Form1.rank = ra.Rank(Form1.money);
                        Form1.ranking = ra.Ranking(Form1.maxmoney);

                    }
                    else
                    {
                        Form1.money -= payBack;
                        loan.loantotal -= payBack;
                        loan.interest = loan.loantotal / 20;
                        MessageBox.Show(payBack + "money返済しました。残りの借金総額は" + loan.loantotal + "moneyです。", "完了");
                    }

                    loan.interesttotal = 0;
                    loan.deadline = 10;

                    label1.Text = "借金総額 " + loan.loantotal;
                    label2.Text = "最低返済額 " + loan.interesttotal;

                    Properties.Settings.Default.loantotalData = loan.loantotal;
                    Properties.Settings.Default.moneyData = Form1.money;
                    Properties.Settings.Default.deadlineData = loan.deadline;
                    Properties.Settings.Default.interesttotalData = loan.interesttotal;
                    Properties.Settings.Default.rankingData = Form1.ranking;

                    Properties.Settings.Default.Save();

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;
            financing f = new financing();
            f.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b')
            {
                return;
            }

            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
