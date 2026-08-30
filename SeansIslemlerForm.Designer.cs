namespace Ders26
{
    partial class SeansIslemlerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxSalonlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSeanslar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSeansSil = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxFilmler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxSalonlar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon Seçimi";
            // 
            // cBoxSalonlar
            // 
            this.cBoxSalonlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSalonlar.FormattingEnabled = true;
            this.cBoxSalonlar.Location = new System.Drawing.Point(27, 69);
            this.cBoxSalonlar.Name = "cBoxSalonlar";
            this.cBoxSalonlar.Size = new System.Drawing.Size(194, 28);
            this.cBoxSalonlar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salonlar ";
            // 
            // listViewSeanslar
            // 
            this.listViewSeanslar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewSeanslar.FullRowSelect = true;
            this.listViewSeanslar.GridLines = true;
            this.listViewSeanslar.HideSelection = false;
            this.listViewSeanslar.Location = new System.Drawing.Point(12, 12);
            this.listViewSeanslar.MultiSelect = false;
            this.listViewSeanslar.Name = "listViewSeanslar";
            this.listViewSeanslar.Size = new System.Drawing.Size(800, 213);
            this.listViewSeanslar.TabIndex = 3;
            this.listViewSeanslar.UseCompatibleStateImageBehavior = false;
            this.listViewSeanslar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salon Adı";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Seans Başlangıcı";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Seans Bitişi";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Seans Uzunluk";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Film Adı";
            this.columnHeader5.Width = 158;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Film Süresi";
            this.columnHeader6.Width = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.btnSeansSil);
            this.panel2.Controls.Add(this.btnSeansEkle);
            this.panel2.Location = new System.Drawing.Point(12, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 78);
            this.panel2.TabIndex = 4;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.Control;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKapat.Location = new System.Drawing.Point(617, 19);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(152, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSeansSil
            // 
            this.btnSeansSil.BackColor = System.Drawing.Color.Salmon;
            this.btnSeansSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSeansSil.Location = new System.Drawing.Point(170, 19);
            this.btnSeansSil.Name = "btnSeansSil";
            this.btnSeansSil.Size = new System.Drawing.Size(152, 40);
            this.btnSeansSil.TabIndex = 2;
            this.btnSeansSil.Text = "Sil";
            this.btnSeansSil.UseVisualStyleBackColor = false;
            this.btnSeansSil.Click += new System.EventHandler(this.btnSeansSil_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSeansEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSeansEkle.Location = new System.Drawing.Point(12, 19);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(152, 40);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "Ekle";
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxSaatler);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(282, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seans Saat Seçimi";
            // 
            // cBoxSaatler
            // 
            this.cBoxSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSaatler.FormattingEnabled = true;
            this.cBoxSaatler.Location = new System.Drawing.Point(27, 69);
            this.cBoxSaatler.Name = "cBoxSaatler";
            this.cBoxSaatler.Size = new System.Drawing.Size(137, 28);
            this.cBoxSaatler.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saatler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBoxFilmler);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(473, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 145);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Seçimi";
            // 
            // cBoxFilmler
            // 
            this.cBoxFilmler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFilmler.FormattingEnabled = true;
            this.cBoxFilmler.Location = new System.Drawing.Point(27, 69);
            this.cBoxFilmler.Name = "cBoxFilmler";
            this.cBoxFilmler.Size = new System.Drawing.Size(282, 28);
            this.cBoxFilmler.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filmler";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Seans ID";
            this.columnHeader7.Width = 80;
            // 
            // SeansIslemlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewSeanslar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SeansIslemlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Ekleme İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeansIslemlerForm_FormClosed);
            this.Load += new System.EventHandler(this.SeansIslemlerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSalonlar;
        private System.Windows.Forms.ListView listViewSeanslar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSeansSil;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBoxSaatler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxFilmler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}