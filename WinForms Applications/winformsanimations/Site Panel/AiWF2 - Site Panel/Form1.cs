using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiWF2___Site_Panel
{
    public partial class Form1 : Form
    {
        int panelbreite;
        bool zeigen;

        public Form1()
        {
            InitializeComponent();
            panelbreite = pnl_dropmenu.Width;
            zeigen = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttn_open_Click(object sender, EventArgs e)
        {
            if (zeigen)
            {
                bttn_open.Text = "-->";
            }
            else
            {
                bttn_open.Text = "<--";
            }

            time_form.Start();
        }

        private void time_form_Tick(object sender, EventArgs e)
        {
            if (zeigen)
            {
                pnl_dropmenu.Width = pnl_dropmenu.Width + 20;
                if (pnl_dropmenu.Width >= panelbreite)
                {
                    time_form.Stop();
                    zeigen = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_dropmenu.Width = pnl_dropmenu.Width - 20;
                if (pnl_dropmenu.Width <= 0)
                {
                    time_form.Stop();
                    zeigen = true;
                    this.Refresh();
                }
            }
        }
    }
}
