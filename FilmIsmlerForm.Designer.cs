namespace Ders26
{
    partial class FilmIsmlerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBoxFilmTur = new System.Windows.Forms.ComboBox();
            this.txtFilmUcreti = new System.Windows.Forms.TextBox();
            this.txtFilmSuresi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listViewFilmler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cBoxFilmTur);
            this.panel1.Controls.Add(this.txtFilmUcreti);
            this.panel1.Controls.Add(this.txtFilmSuresi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFilmAdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 240);
            this.panel1.TabIndex = 1;
            // 
            // cBoxFilmTur
            // 
            this.cBoxFilmTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFilmTur.FormattingEnabled = true;
            this.cBoxFilmTur.Items.AddRange(new object[] {
            "Aile",
            "Aksiyon",
            "Aşk",
            "Bilim Kurgu",
            "Dram",
            "Komedi",
            "Korku",
            "Romantik",
            "Suç",
            "Savaş"});
            this.cBoxFilmTur.Location = new System.Drawing.Point(120, 84);
            this.cBoxFilmTur.Name = "cBoxFilmTur";
            this.cBoxFilmTur.Size = new System.Drawing.Size(202, 28);
            this.cBoxFilmTur.TabIndex = 2;
            // 
            // txtFilmUcreti
            // 
            this.txtFilmUcreti.Location = new System.Drawing.Point(120, 181);
            this.txtFilmUcreti.Name = "txtFilmUcreti";
            this.txtFilmUcreti.Size = new System.Drawing.Size(110, 26);
            this.txtFilmUcreti.TabIndex = 1;
            // 
            // txtFilmSuresi
            // 
            this.txtFilmSuresi.Location = new System.Drawing.Point(120, 135);
            this.txtFilmSuresi.Name = "txtFilmSuresi";
            this.txtFilmSuresi.Size = new System.Drawing.Size(110, 26);
            this.txtFilmSuresi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Film Ücreti : ";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(120, 31);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(202, 26);
            this.txtFilmAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Süresi (dk) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Türü : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Location = new System.Drawing.Point(361, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 240);
            this.panel2.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuncelle.Location = new System.Drawing.Point(12, 157);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(202, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Salmon;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(12, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(202, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEkle.Location = new System.Drawing.Point(12, 43);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(202, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listViewFilmler
            // 
            this.listViewFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFilmler.FullRowSelect = true;
            this.listViewFilmler.GridLines = true;
            this.listViewFilmler.HideSelection = false;
            this.listViewFilmler.Location = new System.Drawing.Point(12, 12);
            this.listViewFilmler.Name = "listViewFilmler";
            this.listViewFilmler.Size = new System.Drawing.Size(575, 213);
            this.listViewFilmler.TabIndex = 2;
            this.listViewFilmler.UseCompatibleStateImageBehavior = false;
            this.listViewFilmler.View = System.Windows.Forms.View.Details;
            this.listViewFilmler.SelectedIndexChanged += new System.EventHandler(this.listViewFilmler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Türü";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süresi";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ücreti";
            // 
            // FilmIsmlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(599, 486);
            this.Controls.Add(this.listViewFilmler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FilmIsmlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilmIsmlerForm_FormClosed);
            this.Load += new System.EventHandler(this.FilmIsmlerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cBoxFilmTur;
        private System.Windows.Forms.TextBox txtFilmUcreti;
        private System.Windows.Forms.TextBox txtFilmSuresi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView listViewFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}