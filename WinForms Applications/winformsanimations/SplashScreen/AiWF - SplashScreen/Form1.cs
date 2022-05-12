using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiWF___SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hintergrund();
        }

        private void hintergrund()
        {
            try
            {

                base.Hide();

                Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.CopyFromScreen(base.Location.X, base.Location.Y, 0, 0, base.Size, CopyPixelOperation.SourceCopy);
                bitmap.Save("hint.bin", ImageFormat.Png);

                this.BackgroundImage = bitmap;
                base.Show();

            }
            catch (Exception)
            {

            }
        }
    }
}
