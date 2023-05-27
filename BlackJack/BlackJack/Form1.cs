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
    public partial class Form1 : Form
    {
        Random r = new Random();
        Convert c = new Convert();
        

        string [] d = new string[5];
        int? [] dData = new int?[5];
        string [] p = new string[5];
        int?[] pData = new int?[5];
        int i = 0;
        int? pTotal;
        int? dTotal;
        long bed = 100;
        public static long money = 1000;
        public static double win = 0;
        public static double play = 0;
        public static string rank = "貧民";
        public static string ranking;
        public static long maxmoney = 1000;
        public static double wp;
        Boolean startAccess = true;
        Boolean hitAccess = false;
        Boolean standAccess = false;
        Boolean BlackJack = false;
        Boolean bedAccess = true;
        Boolean bedupAccess = true;
        Boolean beddownAccess = true;


        public Form1()
        {
            InitializeComponent();
             
    }


        private void button3_Click(object sender, EventArgs e) //start
        {
            if(loan.deadline == 0)
            {
                MessageBox.Show("返済期限です。闇金で手続きしてください。");
            }
            else if (money <= 0)
            {
                label3.Text = "GMAE OVER";

            }
            else if (money < bed)
            {
                label3.Text = "所持金の範囲内で賭けて";
            }
            else
            {
                if (startAccess)
                {
                    startAccess = false;
                    hitAccess = true;
                    standAccess = true;
                    bedAccess = false;
                    bedupAccess = false;
                    beddownAccess = false;

                    if (loan.loantotal > 0)
                    {
                        loan.loantotal += loan.interest;
                        loan.interesttotal += loan.interest;
                        loan.deadline--;
                    }
                    play++;

                   rank = Rank(money);
                    

                    money -= bed;
                   

                    for (i = 0; i < 5; i++)       //リセット
                    {
                        d[i] = null;
                        p[i] = null;
                        dData[i] = null;
                        pData[i] = null;
                    }

                    dTotal = 0;
                    pTotal = 0;

                    label4.Text = "Total";

                    for (i = 0; i < 2; i++)
                    {
                        dData[i] = r.Next(1, 14);
                        d[i] = dData[i].ToString();
                        d[i] = c.isCon(d[i]);
                        dData[i] = c.tenCon(dData[i]);

                        pData[i] = r.Next(1, 14);
                        p[i] = pData[i].ToString();
                        p[i] = c.isCon(p[i]);
                        pData[i] = c.tenCon(pData[i]);
                    }

                    if (p[0] == "A" && p[1] == "A")
                        pData[0] = 1;

                    if (d[0] == "A" && d[1] == "A")
                        dData[0] = 1;

                    if (p[1] == "A" && (p[0] == "J" || p[0] == "Q" || p[0] == "K"))
                    {
                        BlackJack = true;
                    }
                    else if (p[0] == "A" && (p[1] == "J" || p[1] == "Q" || p[1] == "K"))
                    {
                        BlackJack = true;
                    }
                    else
                    {
                        BlackJack = false;
                    }

                    label1.Text = d[0] + "," + "?";
                    label2.Text = p[0] + "," + p[1];
                    label3.Text = "hit or stand";
                    label7.Text = "money " + money;
                    label8.Text = "×2or×10";

                    pTotal = pData[0] + pData[1];
                    dTotal = dData[0] + dData[1];

                    label5.Text = "" + pTotal;
                }
                else
                    label3.Text = "ゲームを完了してください";
            }
         }

        private void button2_Click(object sender, EventArgs e) //hit
        {
            if (hitAccess)
            {
                if (i < 5)
                {
                    pData[i] = r.Next(1, 14);
                    p[i] = pData[i].ToString();
                    p[i] = c.isCon(p[i]);           //1,11~13をA,J,Q,Kに変換
                    pData[i] = c.tenCon(pData[i]);  //1を11,11~13を10に変換


                    label2.Text = p[0] + "," + p[1] + "," + p[2] + "," + p[3] + "," + p[4];

                    if (pTotal + pData[i] > 21)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (p[j] == "A")
                            {
                                if (pData[j] == 11)
                                {
                                    if (j == 0 || j == 1)
                                    {
                                        pTotal -= 10;
                                    }
                                    pData[j] = 1;
                                    break;
                                }
                            }
                        }

                        if (pTotal + pData[i] > 21)
                        {
                            if (money <= 0)
                            {
                                label3.Text = "GMAE OVER";
                            }
                            else
                            {
                                label3.Text = "You lose...";
                            }

                            standAccess = false;
                            startAccess = true;
                            hitAccess = false;
                            bedAccess = true;
                            bedupAccess = true;
                            beddownAccess = true;
                            label1.Text = d[0] + "," + d[1];
                            label4.Text = "" + dTotal;
                            
                        }
                    }


                    pTotal += pData[i];



                    i++;
                }
                else
                    label3.Text = "これ以上はhit不可";

                label5.Text = "" + pTotal;
            }
            else
                label3.Text = "startを押して";

        }

        private void button1_Click(object sender, EventArgs e) //stand
        {
            if (standAccess)
            {

                label1.Text = d[0] + "," + d[1];

                for (i = 2; i < 5; i++)
                {

                    if (dTotal < 18)
                    {
                        dData[i] = r.Next(1, 14);
                        d[i] = dData[i].ToString();
                        d[i] = c.isCon(d[i]);
                        dData[i] = c.tenCon(dData[i]);

                        if (dTotal + dData[i] > 21)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (d[j] == "A")
                                {
                                    if (dData[j] == 11)
                                    {
                                        if (j == 0 || j == 1)
                                        {
                                            dTotal -= 10;
                                        }
                                        dData[j] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }

                    dTotal += dData[i];
                }

                label1.Text = d[0] + "," + d[1] + "," + d[2] + "," + d[3] + "," + d[4];
                label4.Text = "" + dTotal;

                if (dTotal > 21)
                {
                    label3.Text = "You win!!";

                    if (BlackJack)
                    {
                        money += bed * 10;
                        label8.Text = "+" + bed * 10;
                    }
                    else
                    {
                        money += bed * 2;
                        label8.Text = "+" + bed * 2;
                    }

                    win++;
                    label7.Text = "money " + money;
                }
                else if (dTotal > pTotal)
                {
                    if (money <= 0)
                    {
                        label3.Text = "GMAE OVER";
                    }
                    else
                    {
                        label3.Text = "You lose...";
                    }
                    label7.Text = "money " + money;
                }
                else if (dTotal < pTotal)
                {
                    label3.Text = "You win !!";
                    if (BlackJack)
                    {
                        money += bed * 10;
                        label8.Text = "+" + bed * 10;
                    }
                    else
                    {
                        money += bed * 2;
                        label8.Text = "+" + bed * 2;
                    }

                    win++;
                    label7.Text = "money " + money;
                }
                else if (dTotal == pTotal)
                {
                    label3.Text = "drow";
                    money += bed;
                    label7.Text = "money " + money;
                }


                if (loan.loantotal == 0)
                {
                    if (money > maxmoney)
                    {
                        maxmoney = money;
                    }
                }

                rank = Rank(money);
                ranking = Ranking(maxmoney);

                startAccess = true;
                hitAccess = false;
                standAccess = false;
                bedAccess = true;
                bedupAccess = true;
                beddownAccess = true;

            }
            else
                label3.Text = "startを押して";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bedupAccess)
            {
                if (bed < money)
                {
                    bed += 100;
                    label6.Text = "bed " + bed;
                }
                else
                    label3.Text = "所持金の範囲内で賭けて";
            }
            else
            {
                label3.Text = "ゲームを完了してください";
            }
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (beddownAccess)
            {
                if (bed > 0)
                {
                    bed -= 100;
                    label6.Text = "bed " + bed;
                }
                else
                    label3.Text = "賭けれる金額は0～です";
            }
            else
            {
                label3.Text = "ゲームを完了してください";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "money " + money;
        }

       

        private void button6_Click(object sender, EventArgs e)//タイトルに戻る
        {
            Visible = false;

            title t = new title();
            t.Show();

            rank = Rank(money);
            ranking = Ranking(maxmoney);

            Properties.Settings.Default.moneyData = money;
            Properties.Settings.Default.maxMoneyData = maxmoney;
            Properties.Settings.Default.rankData = rank;
            Properties.Settings.Default.rankingData = ranking;
            Properties.Settings.Default.winData = win;
            Properties.Settings.Default.playData = play;
            Properties.Settings.Default.loantotalData = loan.loantotal;
            Properties.Settings.Default.deadlineData = loan.deadline;
            Properties.Settings.Default.interesttotalData = loan.interesttotal;

            Properties.Settings.Default.Save();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.moneyData = money;
            Properties.Settings.Default.maxMoneyData = maxmoney;
            Properties.Settings.Default.rankData = rank;
            Properties.Settings.Default.rankingData = ranking;
            Properties.Settings.Default.winData = win;
            Properties.Settings.Default.playData = play;
            Properties.Settings.Default.loantotalData = loan.loantotal;
            Properties.Settings.Default.deadlineData = loan.deadline;
            Properties.Settings.Default.interesttotalData = loan.interesttotal;

            Properties.Settings.Default.Save();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label3.Text = "bed額が未入力です";
            }
            else
            {
                if (bedAccess)
                {
                    bed = long.Parse(textBox1.Text);
                    label6.Text = "bed " + bed;
                }
                else
                {
                    label3.Text = "ゲームを完了してください";
                }
            }
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

        public string Rank(long money)
        {
            if(loan.loantotal > 0)
            {
                rank = "廃人";
            }
            else if (money > 100000000000)
            {
                rank = "ビルゲイツ";
                
            }
            else if (money > 1000000000)
            {
                rank = "億万長者";
            }
            else if (money > 100000000)
            {
                rank = "マスター";
            }
            else if (money > 1000000)
            {
                rank = "大富豪";
            }
            else if (money > 100000)
            {
                rank = "富豪";
            }
            else if (money > 10000)
            {
                rank = "平民";
            }
            else if (money > 0)
            {
                rank = "貧民";
            }

            return rank;

        }
        public string Ranking(long maxmoney)
        {
            if(maxmoney > 100000000000)
            {
                ranking = "ビルゲイツ";

            }
            else if (maxmoney > 1000000000)
            {
                ranking = "億万長者";
            }
            else if (maxmoney > 100000000)
            {
                ranking = "マスター";
            }
            else if (maxmoney > 1000000)
            {
                ranking = "大富豪";
            }
            else if (maxmoney > 100000)
            {
                ranking = "富豪";
            }
            else if (maxmoney > 10000)
            {
                ranking = "平民";
            }
            else if (maxmoney > 0)
            {
                ranking = "貧民";
            }

            return ranking;

        }
    }
    public class Convert
    {
        public string isCon(string x)
        {

            switch (x)
            {
                case "1":
                    x = "A";
                    break;
                case "11":
                    x = "J";
                    break;
                case "12":
                    x = "Q";
                    break;
                case "13":
                    x = "K";
                    break;
                default:
                    break;
            }

            return x;
        }

        public int? tenCon(int? x)
        {
            if (11 <= x && x <= 13)
            {
                x = 10;
            }
            else if(x == 1){
                x = 11;
            }

            return x;
                
        }

       

    }
}
