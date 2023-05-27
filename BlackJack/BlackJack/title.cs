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
    public partial class title : Form
    {
        
        public title()
        {
            InitializeComponent();
        }

        private void title_Load(object sender, EventArgs e)
        {
            if (Form1.play == 0)
            {
                Form1.wp = 0;
            }
            else {
                Form1.wp = Form1.win / Form1.play * 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)//ゲーム開始
        {
            Visible = false;

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;

            Data data = new Data();
            data.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;

            financing f = new financing();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visible = false;

            command c = new command();
            c.Show();
        }
    }
}
