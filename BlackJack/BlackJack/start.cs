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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            Form1.money = Properties.Settings.Default.moneyData;
            Form1.maxmoney = Properties.Settings.Default.maxMoneyData;
            Form1.win = Properties.Settings.Default.winData;
            Form1.rank = Properties.Settings.Default.rankData;
            Form1.ranking = Properties.Settings.Default.rankingData;
            Form1.play = Properties.Settings.Default.playData;
            loan.loantotal = Properties.Settings.Default.loantotalData;
            loan.interesttotal = Properties.Settings.Default.interesttotalData;
            payback.del = Properties.Settings.Default.delData;
            loan.deadline = Properties.Settings.Default.deadlineData;

            loan.interest = loan.loantotal / 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (payback.del >= 20)
            {
                MessageBox.Show("あなたは滞納しすぎたのでもうこのゲームをできません", "Good bye");
            }
            else if (loan.loantotal >= 1000000000)
            {
                MessageBox.Show("あなたは借金が10億を超えたのでもうこのゲームをできません", "Good bye");
            }
            else
            {
                Visible = false;

                title t = new title();
                t.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("値が入力されていません", "エラー");
            }
            else
            {

                int pass = int.Parse(textBox1.Text);
                if (pass == 213)
                {
                    Properties.Settings.Default.Reset();

                    Form1.money = Properties.Settings.Default.moneyData;
                    Form1.maxmoney = Properties.Settings.Default.maxMoneyData;
                    Form1.win = Properties.Settings.Default.winData;
                    Form1.rank = Properties.Settings.Default.rankData;
                    Form1.ranking = Properties.Settings.Default.rankingData;
                    Form1.play = Properties.Settings.Default.playData;
                    loan.loantotal = Properties.Settings.Default.loantotalData;
                    loan.interesttotal = Properties.Settings.Default.interesttotalData;
                    payback.del = Properties.Settings.Default.delData;
                    loan.deadline = Properties.Settings.Default.deadlineData;

                    loan.interest = loan.loantotal / 10;

                    MessageBox.Show("データをリセットしました。おかえりなさい。", "成功");
                }
                else
                {

                    MessageBox.Show("パスワードが違います", "エラー");
                }
            }
        }
    }
}
