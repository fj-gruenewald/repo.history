using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiWF3___Objekte_Bewegen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            time_bewegung.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void time_bewegung_Tick(object sender, EventArgs e)
        {
            pnl_objekt.Location = new Point(pnl_objekt.Location.X + 3, pnl_objekt.Location.Y + 1);

            bttn_fang.Location = new Point(bttn_fang.Location.X - 3, bttn_fang.Location.Y + 1);


        }
    }
}
