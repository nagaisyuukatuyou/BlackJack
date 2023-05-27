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
    public partial class financing : Form
    {
        public financing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;

            loan l = new loan();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;

            title t = new title();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            payback p = new payback();
            p.Show();
        }
    }
}
