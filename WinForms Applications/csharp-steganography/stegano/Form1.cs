using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace stegano
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            //initialisieren des Form Design (MaterialSkin NuGet)
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttn_open_Click(object sender, EventArgs e)
        {
            //File Dialog zum Bild auswählen
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\";

            //war der Dialog erfolgreich?
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
            }
        }

        private void bttn_crypt_Click(object sender, EventArgs e)
        {
            //Bitmap erstellen
            Bitmap img = new Bitmap(textBoxFilePath.Text);

            //breite des Bildes durchlaufen
            for (int i = 0; i < img.Width; i++)
            {

                //höhe des Bildes durchlaufen
                for (int j = 0; j < img.Height; j++)
                {
                    //Farbwerte abrufen
                    Color pixel = img.GetPixel(i, j);

                    //pixelwerte verändern
                    if (i < 1 && j < textBoxMessage.TextLength)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(textBoxMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter : " + letter + " value : " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }

                    //Farbwerte verändern
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxMessage.TextLength));
                    }

                }
            }

            //file abspeichern
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png) | *.png;";
            saveFile.InitialDirectory = @"C:\Users\Desktop";

            //abspeichern OK?
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;

                //Bild wird im gleichn ordner gespeichert
                img.Save(textBoxFilePath.Text);
            }
        }

        private void bttn_decrypt_Click(object sender, EventArgs e)
        {
            //Bitmap erstellen
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            string message = "";

            //Position finden
            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            //Breite des Bildes durchlaufen
            for (int i = 0; i < img.Width; i++)
            {
                //Höhe des Bildes durchlaufen
                for (int j = 0; j < img.Height; j++)
                {
                    //Farbwerte abrufen
                    Color pixel = img.GetPixel(i, j);

                    //Pixelwerte zu ASCII 
                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }

            //Nachricht wiedergeben
            textBoxMessage.Text = message;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //Textbox leeren
            textBoxMessage.Text = "";
        }
    }
}
