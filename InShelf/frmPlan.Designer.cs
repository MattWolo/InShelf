namespace InShelf
{
    partial class frmPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlan));
            btnZamknij = new Button();
            panel1 = new Panel();
            lblZaloguj = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            numStrony1 = new NumericUpDown();
            numDni1 = new NumericUpDown();
            lblWynik1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            numStrony2 = new NumericUpDown();
            numDni2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            lblWynik2 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStrony1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDni1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStrony2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDni2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnZamknij
            // 
            btnZamknij.BackColor = Color.FromArgb(224, 159, 62);
            btnZamknij.FlatAppearance.BorderSize = 0;
            btnZamknij.FlatStyle = FlatStyle.Flat;
            btnZamknij.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnZamknij.ForeColor = SystemColors.ButtonHighlight;
            btnZamknij.Location = new Point(732, 363);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(140, 30);
            btnZamknij.TabIndex = 21;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = false;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 159, 62);
            panel1.Controls.Add(lblZaloguj);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 81);
            panel1.TabIndex = 22;
            // 
            // lblZaloguj
            // 
            lblZaloguj.AutoSize = true;
            lblZaloguj.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblZaloguj.ForeColor = SystemColors.ButtonHighlight;
            lblZaloguj.Location = new Point(13, 25);
            lblZaloguj.Name = "lblZaloguj";
            lblZaloguj.Size = new Size(155, 33);
            lblZaloguj.TabIndex = 1;
            lblZaloguj.Text = "Kalkulator";
            lblZaloguj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(267, 58);
            label1.TabIndex = 23;
            label1.Text = "Ile masz dni na \r\nprzeczytanie książki?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(268, 29);
            label2.TabIndex = 24;
            label2.Text = "Ile stron ma książka?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 159, 62);
            panel2.Controls.Add(numStrony1);
            panel2.Controls.Add(numDni1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 150);
            panel2.TabIndex = 25;
            // 
            // numStrony1
            // 
            numStrony1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numStrony1.Location = new Point(341, 85);
            numStrony1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStrony1.Name = "numStrony1";
            numStrony1.Size = new Size(49, 34);
            numStrony1.TabIndex = 32;
            numStrony1.ValueChanged += numStrony1_ValueChanged;
            // 
            // numDni1
            // 
            numDni1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numDni1.Location = new Point(341, 37);
            numDni1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDni1.Name = "numDni1";
            numDni1.Size = new Size(49, 34);
            numDni1.TabIndex = 31;
            numDni1.ValueChanged += numDni1_ValueChanged;
            // 
            // lblWynik1
            // 
            lblWynik1.AutoSize = true;
            lblWynik1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWynik1.ForeColor = SystemColors.ButtonHighlight;
            lblWynik1.Location = new Point(138, 50);
            lblWynik1.Name = "lblWynik1";
            lblWynik1.Size = new Size(140, 29);
            lblWynik1.TabIndex = 36;
            lblWynik1.Text = "- str/dzień";
            lblWynik1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 12);
            label3.Name = "label3";
            label3.Size = new Size(321, 29);
            label3.TabIndex = 33;
            label3.Text = "By zdążyć musisz czytać: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 159, 62);
            panel3.Controls.Add(numStrony2);
            panel3.Controls.Add(numDni2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(452, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 150);
            panel3.TabIndex = 26;
            // 
            // numStrony2
            // 
            numStrony2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numStrony2.Location = new Point(346, 85);
            numStrony2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStrony2.Name = "numStrony2";
            numStrony2.Size = new Size(49, 34);
            numStrony2.TabIndex = 32;
            numStrony2.ValueChanged += numStrony2_ValueChanged;
            // 
            // numDni2
            // 
            numDni2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numDni2.Location = new Point(346, 37);
            numDni2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDni2.Name = "numDni2";
            numDni2.Size = new Size(49, 34);
            numDni2.TabIndex = 31;
            numDni2.ValueChanged += numDni2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 90);
            label5.Name = "label5";
            label5.Size = new Size(268, 29);
            label5.TabIndex = 23;
            label5.Text = "Ile stron ma książka?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(22, 23);
            label6.Name = "label6";
            label6.Size = new Size(298, 58);
            label6.TabIndex = 24;
            label6.Text = "Ile stron \r\nchcesz czytać dziennie?";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWynik2
            // 
            lblWynik2.AutoSize = true;
            lblWynik2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWynik2.ForeColor = SystemColors.ButtonHighlight;
            lblWynik2.Location = new Point(150, 50);
            lblWynik2.Name = "lblWynik2";
            lblWynik2.Size = new Size(67, 29);
            lblWynik2.TabIndex = 34;
            lblWynik2.Text = "- dni";
            lblWynik2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(60, 12);
            label4.Name = "label4";
            label4.Size = new Size(294, 29);
            label4.TabIndex = 33;
            label4.Text = "Przeczytasz książke w: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 159, 62);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblWynik2);
            panel4.Location = new Point(452, 261);
            panel4.Name = "panel4";
            panel4.Size = new Size(420, 87);
            panel4.TabIndex = 38;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 159, 62);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblWynik1);
            panel5.Location = new Point(16, 261);
            panel5.Name = "panel5";
            panel5.Size = new Size(420, 87);
            panel5.TabIndex = 39;
            // 
            // frmPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 243, 176);
            ClientSize = new Size(891, 408);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnZamknij);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPlan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InShelf";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStrony1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDni1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStrony2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDni2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnZamknij;
        private Panel panel1;
        private Label lblZaloguj;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private NumericUpDown numStrony1;
        private NumericUpDown numDni1;
        private Panel panel3;
        private Label label4;
        private NumericUpDown numStrony2;
        private NumericUpDown numDni2;
        private Label label5;
        private Label label6;
        private Label lblWynik1;
        private Label lblWynik2;
        private Panel panel4;
        private Panel panel5;
    }
}