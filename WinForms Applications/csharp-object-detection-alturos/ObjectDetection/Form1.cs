using Alturos.Yolo;
using Alturos.Yolo.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ObjectDetection
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bttn_load_Click(object sender, EventArgs e)
        {
            // FileDialog öffnen um Bild auszuwählen (dabei werden formate beachtet ist aber eigentlich egal)
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.jpeg" })
            {
                // wenn der Dialog ein akzeptiertes Bild erkannt hat wird dies in der Picturebox angezeigt
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    picbox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void bttn_analyze_Click(object sender, EventArgs e)
        {
            // vorgefertigter code aus der readme des nuget paketes
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper(config))
            {
                // umwandeln in einen 2bit stream 
                using (MemoryStream ms = new MemoryStream())
                {
                    picbox.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                    var items = yoloWrapper.Detect(ms.ToArray()).ToList();
                    yoloItemBindingSource.DataSource = items;
                    AddDetailsToPicturebox(picbox, items);
                }

                //items[0].Type -> "Person, Car, ..."
                //items[0].Confidence -> 0.0 (low) -> 1.0 (high)
                //items[0].X -> bounding box
                //items[0].Y -> bounding box
                //items[0].Width -> bounding box
                //items[0].Height -> bounding box
            }
        }

        //Methode zum rendern des dreiecks
        void AddDetailsToPicturebox(PictureBox pictureBoxToRender, List<YoloItem> items)
        {
            //grafik aus dem bild erstellen
            var img = pictureBoxToRender.Image;

            //font zum schreiben des textes der objekte brush für das eigentliche schreiben
            var font = new Font("Arial", 20, FontStyle.Bold);
            var brush = new SolidBrush(Color.LightGreen);

            var graphics = Graphics.FromImage(img);
            foreach(var item in items)
            {
                //für die x und y werte der ekannten objekte variablen anlegen
                var x = item.X;
                var y = item.Y;
                var width = item.Width;
                var height = item.Height;

                //ein rectangle zeichnen und einen pen zum zeichnen deklarieren
                var rect = new Rectangle(x, y, width, height);
                var pen = new Pen(Color.LightGreen, 6);

                //punkt für das schreiben des textes
                var point = new Point(x, y);

                //das eigentliche zeichnen des quadrates
                graphics.DrawRectangle(pen, rect);

                //schreibes des textes in die rectangles
                graphics.DrawString(item.Type, font, brush, point);
            }

            //abspeichern des quadrates in einer bitmap zum anwenden auf die picturebox
            pictureBoxToRender.Image = img;
        }
    }
}
