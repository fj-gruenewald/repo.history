using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiWF5___Fade_In_Fade_Out
{
    public partial class fade : Form
    {
        Boolean flag;
        public fade()
        {
            InitializeComponent();

        }

        private void fade_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            flag = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 1.0)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if (this.Opacity >= 0.0)
                {
                    this.Opacity -= 0.025;
                }
                else
                {
                    timer1.Stop();
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            flag = false;
        }
    }
}
