namespace XMLileDovizUygulamasi
{
    partial class Form1
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
            this.LblDolarAlıs = new System.Windows.Forms.Label();
            this.LblDolarSatıs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEuroSatıs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblEuroAlıs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDolarAlıs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSatısYap = new System.Windows.Forms.Button();
            this.BtnAlısYaap = new System.Windows.Forms.Button();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroAlıs = new System.Windows.Forms.Button();
            this.BtnEuroSatıs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış :";
            // 
            // LblDolarAlıs
            // 
            this.LblDolarAlıs.AutoSize = true;
            this.LblDolarAlıs.Location = new System.Drawing.Point(105, 32);
            this.LblDolarAlıs.Name = "LblDolarAlıs";
            this.LblDolarAlıs.Size = new System.Drawing.Size(18, 20);
            this.LblDolarAlıs.TabIndex = 1;
            this.LblDolarAlıs.Text = "0";
            // 
            // LblDolarSatıs
            // 
            this.LblDolarSatıs.AutoSize = true;
            this.LblDolarSatıs.Location = new System.Drawing.Point(105, 68);
            this.LblDolarSatıs.Name = "LblDolarSatıs";
            this.LblDolarSatıs.Size = new System.Drawing.Size(18, 20);
            this.LblDolarSatıs.TabIndex = 3;
            this.LblDolarSatıs.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış :";
            // 
            // LblEuroSatıs
            // 
            this.LblEuroSatıs.AutoSize = true;
            this.LblEuroSatıs.Location = new System.Drawing.Point(105, 162);
            this.LblEuroSatıs.Name = "LblEuroSatıs";
            this.LblEuroSatıs.Size = new System.Drawing.Size(18, 20);
            this.LblEuroSatıs.TabIndex = 7;
            this.LblEuroSatıs.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış :";
            // 
            // LblEuroAlıs
            // 
            this.LblEuroAlıs.AutoSize = true;
            this.LblEuroAlıs.Location = new System.Drawing.Point(105, 126);
            this.LblEuroAlıs.Name = "LblEuroAlıs";
            this.LblEuroAlıs.Size = new System.Drawing.Size(18, 20);
            this.LblEuroAlıs.TabIndex = 5;
            this.LblEuroAlıs.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış :";
            // 
            // BtnDolarAlıs
            // 
            this.BtnDolarAlıs.Location = new System.Drawing.Point(173, 25);
            this.BtnDolarAlıs.Name = "BtnDolarAlıs";
            this.BtnDolarAlıs.Size = new System.Drawing.Size(59, 27);
            this.BtnDolarAlıs.TabIndex = 8;
            this.BtnDolarAlıs.Text = "Alış";
            this.BtnDolarAlıs.UseVisualStyleBackColor = true;
            this.BtnDolarAlıs.Click += new System.EventHandler(this.BtnDolarAlıs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSatısYap);
            this.groupBox1.Controls.Add(this.BtnAlısYaap);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(259, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // BtnSatısYap
            // 
            this.BtnSatısYap.Location = new System.Drawing.Point(222, 105);
            this.BtnSatısYap.Name = "BtnSatısYap";
            this.BtnSatısYap.Size = new System.Drawing.Size(134, 27);
            this.BtnSatısYap.TabIndex = 14;
            this.BtnSatısYap.Text = "Satış Yap";
            this.BtnSatısYap.UseVisualStyleBackColor = true;
            this.BtnSatısYap.Click += new System.EventHandler(this.BtnSatısYap_Click);
            // 
            // BtnAlısYaap
            // 
            this.BtnAlısYaap.Location = new System.Drawing.Point(222, 34);
            this.BtnAlısYaap.Name = "BtnAlısYaap";
            this.BtnAlısYaap.Size = new System.Drawing.Size(134, 27);
            this.BtnAlısYaap.TabIndex = 13;
            this.BtnAlısYaap.Text = "Alış Yap";
            this.BtnAlısYaap.UseVisualStyleBackColor = true;
            this.BtnAlısYaap.Click += new System.EventHandler(this.BtnIslemYap_Click);
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(86, 125);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(100, 26);
            this.TxtKalan.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kalan :";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(86, 93);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(100, 26);
            this.TxtTutar.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tutar :";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(86, 57);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(100, 26);
            this.TxtMiktar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Miktar :";
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(86, 19);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(100, 26);
            this.TxtKur.TabIndex = 1;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kur :";
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(173, 65);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(59, 27);
            this.BtnDolarSat.TabIndex = 10;
            this.BtnDolarSat.Text = "Satış";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroAlıs
            // 
            this.BtnEuroAlıs.Location = new System.Drawing.Point(173, 122);
            this.BtnEuroAlıs.Name = "BtnEuroAlıs";
            this.BtnEuroAlıs.Size = new System.Drawing.Size(59, 27);
            this.BtnEuroAlıs.TabIndex = 11;
            this.BtnEuroAlıs.Text = "Alış";
            this.BtnEuroAlıs.UseVisualStyleBackColor = true;
            this.BtnEuroAlıs.Click += new System.EventHandler(this.BtnEuroAlıs_Click);
            // 
            // BtnEuroSatıs
            // 
            this.BtnEuroSatıs.Location = new System.Drawing.Point(173, 162);
            this.BtnEuroSatıs.Name = "BtnEuroSatıs";
            this.BtnEuroSatıs.Size = new System.Drawing.Size(59, 27);
            this.BtnEuroSatıs.TabIndex = 12;
            this.BtnEuroSatıs.Text = "Satış";
            this.BtnEuroSatıs.UseVisualStyleBackColor = true;
            this.BtnEuroSatıs.Click += new System.EventHandler(this.BtnEuroSatıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 209);
            this.Controls.Add(this.BtnEuroSatıs);
            this.Controls.Add(this.BtnEuroAlıs);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDolarAlıs);
            this.Controls.Add(this.LblEuroSatıs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblEuroAlıs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblDolarSatıs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDolarAlıs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlıs;
        private System.Windows.Forms.Label LblDolarSatıs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEuroSatıs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblEuroAlıs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDolarAlıs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAlısYaap;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroAlıs;
        private System.Windows.Forms.Button BtnEuroSatıs;
        private System.Windows.Forms.Button BtnSatısYap;
    }
}

