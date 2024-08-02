namespace InShelf
{
    partial class frmLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLista));
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblZaloguj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWrocDoProfilu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToOrderColumns = true;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dgvLista.EnableHeadersVisualStyles = false;
            this.dgvLista.Location = new System.Drawing.Point(12, 102);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowTemplate.Height = 25;
            this.dgvLista.Size = new System.Drawing.Size(860, 402);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvLista_CellBeginEdit);
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            this.dgvLista.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLista_RowPostPaint);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 20F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // lblZaloguj
            // 
            this.lblZaloguj.AutoSize = true;
            this.lblZaloguj.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZaloguj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZaloguj.Location = new System.Drawing.Point(14, 28);
            this.lblZaloguj.Name = "lblZaloguj";
            this.lblZaloguj.Size = new System.Drawing.Size(338, 33);
            this.lblZaloguj.TabIndex = 1;
            this.lblZaloguj.Text = "Książki na twojej półce:";
            this.lblZaloguj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.txtSzukaj);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.lblZaloguj);
            this.panel1.Location = new System.Drawing.Point(-2, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 103);
            this.panel1.TabIndex = 12;
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(14, 70);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.PlaceholderText = "Wyszukiwarka";
            this.txtSzukaj.Size = new System.Drawing.Size(172, 23);
            this.txtSzukaj.TabIndex = 1;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(734, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(140, 30);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj książke +";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWrocDoProfilu
            // 
            this.btnWrocDoProfilu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(62)))));
            this.btnWrocDoProfilu.FlatAppearance.BorderSize = 0;
            this.btnWrocDoProfilu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrocDoProfilu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWrocDoProfilu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWrocDoProfilu.Location = new System.Drawing.Point(732, 519);
            this.btnWrocDoProfilu.Name = "btnWrocDoProfilu";
            this.btnWrocDoProfilu.Size = new System.Drawing.Size(140, 30);
            this.btnWrocDoProfilu.TabIndex = 3;
            this.btnWrocDoProfilu.Text = "Wróć";
            this.btnWrocDoProfilu.UseVisualStyleBackColor = false;
            this.btnWrocDoProfilu.Click += new System.EventHandler(this.btnWrocDoProfilu_Click);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnWrocDoProfilu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InShelf";
            this.Load += new System.EventHandler(this.frmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvLista;
        private Label lblZaloguj;
        private Panel panel1;
        private Button btnWrocDoProfilu;
        private Button btnDodaj;
        private DataGridViewTextBoxColumn id;
        private TextBox txtSzukaj;
    }
}