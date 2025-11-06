namespace Pracownik
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta Windows Forms

        private void InitializeComponent()
        {
            this.grpDane = new System.Windows.Forms.GroupBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();

            this.grpHaslo = new System.Windows.Forms.GroupBox();
            this.lblDlugosc = new System.Windows.Forms.Label();
            this.txtDlugosc = new System.Windows.Forms.TextBox();
            this.chkLitery = new System.Windows.Forms.CheckBox();
            this.chkCyfry = new System.Windows.Forms.CheckBox();
            this.chkSpecjalne = new System.Windows.Forms.CheckBox();
            this.btnGeneruj = new System.Windows.Forms.Button();

            this.btnZatwierdz = new System.Windows.Forms.Button();

            this.grpDane.SuspendLayout();
            this.grpHaslo.SuspendLayout();
            this.SuspendLayout();

            // === Grupa Dane Pracownika ===
            this.grpDane.Controls.Add(this.lblImie);
            this.grpDane.Controls.Add(this.txtImie);
            this.grpDane.Controls.Add(this.lblNazwisko);
            this.grpDane.Controls.Add(this.txtNazwisko);
            this.grpDane.Controls.Add(this.lblStanowisko);
            this.grpDane.Controls.Add(this.cmbStanowisko);
            this.grpDane.Location = new System.Drawing.Point(20, 20);
            this.grpDane.Name = "grpDane";
            this.grpDane.Size = new System.Drawing.Size(300, 150);
            this.grpDane.TabStop = false;
            this.grpDane.Text = "Dane pracownika";

            // Imię
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(10, 30);
            this.lblImie.Text = "Imię:";
            this.txtImie.Location = new System.Drawing.Point(100, 27);
            this.txtImie.Size = new System.Drawing.Size(150, 22);

            // Nazwisko
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(10, 65);
            this.lblNazwisko.Text = "Nazwisko:";
            this.txtNazwisko.Location = new System.Drawing.Point(100, 62);
            this.txtNazwisko.Size = new System.Drawing.Size(150, 22);

            // Stanowisko
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Location = new System.Drawing.Point(10, 100);
            this.lblStanowisko.Text = "Stanowisko:";
            this.cmbStanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStanowisko.Items.AddRange(new object[] {
                "Kierownik",
                "Starszy programista",
                "Młodszy programista",
                "Tester"
            });
            this.cmbStanowisko.Location = new System.Drawing.Point(100, 97);
            this.cmbStanowisko.Size = new System.Drawing.Size(150, 24);

            // === Grupa Generowanie hasła ===
            this.grpHaslo.Controls.Add(this.lblDlugosc);
            this.grpHaslo.Controls.Add(this.txtDlugosc);
            this.grpHaslo.Controls.Add(this.chkLitery);
            this.grpHaslo.Controls.Add(this.chkCyfry);
            this.grpHaslo.Controls.Add(this.chkSpecjalne);
            this.grpHaslo.Controls.Add(this.btnGeneruj);
            this.grpHaslo.Location = new System.Drawing.Point(20, 190);
            this.grpHaslo.Name = "grpHaslo";
            this.grpHaslo.Size = new System.Drawing.Size(300, 180);
            this.grpHaslo.TabStop = false;
            this.grpHaslo.Text = "Generowanie hasła";

            // Ile znaków
            this.lblDlugosc.AutoSize = true;
            this.lblDlugosc.Location = new System.Drawing.Point(10, 30);
            this.lblDlugosc.Text = "Ile znaków?";
            this.txtDlugosc.Location = new System.Drawing.Point(100, 27);
            this.txtDlugosc.Size = new System.Drawing.Size(80, 22);

            // CheckBoxy
            this.chkLitery.AutoSize = true;
            this.chkLitery.Checked = true;
            this.chkLitery.Text = "Małe i wielkie litery";
            this.chkLitery.Location = new System.Drawing.Point(10, 60);

            this.chkCyfry.AutoSize = true;
            this.chkCyfry.Text = "Cyfry";
            this.chkCyfry.Location = new System.Drawing.Point(10, 85);

            this.chkSpecjalne.AutoSize = true;
            this.chkSpecjalne.Text = "Znaki specjalne";
            this.chkSpecjalne.Location = new System.Drawing.Point(10, 110);

            // Przycisk Generuj hasło
            this.btnGeneruj.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGeneruj.ForeColor = System.Drawing.Color.White;
            this.btnGeneruj.Location = new System.Drawing.Point(10, 140);
            this.btnGeneruj.Size = new System.Drawing.Size(120, 30);
            this.btnGeneruj.Text = "Generuj hasło";
            this.btnGeneruj.UseVisualStyleBackColor = false;

            // Przycisk Zatwierdź
            this.btnZatwierdz.BackColor = System.Drawing.Color.SteelBlue;
            this.btnZatwierdz.ForeColor = System.Drawing.Color.White;
            this.btnZatwierdz.Location = new System.Drawing.Point(20, 390);
            this.btnZatwierdz.Size = new System.Drawing.Size(300, 35);
            this.btnZatwierdz.Text = "Zatwierdź";
            this.btnZatwierdz.UseVisualStyleBackColor = false;

            // === Form1 ===
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.grpDane);
            this.Controls.Add(this.grpHaslo);
            this.Controls.Add(this.btnZatwierdz);
            this.Name = "Form1";
            this.Text = "Dodaj pracownika – 12345678901";

            this.grpDane.ResumeLayout(false);
            this.grpDane.PerformLayout();
            this.grpHaslo.ResumeLayout(false);
            this.grpHaslo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDane;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.ComboBox cmbStanowisko;

        private System.Windows.Forms.GroupBox grpHaslo;
        private System.Windows.Forms.Label lblDlugosc;
        private System.Windows.Forms.TextBox txtDlugosc;
        private System.Windows.Forms.CheckBox chkLitery;
        private System.Windows.Forms.CheckBox chkCyfry;
        private System.Windows.Forms.CheckBox chkSpecjalne;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.Button btnZatwierdz;
    }
}
