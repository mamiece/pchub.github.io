namespace Ders26
{
    partial class SeansSaatleriForm
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
            this.listViewSaatler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.lblUzunlukDk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSaatler
            // 
            this.listViewSaatler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSaatler.FullRowSelect = true;
            this.listViewSaatler.GridLines = true;
            this.listViewSaatler.HideSelection = false;
            this.listViewSaatler.Location = new System.Drawing.Point(12, 12);
            this.listViewSaatler.Name = "listViewSaatler";
            this.listViewSaatler.Size = new System.Drawing.Size(237, 394);
            this.listViewSaatler.TabIndex = 0;
            this.listViewSaatler.UseCompatibleStateImageBehavior = false;
            this.listViewSaatler.View = System.Windows.Forms.View.Details;
            this.listViewSaatler.SelectedIndexChanged += new System.EventHandler(this.listViewSaatler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Başlangıç ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bitiş";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Uzunluk";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Location = new System.Drawing.Point(255, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 184);
            this.panel2.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Salmon;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(12, 71);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 40);
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
            this.btnEkle.Location = new System.Drawing.Point(12, 16);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBitis);
            this.panel1.Controls.Add(this.txtBaslangic);
            this.panel1.Controls.Add(this.lblUzunlukDk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(255, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 204);
            this.panel1.TabIndex = 5;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(21, 105);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(110, 26);
            this.txtBitis.TabIndex = 1;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(21, 39);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(110, 26);
            this.txtBaslangic.TabIndex = 1;
            // 
            // lblUzunlukDk
            // 
            this.lblUzunlukDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunlukDk.ForeColor = System.Drawing.Color.Crimson;
            this.lblUzunlukDk.Location = new System.Drawing.Point(17, 166);
            this.lblUzunlukDk.Name = "lblUzunlukDk";
            this.lblUzunlukDk.Size = new System.Drawing.Size(128, 25);
            this.lblUzunlukDk.TabIndex = 0;
            this.lblUzunlukDk.Text = "0";
            this.lblUzunlukDk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uzunluk(dk) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bitiş Saat : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Saat : ";
            // 
            // SeansSaatleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(436, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewSaatler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeansSaatleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Saatleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeansSaatleriForm_FormClosed);
            this.Load += new System.EventHandler(this.SeansSaatleriForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSaatler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Label lblUzunlukDk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}