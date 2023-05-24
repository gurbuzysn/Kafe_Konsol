using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; } = DateTime.Now; 
        public DateTime? KapanisZamani { get; set; }
        public List<SiparisDetay> SiparisDetaylar { get; set; } = new();  // new(); kullanılabilir.
        
        public string ToplamTutarTl => ToplamTutar().ToString("c2");   // bu bir proretydir
        //public string ToplamTutarTl { get; } = string.Empty;





        public decimal ToplamTutar() => SiparisDetaylar.Sum(x => x.Tutar());       // bu bir metotdur
        //public decimal ToplamTutar()
        //{
        //    return SiparisDetaylar.Sum(x => x.Tutar());
        //}


    }
}
