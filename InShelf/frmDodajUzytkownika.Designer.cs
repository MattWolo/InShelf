namespace InShelf
{
    partial class frmDodajUzytkownika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajUzytkownika));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZaloguj = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNewUserLogin = new System.Windows.Forms.TextBox();
            this.txtNewUserHaslo2nd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewUserHaslo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWrocDoZaloguj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.lblZaloguj);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 96);
            this.panel1.TabIndex = 11;
            // 
            // lblZaloguj
            // 
            this.lblZaloguj.AutoSize = true;
            this.lblZaloguj.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZaloguj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZaloguj.Location = new System.Drawing.Point(27, 15);
            this.lblZaloguj.Name = "lblZaloguj";
            this.lblZaloguj.Size = new System.Drawing.Size(187, 66);
            this.lblZaloguj.TabIndex = 0;
            this.lblZaloguj.Text = "Dodaj \r\nużytkownika";
            this.lblZaloguj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.txtNewUserLogin);
            this.panel2.Controls.Add(this.txtNewUserHaslo2nd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNewUserHaslo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(34, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 158);
            this.panel2.TabIndex = 12;
            // 
            // txtNewUserLogin
            // 
            this.txtNewUserLogin.Location = new System.Drawing.Point(24, 35);
            this.txtNewUserLogin.Name = "txtNewUserLogin";
            this.txtNewUserLogin.PlaceholderText = "Wpisz login...";
            this.txtNewUserLogin.Size = new System.Drawing.Size(121, 23);
            this.txtNewUserLogin.TabIndex = 1;
            // 
            // txtNewUserHaslo2nd
            // 
            this.txtNewUserHaslo2nd.Location = new System.Drawing.Point(24, 123);
            this.txtNewUserHaslo2nd.Name = "txtNewUserHaslo2nd";
            this.txtNewUserHaslo2nd.PasswordChar = '*';
            this.txtNewUserHaslo2nd.PlaceholderText = "Powtórz hasło...";
            this.txtNewUserHaslo2nd.Size = new System.Drawing.Size(121, 23);
            this.txtNewUserHaslo2nd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Powtórz hasło:";
            // 
            // txtNewUserHaslo
            // 
            this.txtNewUserHaslo.Location = new System.Drawing.Point(24, 79);
            this.txtNewUserHaslo.Name = "txtNewUserHaslo";
            this.txtNewUserHaslo.PasswordChar = '*';
            this.txtNewUserHaslo.PlaceholderText = "Wpisz hasło...";
            this.txtNewUserHaslo.Size = new System.Drawing.Size(121, 23);
            this.txtNewUserHaslo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(34, 288);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(169, 30);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj nowy profil";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWrocDoZaloguj
            // 
            this.btnWrocDoZaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.btnWrocDoZaloguj.FlatAppearance.BorderSize = 0;
            this.btnWrocDoZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrocDoZaloguj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWrocDoZaloguj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWrocDoZaloguj.Location = new System.Drawing.Point(34, 324);
            this.btnWrocDoZaloguj.Name = "btnWrocDoZaloguj";
            this.btnWrocDoZaloguj.Size = new System.Drawing.Size(169, 30);
            this.btnWrocDoZaloguj.TabIndex = 5;
            this.btnWrocDoZaloguj.Text = "Wróć";
            this.btnWrocDoZaloguj.UseVisualStyleBackColor = false;
            this.btnWrocDoZaloguj.Click += new System.EventHandler(this.btnWrocDoZaloguj_Click);
            // 
            // frmDodajUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(240, 375);
            this.Controls.Add(this.btnWrocDoZaloguj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDodajUzytkownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InShelf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblZaloguj;
        private Panel panel2;
        private TextBox txtNewUserHaslo;
        private Label label4;
        private Label label2;
        private Button btnDodaj;
        private TextBox txtNewUserHaslo2nd;
        private Label label1;
        private Button btnWrocDoZaloguj;
        private TextBox txtNewUserLogin;
    }
}