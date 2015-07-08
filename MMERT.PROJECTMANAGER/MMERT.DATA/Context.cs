using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MMERT.DATA
{
    public class Context:DbContext,IDisposable
    {
        public DbSet<MMERT.MODEL.Users> Users { get; set; }
        public DbSet<MMERT.MODEL.Projects> Projects { get; set; }
        public DbSet<MMERT.MODEL.Tasks> Tasks { get; set; }
       /* public DbSet<DB.MODEL.TBL_ADRES> TBL_ADRES { get; set; }
        public DbSet<DB.MODEL.TBL_KATEGORI> TBL_KATEGORI { get; set; }
        public DbSet<DB.MODEL.TBL_KULLANICI> TBL_KULLANICI { get; set; }
        public DbSet<DB.MODEL.TBL_MUSTERI> TBL_MUSTERI { get; set; }
        public DbSet<DB.MODEL.TBL_SEPET> TBL_SEPET { get; set; }
        public DbSet<DB.MODEL.TBL_URUN> TBL_URUN { get; set; }
        public DbSet<DB.MODEL.YETKI> YETKI { get; set; }
        public DbSet<DB.MODEL.TBL_STOK> TBL_STOK { get; set; }
        public DbSet<DB.MODEL.TBL_HABER> TBL_HABER{ get; set; }
        */
        public Context()
            : base("db")
        {

        }

        public Context(string connstr)
            : base(connstr)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new YetkiMap());*/
            base.OnModelCreating(modelBuilder);
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }



    }
}
