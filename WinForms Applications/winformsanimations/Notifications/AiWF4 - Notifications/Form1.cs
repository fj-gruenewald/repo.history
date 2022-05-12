using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace AiWF4___Notifications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_notification_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();

            popup.TitleText = "D3NCE von Youtube";
            popup.ContentText = "Ich bin schneller weg als du denkst";
            popup.Popup();
        }
    }
}
