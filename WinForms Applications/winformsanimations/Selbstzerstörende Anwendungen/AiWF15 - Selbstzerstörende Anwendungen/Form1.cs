using System;
using System.Windows.Forms;

namespace AiWF15___Selbstzerstörende_Anwendungen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("18/01/2018");

            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Die Anwendung ist abgelaufen.");
                Application.Exit();
            }
            else
            {
                lbl_daten.Show();
            }
        }
    }
}
