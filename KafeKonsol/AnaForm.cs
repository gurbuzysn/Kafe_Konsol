﻿using KafeKonsol.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKonsol
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            OrnekUrunleriYukle();
            MasalariYukle();


        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 20m });
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 15m });
        }

        private void MasalariYukle()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                var lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            var lviTiklanan = lvwMasalar.SelectedItems[0];
            int masaNo = (int)lviTiklanan.Tag;

            //bu masada şuan oturan var mı ?

            var siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);

            if (siparis == null)
            {
                lviTiklanan.ImageKey = "dolu";
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }

            var frmSiparis = new SiparisForm(db, siparis);
            frmSiparis.ShowDialog();

            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lviTiklanan.ImageKey = "bos";
            }


        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }
    }
}
