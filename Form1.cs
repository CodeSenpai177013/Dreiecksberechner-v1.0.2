using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreiecksberechner_v1._0._2
{
    public partial class Berechner : Form
    {
        public Berechner()
        {
            InitializeComponent();
        }
        //Variablen zur Berechnung
        double seitea, seiteb, seitec, ergebnisa, höhea, höheb, höhec, ergebnisu, alpha, beta, gamma;
        //Variable für Fehlermeldung
        bool seiten;

        private void Berechner_Load(object sender, EventArgs e)
        {

        }

        //Berechnung des Umfanges
        private static double umfang(double a, double b, double c)
        {
            double u;
            u = a + b + c;
            return u;
        }

        //Berechnung des Flächeninhaltes
        private static double flächeninhalt(double a, double b, double c, double u)
        {
            double s = u / 2;
            a = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return a;
        }

        //Berechnung der Höhen
        private static double höhenBerechnung(double seite, double a)
        {
            double höhe = (2 / seite) * a;
            return höhe;
        }

        //Berechnung der Winkel
        private static double winkelBerechnung(double höhe, double seite)
        {
            double winkel = Math.Asin(höhe / seite) * 180 / Math.PI;
            return winkel;
        }

        //wird ausgeführt wenn auf "Berechne" gedrückt wird
        private void berechneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seiten = true;

            //Variablen deffinieren und überprüfung der Richtigkeit der Eingabe
            if (!(String.IsNullOrEmpty(txtbxsa.Text)))
            {
                seitea = Convert.ToDouble(txtbxsa.Text);
            }
            else
            {
                MessageBox.Show("Gib Seite a an.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                seiten = false;
            }

            if (!(String.IsNullOrEmpty(txtbxsb.Text)))
            {
                seiteb = Convert.ToDouble(txtbxsb.Text);
            }
            else
            {
                MessageBox.Show("Gib Seite b an.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                seiten = false;
            }

            if (!(String.IsNullOrEmpty(txtbxsc.Text)))
            {
                seitec = Convert.ToDouble(txtbxsc.Text);
            }
            else
            {
                MessageBox.Show("Gib Seite c an.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                seiten = false;
            }

            if (seiten = true)
            {
                //Überprüfung ob die Eingaben richtig sind und Berechnung
                if (seitea + seiteb < seitec | seitea + seitec < seiteb | seiteb + seitec < seitea)
                {
                    MessageBox.Show("Das ist kein Dreieck!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    seitea = 0;
                    seiteb = 0;
                    seitec = 0;
                }
                else
                {

                    //Umfang
                    ergebnisu = umfang(seitea, seiteb, seitec);

                    //Flächeninhalt
                    ergebnisa = flächeninhalt(seitea, seiteb, seitec, ergebnisu);

                    //Berechnung Höhen
                    höhea = höhenBerechnung(seitea, ergebnisa);
                    höheb = höhenBerechnung(seiteb, ergebnisa);
                    höhec = höhenBerechnung(seitec, ergebnisa);

                    //Berechnung Winkel
                    alpha = winkelBerechnung(höhec, seiteb);
                    beta = winkelBerechnung(höhec, seitea);
                    gamma = winkelBerechnung(höhea, seiteb);

                    //Ausgabe
                    txtbxu.Text = Convert.ToString(Math.Round(ergebnisu, 4));
                    txtbxa.Text = Convert.ToString(Math.Round(ergebnisa, 4));
                    txtbxha.Text = Convert.ToString(Math.Round(höhea, 4));
                    txtbxhb.Text = Convert.ToString(Math.Round(höheb, 4));
                    txtbxhc.Text = Convert.ToString(Math.Round(höhec, 4));
                    txtbxwa.Text = Convert.ToString(Math.Round(alpha, 1) + "°");
                    txtbxwb.Text = Convert.ToString(Math.Round(beta, 1) + "°");
                    txtbxwg.Text = Convert.ToString(Math.Round(gamma, 1) + "°");
                }
            }
        }

        private void endeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
