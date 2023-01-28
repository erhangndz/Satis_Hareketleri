using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis_Hareketleri
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        DbSatisHareketleriEntities db = new DbSatisHareketleriEntities();
        void listele()
        {
            // TODO: This line of code loads data into the 'dbSatisHareketleriDataSet2.TblPersoneller' table. You can move, or remove it, as needed.
            this.tblPersonellerTableAdapter.Fill(this.dbSatisHareketleriDataSet2.TblPersoneller);
            // TODO: This line of code loads data into the 'dbSatisHareketleriDataSet1.TblMusteri' table. You can move, or remove it, as needed.
            this.tblMusteriTableAdapter.Fill(this.dbSatisHareketleriDataSet1.TblMusteri);
            // TODO: This line of code loads data into the 'dbSatisHareketleriDataSet.TblUrunler' table. You can move, or remove it, as needed.
            this.tblUrunlerTableAdapter.Fill(this.dbSatisHareketleriDataSet.TblUrunler);
        }
        private void FrmSatis_Load(object sender, EventArgs e)
        {


            listele();
            
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TblHareketler h = new TblHareketler();
            h.Urun = byte.Parse( comboBoxUrunAd.SelectedValue.ToString());
            h.Musteri = byte.Parse( comboboxMusteri.SelectedValue.ToString());
            h.Personel = byte.Parse( comboBoxPersonel.SelectedValue.ToString());
            h.Fiyat = short.Parse(txtFiyat.Text);

            db.TblHareketler.Add(h);
            db.SaveChanges();
            
            MessageBox.Show("Yeni Satış işlemi gerçekleşti ve satış hareketi sisteme kaydedildi.", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnHareketler_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text != "" && txtStok.Text != "" && txtAlisFiyat.Text != "" && txtSatisFiyat.Text != "")
            {
                TblUrunler x = new TblUrunler();
                x.Ad = txtUrunAd.Text;
                x.Stok = byte.Parse(txtStok.Text);
                x.AlisFiyat = short.Parse(txtAlisFiyat.Text);
                x.SatisFiyat = short.Parse(txtSatisFiyat.Text);

                db.TblUrunler.Add(x);
                db.SaveChanges();
                MessageBox.Show("Yeni ürün sisteme kaydedildi.", "Yeni Ürün", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrunAd.Clear();
                txtStok.Clear();
                txtAlisFiyat.Clear();
                txtSatisFiyat.Clear();
                listele();
            }
            else
            {
                MessageBox.Show("Ürün adı, stok bilgisi, alış ve satış bilgisi alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
