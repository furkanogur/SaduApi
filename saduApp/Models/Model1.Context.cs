﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace saduApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaduDbEntities : DbContext
    {
        public SaduDbEntities()
            : base("name=SaduDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Kargo> Kargo { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<KategoriUrun> KategoriUrun { get; set; }
        public virtual DbSet<OdemeTuru> OdemeTuru { get; set; }
        public virtual DbSet<SiparisDurumu> SiparisDurumu { get; set; }
        public virtual DbSet<Siparisler> Siparisler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TedarikciUrunler> TedarikciUrunler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
    }
}
