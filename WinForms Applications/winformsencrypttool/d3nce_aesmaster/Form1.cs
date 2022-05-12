using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using verschlüssel;

namespace d3nce_aesmaster
{
    public partial class main : MaterialForm
    {
        AES obj_aes = new AES();

        public main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            com_art.SelectedItem = "AES256";
        }

        #region verschlusseln
        private void bttn_verschlussel_Click(object sender, EventArgs e)
        {
            //Test ob text zum verschlüsseln vorhanden
            if (txt_unv.Text == "")
            {
                MessageBox.Show("Bitte gebe einen Text zum verschlüsseln ein!");
            }
            else
            {
                #region AES256
                //verschlüsselung AES
                if (com_art.SelectedItem == "AES256")
                {
                    try
                    {
                        txt_ver.Text = obj_aes.encrypt(txt_unv.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                #region AES128
                //verschlüsselung AES128
                if (com_art.SelectedItem == "AES128")
                {
                    

                }
                #endregion

                #region leetspeak
                //verschlüsselung leetspeak
                if (com_art.SelectedItem == "Leetspeak")
                {
                    string inputText = txt_unv.Text;
                    string outputText = leetcrypt.Translate(inputText, 30);
                    txt_ver.Text = outputText;
                }
                #endregion

                #region caesar chiffre
                //verschlüsselung caesar chiffre
                if (com_art.SelectedItem == "Caesar Chiffre")
                {
                    string inputText = txt_unv.Text;
                    string outputText = string.Empty;
                    int stellen = 3;

                    foreach (char c in inputText )
                    {
                        char x = (char) (c + stellen);
                        outputText += x.ToString();
                    }

                    txt_ver.Text = outputText;
                }
                #endregion
            }
        }
        #endregion

        #region entschlusseln
        private void bttn_entschlussel_Click(object sender, EventArgs e)
        {
            //Test ob text zum entschlüsseln vorhanden
            if (txt_ver.Text == "")
            {
                MessageBox.Show("Bitte gebe einen Text zum entschlüsseln ein!");
            }
            else
            {
                #region AES256
                //verschlüsselung AES
                if (com_art.SelectedItem == "AES256")
                {
                    try
                    {
                        txt_unv.Text = obj_aes.decrypt(txt_ver.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                #region AES128
                //verschlüsselung AES128
                if (com_art.SelectedItem == "AES128")
                {


                }
                #endregion

                #region caesar chiffre
                //entschlüsseln caesar chiffre
                if (com_art.SelectedItem == "Caesar Chiffre")
                {
                    string inputText = txt_ver.Text;
                    string outputText = string.Empty;
                    int stellen = 3;

                    foreach (char c in inputText )
                    {
                        char x = (char) (c - stellen);
                        outputText += x.ToString();
                    }

                    txt_unv.Text = outputText;
                }

                #endregion
            }
        }
        #endregion

        #region clear
        private void bttn_clear_Click(object sender, EventArgs e)
        {
            txt_unv.Text = "";
            txt_ver.Text = "";
        }
        #endregion

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
