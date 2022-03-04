
namespace IleriRepository.Forms
{
    partial class frmOgrenci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txOzet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.txKapıNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txCaade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txSokak = new System.Windows.Forms.TextBox();
            this.cmbEgitim = new System.Windows.Forms.ComboBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.txAd = new System.Windows.Forms.TextBox();
            this.Bölüm = new System.Windows.Forms.Label();
            this.txBolum = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txOzet
            // 
            this.txOzet.Location = new System.Drawing.Point(93, 28);
            this.txOzet.Multiline = true;
            this.txOzet.Name = "txOzet";
            this.txOzet.Size = new System.Drawing.Size(210, 20);
            this.txOzet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Özet";
            // 
            // dTP
            // 
            this.dTP.Location = new System.Drawing.Point(591, 82);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(200, 20);
            this.dTP.TabIndex = 50;
            // 
            // txKapıNo
            // 
            this.txKapıNo.Location = new System.Drawing.Point(591, 162);
            this.txKapıNo.Name = "txKapıNo";
            this.txKapıNo.Size = new System.Drawing.Size(121, 20);
            this.txKapıNo.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(526, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Kapı No";
            // 
            // txCaade
            // 
            this.txCaade.Location = new System.Drawing.Point(591, 110);
            this.txCaade.Name = "txCaade";
            this.txCaade.Size = new System.Drawing.Size(121, 20);
            this.txCaade.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(524, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cadde";
            // 
            // txSokak
            // 
            this.txSokak.Location = new System.Drawing.Point(591, 136);
            this.txSokak.Name = "txSokak";
            this.txSokak.Size = new System.Drawing.Size(121, 20);
            this.txSokak.TabIndex = 45;
            // 
            // cmbEgitim
            // 
            this.cmbEgitim.FormattingEnabled = true;
            this.cmbEgitim.Location = new System.Drawing.Point(591, 245);
            this.cmbEgitim.Name = "cmbEgitim";
            this.cmbEgitim.Size = new System.Drawing.Size(121, 21);
            this.cmbEgitim.TabIndex = 44;
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(591, 220);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(121, 21);
            this.cmbIlce.TabIndex = 43;
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(591, 193);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 21);
            this.cmbSehir.TabIndex = 42;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(523, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Sokak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(525, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Eğitim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(527, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "İlçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(527, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(523, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(523, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Soyad";
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(526, 32);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(20, 13);
            this.Ad.TabIndex = 33;
            this.Ad.Text = "Ad";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(591, 55);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(121, 20);
            this.txSoyad.TabIndex = 32;
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(591, 28);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(121, 20);
            this.txAd.TabIndex = 31;
            // 
            // Bölüm
            // 
            this.Bölüm.AutoSize = true;
            this.Bölüm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bölüm.Location = new System.Drawing.Point(527, 282);
            this.Bölüm.Name = "Bölüm";
            this.Bölüm.Size = new System.Drawing.Size(36, 13);
            this.Bölüm.TabIndex = 51;
            this.Bölüm.Text = "Bölüm";
            // 
            // txBolum
            // 
            this.txBolum.Location = new System.Drawing.Point(591, 279);
            this.txBolum.Name = "txBolum";
            this.txBolum.Size = new System.Drawing.Size(121, 20);
            this.txBolum.TabIndex = 52;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(287, 253);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 55;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(190, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 54;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(96, 253);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 53;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txBolum);
            this.Controls.Add(this.Bölüm);
            this.Controls.Add(this.dTP);
            this.Controls.Add(this.txKapıNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txCaade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txSokak);
            this.Controls.Add(this.cmbEgitim);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txOzet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmOgrenci";
            this.Text = "frmOgrenci";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txOzet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.TextBox txKapıNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txCaade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txSokak;
        private System.Windows.Forms.ComboBox cmbEgitim;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label Bölüm;
        private System.Windows.Forms.TextBox txBolum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}