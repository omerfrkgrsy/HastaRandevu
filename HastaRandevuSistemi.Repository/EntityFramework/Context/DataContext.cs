
using HastaRandevuSistemi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Repository.EntityFramework.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Sekreter> Sekreters { get; set; }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<Brans> Branss { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<RandevuSaat> RandevuSaats { get; set; }
        

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Doktor>(b =>
            {
                b.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Sekreter>(b =>
            {
                b.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Sekreter>().HasData(new Sekreter
            {
                Id = 1,
                Ad = "Ana",
                Soyad = "Sekreter",
                KullaniciAdi = "sekreter",
                Sifre = "12345",
                TelefonNo = "05315478569"
            });

            modelBuilder.Entity<Hasta>(b =>
            {
                b.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Hasta>().HasData(new Hasta
            {
                Id = 1,
                Ad = "Hasta",
                Soyad = "Adam",
                TelefonNo = "05315478569",
                TCKN = "05315478569"
            });

            modelBuilder.Entity<Brans>(b =>
            {
                b.HasKey(x => x.Id);
                b.HasMany(c => c.Doktors).WithOne(e => e.Brans);
            });

            modelBuilder.Entity<RandevuSaat>(b =>
            {
                b.HasKey(x => x.Id);
                b.HasMany(c => c.Randevus).WithOne(e => e.RandevuSaat);
            });

            modelBuilder.Entity<Randevu>(b =>
            {
                b.HasKey(x => x.Id);
                b.HasOne(c => c.Hasta).WithMany(e => e.Randevus).HasForeignKey(c=>c.HastaId);
                b.HasOne(c => c.Sekreter).WithMany(e => e.Randevus).HasForeignKey(c=>c.SekreterId);
                b.HasOne(c => c.Doktor).WithMany(e => e.Randevus).HasForeignKey(c=>c.DoktorId);
            });

            modelBuilder.Entity<Doktor>().HasData(new Doktor
            {
                Id = 1,
                Ad = "Doktor",
                Soyad = "Adam",
                Sifre = "1234",
                TelefonNo = "05315478569",
                KullaniciAdi = "doktor",
                BransId = 1
                
            });

            modelBuilder.Entity<Doktor>().HasData(new Doktor
            {
                Id = 2,
                Ad = "Doktor 2",
                Soyad = "Kadın ",
                Sifre = "1234",
                TelefonNo = "05315478569",
                KullaniciAdi = "doktor1",
                BransId = 2
            });

            #region Branş Bulk Insert
            modelBuilder.Entity<Brans>().HasData(
                new Brans
                {
                    Id= 1,
                    Ad = "Kardiyoloji"
                },
                new Brans
                {
                    Id = 2,
                    Ad ="Genel Cerrahi"
                },
                new Brans
                {
                    Id = 3,
                    Ad = "Psikiyatri"
                },
                new Brans
                {
                    Id = 4,
                    Ad = "Kulak-Burun-Boğaz"
                },
                new Brans
                {
                    Id = 5,
                    Ad = "Kadın Hastalıkları"
                },
                new Brans
                {
                    Id = 6,
                    Ad = "Kadın Doğum"
                },
                new Brans
                {
                    Id = 7,
                    Ad = "Üroloji"
                },
                new Brans
                {
                    Id = 8,
                    Ad = "Dahiliye"
                },
                new Brans
                {
                    Id = 9,
                    Ad = "Çocuk Hastalıkları"
                },
                new Brans
                {
                    Id = 10,
                    Ad = "Aile Hekimi"
                }
            );
            #endregion

            DateTime startTime = new DateTime(1,1,1,09,00,00);
            DateTime endTime = new DateTime(1,1,1,17,00,00);
            TimeSpan aralik = new TimeSpan(0, 30, 0);
            int id = 1;
            for (var tarih=startTime; tarih <= endTime;tarih= tarih.Add(aralik))
            {
                modelBuilder.Entity<RandevuSaat>().HasData(
                   new RandevuSaat
                   {
                       Id = id++,
                       Saat = tarih.TimeOfDay.ToString(),
                   });
            }
           


        }
    }
}
