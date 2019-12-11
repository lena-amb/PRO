using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRO1.Models
{
    public partial class s17293Context : DbContext
    {
        public s17293Context()
        {
        }

        public s17293Context(DbContextOptions<s17293Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<KategoriaPizza> KategoriaPizza { get; set; }
        public virtual DbSet<KategoriaProdukt> KategoriaProdukt { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<ProduktMenu> ProduktMenu { get; set; }
        public virtual DbSet<ProduktZamowienie> ProduktZamowienie { get; set; }
        public virtual DbSet<Promocja> Promocja { get; set; }
        public virtual DbSet<Skadnik> Skadnik { get; set; }
        public virtual DbSet<SkladnikPizza> SkladnikPizza { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<ZamowieniePizza> ZamowieniePizza { get; set; }

        // Unable to generate entity type for table 'dbo.DEPT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SALGRADE'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s17293;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__EMP__14CCF2EE21DE42E4");

                entity.ToTable("EMP");

                entity.Property(e => e.Empno)
                    .HasColumnName("EMPNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasColumnName("ENAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hiredate)
                    .HasColumnName("HIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<KategoriaPizza>(entity =>
            {
                entity.HasKey(e => e.IdKategoriaPizza)
                    .HasName("KategoriaPizza_pk");

                entity.Property(e => e.IdKategoriaPizza).ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KategoriaProdukt>(entity =>
            {
                entity.HasKey(e => e.IdKategoriaProdukt)
                    .HasName("KategoriaProdukt_pk");

                entity.Property(e => e.IdKategoriaProdukt).ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Klient>(entity =>
            {
                entity.HasKey(e => e.NrKlient)
                    .HasName("Klient_pk");

                entity.Property(e => e.NrKlient)
                    .HasColumnName("nrKlient")
                    .ValueGeneratedNever();

                entity.Property(e => e.NrKartyDuzejRodziny).HasColumnName("nrKartyDuzejRodziny");

                entity.Property(e => e.NrLegitymacji).HasColumnName("nrLegitymacji");

                entity.HasOne(d => d.IdOsobaNavigation)
                    .WithMany(p => p.Klient)
                    .HasForeignKey(d => d.IdOsoba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Klient_Osoba");
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.HasKey(e => e.IdOsoba)
                    .HasName("Num");

                entity.Property(e => e.IdOsoba).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza)
                    .HasName("Pizza_pk");

                entity.Property(e => e.IdPizza).ValueGeneratedNever();

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("money");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rozmiar).HasColumnName("rozmiar");

                entity.HasOne(d => d.IdKategoriaNavigation)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.IdKategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pizza_KategoriaPizza");
            });

            modelBuilder.Entity<Pracownik>(entity =>
            {
                entity.HasKey(e => e.IdPracownik)
                    .HasName("Pracownik_pk");

                entity.Property(e => e.IdPracownik).ValueGeneratedNever();

                entity.Property(e => e.DataKoncaUmowy)
                    .HasColumnName("dataKoncaUmowy")
                    .HasColumnType("date");

                entity.Property(e => e.DataZatrudnienia)
                    .HasColumnName("dataZatrudnienia")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdOsobaNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdOsoba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pracownik_Osoba");
            });

            modelBuilder.Entity<ProduktMenu>(entity =>
            {
                entity.HasKey(e => e.IdProdukt)
                    .HasName("ProduktMenu_pk");

                entity.Property(e => e.IdProdukt).ValueGeneratedNever();

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("money");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdKategoriaNavigation)
                    .WithMany(p => p.ProduktMenu)
                    .HasForeignKey(d => d.IdKategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProduktMenu_KategoriaProdukt");
            });

            modelBuilder.Entity<ProduktZamowienie>(entity =>
            {
                entity.HasKey(e => new { e.IdProdukt, e.NumerZamowienia })
                    .HasName("Produkt_Zamowienie_pk");

                entity.ToTable("Produkt_Zamowienie");

                entity.HasOne(d => d.IdProduktNavigation)
                    .WithMany(p => p.ProduktZamowienie)
                    .HasForeignKey(d => d.IdProdukt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Produkt_Zamówienie_ProduktMenu");

                entity.HasOne(d => d.NumerZamowieniaNavigation)
                    .WithMany(p => p.ProduktZamowienie)
                    .HasForeignKey(d => d.NumerZamowienia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Produkt_Zamówienie_Zamówienie");
            });

            modelBuilder.Entity<Promocja>(entity =>
            {
                entity.HasKey(e => e.IdPromocja)
                    .HasName("Promocja_pk");

                entity.Property(e => e.IdPromocja).ValueGeneratedNever();

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnName("opis")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RabatProcent).HasColumnName("rabatProcent");
            });

            modelBuilder.Entity<Skadnik>(entity =>
            {
                entity.HasKey(e => e.IdSkładnik)
                    .HasName("Skadnik_pk");

                entity.Property(e => e.IdSkładnik).ValueGeneratedNever();

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("money");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkladnikPizza>(entity =>
            {
                entity.HasKey(e => new { e.IdSkladnik, e.IdPizza })
                    .HasName("Skladnik_pizza_pk");

                entity.ToTable("Skladnik_pizza");

                entity.HasOne(d => d.IdPizzaNavigation)
                    .WithMany(p => p.SkladnikPizza)
                    .HasForeignKey(d => d.IdPizza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Składnik_pizza_Pizza");

                entity.HasOne(d => d.IdSkladnikNavigation)
                    .WithMany(p => p.SkladnikPizza)
                    .HasForeignKey(d => d.IdSkladnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Składnik_pizza_Składnik");
            });

            modelBuilder.Entity<Zamowienie>(entity =>
            {
                entity.HasKey(e => e.NumerZamowienia)
                    .HasName("Zamowienie_pk");

                entity.Property(e => e.NumerZamowienia).ValueGeneratedNever();

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("money");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.Property(e => e.KodPocztowy)
                    .IsRequired()
                    .HasColumnName("kodPocztowy")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Miasto)
                    .IsRequired()
                    .HasColumnName("miasto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NrKlienta).HasColumnName("nrKlienta");

                entity.Property(e => e.NumerDomu).HasColumnName("numerDomu");

                entity.Property(e => e.NumerLokalu).HasColumnName("numerLokalu");

                entity.Property(e => e.Ulica)
                    .IsRequired()
                    .HasColumnName("ulica")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocjaNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.IdPromocja)
                    .HasConstraintName("Zamówienie_Promocja");

                entity.HasOne(d => d.NrKlientaNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.NrKlienta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienie_Klient");
            });

            modelBuilder.Entity<ZamowieniePizza>(entity =>
            {
                entity.HasKey(e => new { e.IdPizza, e.NumerZamowienia })
                    .HasName("Zamowienie_Pizza_pk");

                entity.ToTable("Zamowienie_Pizza");
            });
        }
    }
}
