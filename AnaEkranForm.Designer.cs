namespace Ders26
{
    partial class AnaEkranForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSalonIslemler = new System.Windows.Forms.Button();
            this.btnSeansIslemler = new System.Windows.Forms.Button();
            this.btnSeansSaatleri = new System.Windows.Forms.Button();
            this.btnFimIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "MTT SİNEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.Coral;
            this.button6.Image = global::Ders26.Properties.Resources.analysis;
            this.button6.Location = new System.Drawing.Point(489, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 217);
            this.button6.TabIndex = 1;
            this.button6.Text = "Rapor";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button4.Image = global::Ders26.Properties.Resources.add;
            this.button4.Location = new System.Drawing.Point(302, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 217);
            this.button4.TabIndex = 1;
            this.button4.Text = "Bilet İşlemeri";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSalonIslemler
            // 
            this.btnSalonIslemler.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnSalonIslemler.FlatAppearance.BorderSize = 2;
            this.btnSalonIslemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonIslemler.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSalonIslemler.Image = global::Ders26.Properties.Resources.cinema;
            this.btnSalonIslemler.Location = new System.Drawing.Point(302, 101);
            this.btnSalonIslemler.Name = "btnSalonIslemler";
            this.btnSalonIslemler.Size = new System.Drawing.Size(165, 217);
            this.btnSalonIslemler.TabIndex = 1;
            this.btnSalonIslemler.Text = "Salon İşlemleri";
            this.btnSalonIslemler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonIslemler.UseVisualStyleBackColor = true;
            this.btnSalonIslemler.Click += new System.EventHandler(this.btnSalonIslemler_Click);
            // 
            // btnSeansIslemler
            // 
            this.btnSeansIslemler.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSeansIslemler.FlatAppearance.BorderSize = 2;
            this.btnSeansIslemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansIslemler.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSeansIslemler.Image = global::Ders26.Properties.Resources.film_strip;
            this.btnSeansIslemler.Location = new System.Drawing.Point(107, 340);
            this.btnSeansIslemler.Name = "btnSeansIslemler";
            this.btnSeansIslemler.Size = new System.Drawing.Size(165, 217);
            this.btnSeansIslemler.TabIndex = 1;
            this.btnSeansIslemler.Text = "Seans İşlemleri";
            this.btnSeansIslemler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansIslemler.UseVisualStyleBackColor = true;
            this.btnSeansIslemler.Click += new System.EventHandler(this.btnSeansIslemler_Click);
            // 
            // btnSeansSaatleri
            // 
            this.btnSeansSaatleri.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnSeansSaatleri.FlatAppearance.BorderSize = 2;
            this.btnSeansSaatleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansSaatleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansSaatleri.ForeColor = System.Drawing.Color.Crimson;
            this.btnSeansSaatleri.Image = global::Ders26.Properties.Resources.clock;
            this.btnSeansSaatleri.Location = new System.Drawing.Point(489, 101);
            this.btnSeansSaatleri.Name = "btnSeansSaatleri";
            this.btnSeansSaatleri.Size = new System.Drawing.Size(165, 217);
            this.btnSeansSaatleri.TabIndex = 1;
            this.btnSeansSaatleri.Text = "Seans Saatleri";
            this.btnSeansSaatleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansSaatleri.UseVisualStyleBackColor = true;
            this.btnSeansSaatleri.Click += new System.EventHandler(this.btnSeansSaatleri_Click);
            // 
            // btnFimIslemleri
            // 
            this.btnFimIslemleri.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnFimIslemleri.FlatAppearance.BorderSize = 2;
            this.btnFimIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFimIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFimIslemleri.ForeColor = System.Drawing.Color.Purple;
            this.btnFimIslemleri.Image = global::Ders26.Properties.Resources.video_player1;
            this.btnFimIslemleri.Location = new System.Drawing.Point(107, 101);
            this.btnFimIslemleri.Name = "btnFimIslemleri";
            this.btnFimIslemleri.Size = new System.Drawing.Size(165, 217);
            this.btnFimIslemleri.TabIndex = 1;
            this.btnFimIslemleri.Text = "Film işlemleri";
            this.btnFimIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFimIslemleri.UseVisualStyleBackColor = true;
            this.btnFimIslemleri.Click += new System.EventHandler(this.btnFimIslemleri_Click);
            // 
            // AnaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 592);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSalonIslemler);
            this.Controls.Add(this.btnSeansIslemler);
            this.Controls.Add(this.btnSeansSaatleri);
            this.Controls.Add(this.btnFimIslemleri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Otomasyonu";
            this.Load += new System.EventHandler(this.AnaEkranForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFimIslemleri;
        private System.Windows.Forms.Button btnSeansIslemler;
        private System.Windows.Forms.Button btnSalonIslemler;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSeansSaatleri;
        private System.Windows.Forms.Button button6;
    }
}

