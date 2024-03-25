using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SESys
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            courses cs = new courses();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentreg str = new studentreg();
            str.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stclass stclass = new stclass();
            stclass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentinfoshow studentinfoshow = new studentinfoshow();
            studentinfoshow.Show();
        }
    }
}
