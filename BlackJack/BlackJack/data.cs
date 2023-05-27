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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            label5.Text = "" + Form1.money;
            label6.Text = Form1.wp + "%";
            label7.Text = Form1.rank;
            label8.Text = "" + Form1.ranking;
            label11.Text = Form1.play + "回";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;

            title t = new title();
            t.Show();
        }
    }
}
