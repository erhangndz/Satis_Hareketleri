
namespace Satis_Hareketleri
{
    partial class FrmSatis
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.BtnHareketler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSatisYap = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxMusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUrunAd = new System.Windows.Forms.ComboBox();
            this.tblUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSatisHareketleriDataSet = new Satis_Hareketleri.DbSatisHareketleriDataSet();
            this.tblUrunlerTableAdapter = new Satis_Hareketleri.DbSatisHareketleriDataSetTableAdapters.TblUrunlerTableAdapter();
            this.dbSatisHareketleriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSatisHareketleriDataSet1 = new Satis_Hareketleri.DbSatisHareketleriDataSet1();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMusteriTableAdapter = new Satis_Hareketleri.DbSatisHareketleriDataSet1TableAdapters.TblMusteriTableAdapter();
            this.dbSatisHareketleriDataSet2 = new Satis_Hareketleri.DbSatisHareketleriDataSet2();
            this.tblPersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonellerTableAdapter = new Satis_Hareketleri.DbSatisHareketleriDataSet2TableAdapters.TblPersonellerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonellerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.BtnHareketler);
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxPersonel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboboxMusteri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxUrunAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(441, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Satışı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(105, 122);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(186, 24);
            this.txtFiyat.TabIndex = 10;
            // 
            // BtnHareketler
            // 
            this.BtnHareketler.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHareketler.Appearance.Options.UseFont = true;
            this.BtnHareketler.Location = new System.Drawing.Point(106, 204);
            this.BtnHareketler.Name = "BtnHareketler";
            this.BtnHareketler.Size = new System.Drawing.Size(185, 40);
            this.BtnHareketler.TabIndex = 9;
            this.BtnHareketler.Text = "Hareketler";
            this.BtnHareketler.Click += new System.EventHandler(this.BtnHareketler_Click);
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisYap.Appearance.Options.UseFont = true;
            this.BtnSatisYap.Location = new System.Drawing.Point(106, 161);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(185, 37);
            this.BtnSatisYap.TabIndex = 8;
            this.BtnSatisYap.Text = "Satış Yap";
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat:";
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.DataSource = this.tblPersonellerBindingSource;
            this.comboBoxPersonel.DisplayMember = "PersonelAd";
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(105, 91);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(186, 26);
            this.comboBoxPersonel.TabIndex = 5;
            this.comboBoxPersonel.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel:";
            // 
            // comboboxMusteri
            // 
            this.comboboxMusteri.DataSource = this.tblMusteriBindingSource;
            this.comboboxMusteri.DisplayMember = "AdSoyad";
            this.comboboxMusteri.FormattingEnabled = true;
            this.comboboxMusteri.Location = new System.Drawing.Point(105, 59);
            this.comboboxMusteri.Name = "comboboxMusteri";
            this.comboboxMusteri.Size = new System.Drawing.Size(186, 26);
            this.comboboxMusteri.TabIndex = 3;
            this.comboboxMusteri.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri:";
            // 
            // comboBoxUrunAd
            // 
            this.comboBoxUrunAd.DataSource = this.tblUrunlerBindingSource;
            this.comboBoxUrunAd.DisplayMember = "Ad";
            this.comboBoxUrunAd.FormattingEnabled = true;
            this.comboBoxUrunAd.Location = new System.Drawing.Point(105, 28);
            this.comboBoxUrunAd.Name = "comboBoxUrunAd";
            this.comboBoxUrunAd.Size = new System.Drawing.Size(186, 26);
            this.comboBoxUrunAd.TabIndex = 1;
            this.comboBoxUrunAd.ValueMember = "ID";
            // 
            // tblUrunlerBindingSource
            // 
            this.tblUrunlerBindingSource.DataMember = "TblUrunler";
            this.tblUrunlerBindingSource.DataSource = this.dbSatisHareketleriDataSet;
            // 
            // dbSatisHareketleriDataSet
            // 
            this.dbSatisHareketleriDataSet.DataSetName = "DbSatisHareketleriDataSet";
            this.dbSatisHareketleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunlerTableAdapter
            // 
            this.tblUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // dbSatisHareketleriDataSetBindingSource
            // 
            this.dbSatisHareketleriDataSetBindingSource.DataSource = this.dbSatisHareketleriDataSet;
            this.dbSatisHareketleriDataSetBindingSource.Position = 0;
            // 
            // dbSatisHareketleriDataSet1
            // 
            this.dbSatisHareketleriDataSet1.DataSetName = "DbSatisHareketleriDataSet1";
            this.dbSatisHareketleriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "TblMusteri";
            this.tblMusteriBindingSource.DataSource = this.dbSatisHareketleriDataSet1;
            // 
            // tblMusteriTableAdapter
            // 
            this.tblMusteriTableAdapter.ClearBeforeFill = true;
            // 
            // dbSatisHareketleriDataSet2
            // 
            this.dbSatisHareketleriDataSet2.DataSetName = "DbSatisHareketleriDataSet2";
            this.dbSatisHareketleriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonellerBindingSource
            // 
            this.tblPersonellerBindingSource.DataMember = "TblPersoneller";
            this.tblPersonellerBindingSource.DataSource = this.dbSatisHareketleriDataSet2;
            // 
            // tblPersonellerTableAdapter
            // 
            this.tblPersonellerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.txtSatisFiyat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAlisFiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtStok);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Ürün";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(113, 31);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(186, 24);
            this.txtUrunAd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Adı:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(113, 62);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(186, 24);
            this.txtStok.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stok:";
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(113, 92);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(186, 24);
            this.txtAlisFiyat.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alış Fiyatı:";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(113, 122);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(186, 24);
            this.txtSatisFiyat.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Satış Fiyatı:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(114, 152);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(185, 37);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(815, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisHareketleriDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonellerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton BtnSatisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUrunAd;
        private DevExpress.XtraEditors.SimpleButton BtnHareketler;
        private System.Windows.Forms.TextBox txtFiyat;
        private DbSatisHareketleriDataSet dbSatisHareketleriDataSet;
        private System.Windows.Forms.BindingSource tblUrunlerBindingSource;
        private DbSatisHareketleriDataSetTableAdapters.TblUrunlerTableAdapter tblUrunlerTableAdapter;
        private System.Windows.Forms.BindingSource dbSatisHareketleriDataSetBindingSource;
        private DbSatisHareketleriDataSet1 dbSatisHareketleriDataSet1;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private DbSatisHareketleriDataSet1TableAdapters.TblMusteriTableAdapter tblMusteriTableAdapter;
        private DbSatisHareketleriDataSet2 dbSatisHareketleriDataSet2;
        private System.Windows.Forms.BindingSource tblPersonellerBindingSource;
        private DbSatisHareketleriDataSet2TableAdapters.TblPersonellerTableAdapter tblPersonellerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label5;
    }
}