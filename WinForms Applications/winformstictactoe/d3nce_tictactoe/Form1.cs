using System;
using System.Windows.Forms;

namespace d3nce_tictactoe
{
    public partial class Form1 : Form
    {
        //Variablen deklarieren
        public int spieler = 2;
        public int zug = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        //Gleichstand? Unentschieden?
        bool IsDraw()
        {
            if ((zug == 9) && (IsWinner() == false))
                return true;
            else
                return false;
        }

        bool IsWinner()
        {
            //horizontaler test auf 3er Reihe
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            //vertikaler test auf 3er Reihe
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            //diagonaler test auf 3er Reihe
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //variablen für Spielstart setzten
            lbl_x.Text = "X: " + s1;
            lbl_y.Text = "Y: " + s1;
            lbl_draw.Text = "Draw: " + s1;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            //Spiellogik
            Button button = (Button) sender;

            if (button.Text == "")
            {
                // Wer ist an der Reihe
                if (spieler % 2 == 0)
                {
                    button.Text = "X";
                    spieler++;
                    zug++;
                }
                else
                {
                    button.Text = "O";
                    spieler++;
                    zug++;
                }

                //Wenn Unentschieden
                if (IsDraw() == true)
                {
                    MessageBox.Show("Unentschieden");
                    sd++;
                    NeuesSpiel();
                }

                //Wenn Sieger vorhanden
                if (IsWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X hat gewonnen!");
                        s1++;
                        NeuesSpiel();
                    }
                    else
                    {
                        MessageBox.Show("Y hat gewonnen!");
                        s2++;
                        NeuesSpiel();
                    }
                }
            }
        }

        //Neues Spiel beginnen
        private void bttn_ns_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        //Neues Spiel, Spielfeld leeren
        public void NeuesSpiel()
        {
            spieler = 2;
            zug = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";

            lbl_x.Text = "X: " + s1;
            lbl_y.Text = "Y: " + s2;
            lbl_draw.Text = "Draw: " + sd;
        }

        //Spiel beenden
        private void bttn_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Spiel zurücksetzten
        private void bttn_reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NeuesSpiel();
        }
    }
}
