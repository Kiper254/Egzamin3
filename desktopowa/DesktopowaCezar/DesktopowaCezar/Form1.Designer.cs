namespace DesktopowaCezar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelKlucz;
        private System.Windows.Forms.Label labelTekst;
        private System.Windows.Forms.Label labelZaszyfrowany;
        private System.Windows.Forms.TextBox textBoxKlucz;
        private System.Windows.Forms.TextBox textBoxTekst;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany;
        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Button buttonZapisz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelKlucz = new System.Windows.Forms.Label();
            this.labelTekst = new System.Windows.Forms.Label();
            this.labelZaszyfrowany = new System.Windows.Forms.Label();
            this.textBoxKlucz = new System.Windows.Forms.TextBox();
            this.textBoxTekst = new System.Windows.Forms.TextBox();
            this.textBoxZaszyfrowany = new System.Windows.Forms.TextBox();
            this.buttonSzyfruj = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelKlucz.AutoSize = true;
            this.labelKlucz.ForeColor = System.Drawing.Color.FromArgb(250, 235, 215);
            this.labelKlucz.Location = new System.Drawing.Point(25, 25);
            this.labelKlucz.Text = "Podaj wartość klucza";

            this.labelTekst.AutoSize = true;
            this.labelTekst.ForeColor = System.Drawing.Color.FromArgb(250, 235, 215);
            this.labelTekst.Location = new System.Drawing.Point(25, 100);
            this.labelTekst.Text = "Podaj tekst";

            this.labelZaszyfrowany.AutoSize = true;
            this.labelZaszyfrowany.ForeColor = System.Drawing.Color.FromArgb(250, 235, 215);
            this.labelZaszyfrowany.Location = new System.Drawing.Point(390, 25);
            this.labelZaszyfrowany.Text = "Tekst zaszyfrowany";

            this.textBoxKlucz.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.textBoxKlucz.Location = new System.Drawing.Point(120, 60);
            this.textBoxKlucz.Size = new System.Drawing.Size(55, 23);

            this.textBoxTekst.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.textBoxTekst.Location = new System.Drawing.Point(30, 140);
            this.textBoxTekst.Multiline = true;
            this.textBoxTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTekst.Size = new System.Drawing.Size(270, 150);

            this.textBoxZaszyfrowany.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.textBoxZaszyfrowany.ForeColor = System.Drawing.Color.FromArgb(0, 15, 143);
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(400, 60);
            this.textBoxZaszyfrowany.Multiline = true;
            this.textBoxZaszyfrowany.ReadOnly = true;
            this.textBoxZaszyfrowany.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(205, 185);

            this.buttonSzyfruj.BackColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.buttonSzyfruj.Location = new System.Drawing.Point(330, 150);
            this.buttonSzyfruj.Size = new System.Drawing.Size(65, 30);
            this.buttonSzyfruj.Text = "Zaszyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = false;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);

            this.buttonZapisz.BackColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.buttonZapisz.Location = new System.Drawing.Point(435, 270);
            this.buttonZapisz.Size = new System.Drawing.Size(135, 30);
            this.buttonZapisz.Text = "Zapisz szyfr w pliku";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(95, 158, 160);
            this.ClientSize = new System.Drawing.Size(640, 330);
            this.Controls.Add(this.labelKlucz);
            this.Controls.Add(this.labelTekst);
            this.Controls.Add(this.labelZaszyfrowany);
            this.Controls.Add(this.textBoxKlucz);
            this.Controls.Add(this.textBoxTekst);
            this.Controls.Add(this.textBoxZaszyfrowany);
            this.Controls.Add(this.buttonSzyfruj);
            this.Controls.Add(this.buttonZapisz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szyfrowanie. Wykonał: numer zdającego";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}