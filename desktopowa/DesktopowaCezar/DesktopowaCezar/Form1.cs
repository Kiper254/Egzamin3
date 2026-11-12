using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopowaCezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            int klucz;

            if (!int.TryParse(textBoxKlucz.Text, out klucz))
            {
                klucz = 0;
            }

            textBoxZaszyfrowany.Text = SzyfrujCezarem(
                textBoxTekst.Text,
                klucz
            );
        }

        private string SzyfrujCezarem(string tekstJawny, int klucz)
        {
            string tekstZaszyfrowany = "";
            int przesuniecie = klucz % 26;

            for (int i = 0; i < tekstJawny.Length; i++)
            {
                char znak = tekstJawny[i];

                if (znak >= 'a' && znak <= 'z')
                {
                    int numerZnaku = znak - 'a';
                    int nowyNumerZnaku = (numerZnaku + przesuniecie) % 26;

                    if (nowyNumerZnaku < 0)
                    {
                        nowyNumerZnaku += 26;
                    }

                    tekstZaszyfrowany += (char)('a' + nowyNumerZnaku);
                }
                else
                {
                    tekstZaszyfrowany += znak;
                }
            }

            return tekstZaszyfrowany;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog oknoZapisu = new SaveFileDialog())
            {
                oknoZapisu.Title = "Zapisywanie jako";
                oknoZapisu.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                oknoZapisu.DefaultExt = "txt";
                oknoZapisu.AddExtension = true;

                if (oknoZapisu.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(
                        oknoZapisu.FileName,
                        textBoxZaszyfrowany.Text
                    );
                }
            }
        }
    }
}