﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saduApp.ViewModel
{
    public class siparislerModel
    {

        public string siparisId { get; set; }
        public System.DateTime SiparisTarihi { get; set; }
        public string UyeId { get; set; }
        public string UrunId { get; set; }
        public string Adres { get; set; }
        public decimal Fiyat { get; set; }
        public string OdemeId { get; set; }
        public string KargoId { get; set; }
        public string TedarikUyeId { get; set; }
        public Nullable<decimal> KargoUcreti { get; set; }
        public string SiparisDurumuId { get; set; }
        public uyeModel SiparisUye { get; set; }
        public urunlerModel SiparisUrun { get; set; }
        public kargoModel SiparisKargo { get; set; }
        public odemeTuruModel SiparisOdeme { get; set; }
        public siparisDurumuModel SiparisDurum { get; set; }



    }
}