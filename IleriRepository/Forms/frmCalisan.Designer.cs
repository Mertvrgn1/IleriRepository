
namespace IleriRepository.Forms
{
    partial class frmCalisan
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
            this.txHead = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txAd = new System.Windows.Forms.TextBox();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Maas = new System.Windows.Forms.Label();
            this.txMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbEgitim = new System.Windows.Forms.ComboBox();
            this.txSokak = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txCaade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txKapıNo = new System.Windows.Forms.TextBox();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txHead
            // 
            this.txHead.Location = new System.Drawing.Point(170, 12);
            this.txHead.Multiline = true;
            this.txHead.Name = "txHead";
            this.txHead.Size = new System.Drawing.Size(247, 20);
            this.txHead.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(76, 240);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(170, 240);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(267, 240);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Özet";
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(582, 16);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(121, 20);
            this.txAd.TabIndex = 6;
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(582, 43);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(121, 20);
            this.txSoyad.TabIndex = 7;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(517, 20);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(20, 13);
            this.Ad.TabIndex = 8;
            this.Ad.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(514, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyad";
            // 
            // Maas
            // 
            this.Maas.AutoSize = true;
            this.Maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Maas.Location = new System.Drawing.Point(518, 267);
            this.Maas.Name = "Maas";
            this.Maas.Size = new System.Drawing.Size(33, 13);
            this.Maas.TabIndex = 10;
            this.Maas.Text = "Maas";
            // 
            // txMaas
            // 
            this.txMaas.Location = new System.Drawing.Point(582, 260);
            this.txMaas.Name = "txMaas";
            this.txMaas.Size = new System.Drawing.Size(121, 20);
            this.txMaas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(514, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(518, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(518, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "İlçe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(516, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Eğitim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(514, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sokak";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(582, 181);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 21);
            this.cmbSehir.TabIndex = 20;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(582, 208);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(121, 21);
            this.cmbIlce.TabIndex = 21;
            // 
            // cmbEgitim
            // 
            this.cmbEgitim.FormattingEnabled = true;
            this.cmbEgitim.Location = new System.Drawing.Point(582, 233);
            this.cmbEgitim.Name = "cmbEgitim";
            this.cmbEgitim.Size = new System.Drawing.Size(121, 21);
            this.cmbEgitim.TabIndex = 22;
            // 
            // txSokak
            // 
            this.txSokak.Location = new System.Drawing.Point(582, 124);
            this.txSokak.Name = "txSokak";
            this.txSokak.Size = new System.Drawing.Size(121, 20);
            this.txSokak.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(515, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cadde";
            // 
            // txCaade
            // 
            this.txCaade.Location = new System.Drawing.Point(582, 98);
            this.txCaade.Name = "txCaade";
            this.txCaade.Size = new System.Drawing.Size(121, 20);
            this.txCaade.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(517, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Kapı No";
            // 
            // txKapıNo
            // 
            this.txKapıNo.Location = new System.Drawing.Point(582, 150);
            this.txKapıNo.Name = "txKapıNo";
            this.txKapıNo.Size = new System.Drawing.Size(121, 20);
            this.txKapıNo.TabIndex = 27;
            // 
            // dTP
            // 
            this.dTP.Location = new System.Drawing.Point(582, 70);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(200, 20);
            this.dTP.TabIndex = 30;
            // 
            // frmCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.txMaas);
            this.Controls.Add(this.Maas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txHead);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCalisan";
            this.Text = "frmCalisan";
            this.Load += new System.EventHandler(this.frmCalisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txHead;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Maas;
        private System.Windows.Forms.TextBox txMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbEgitim;
        private System.Windows.Forms.TextBox txSokak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txCaade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txKapıNo;
        private System.Windows.Forms.DateTimePicker dTP;
    }
}