using System;
using System.Collections.Generic;
using System.Text;
using Andamios.DOMAIN.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Andamios.DOMAIN.Context
{
    public class AndamiosDominicanosContext : IdentityDbContext<Usuario>
    {

        public AndamiosDominicanosContext(DbContextOptions<AndamiosDominicanosContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<DdbalanceCc> DdbalanceCc { get; set; }
        public virtual DbSet<Ddbanco> Ddbanco { get; set; }
        public virtual DbSet<DdclaseProd> DdclaseProd { get; set; }
        public virtual DbSet<Ddcliente> Ddcliente { get; set; }
        public virtual DbSet<DdconDespDet> DdconDespDet { get; set; }
        public virtual DbSet<DdconDespEnc> DdconDespEnc { get; set; }
        public virtual DbSet<DdconDevoDet> DdconDevoDet { get; set; }
        public virtual DbSet<DdconDevoEnc> DdconDevoEnc { get; set; }
        public virtual DbSet<DdconteoDespDet> DdconteoDespDet { get; set; }
        public virtual DbSet<DdconteoDespEnc> DdconteoDespEnc { get; set; }
        public virtual DbSet<DdconteoDevoDet> DdconteoDevoDet { get; set; }
        public virtual DbSet<DdconteoDevoEnc> DdconteoDevoEnc { get; set; }
        public virtual DbSet<DdcontrolBal> DdcontrolBal { get; set; }
        public virtual DbSet<DdcontrolFact> DdcontrolFact { get; set; }
        public virtual DbSet<DdcotiDetalle> DdcotiDetalle { get; set; }
        public virtual DbSet<DdcotiEncabezado> DdcotiEncabezado { get; set; }
        public virtual DbSet<DddepositoBal> DddepositoBal { get; set; }
        public virtual DbSet<DddepositoBco> DddepositoBco { get; set; }
        public virtual DbSet<DddepositoCoti> DddepositoCoti { get; set; }
        public virtual DbSet<DddetalleReciboCc> DddetalleReciboCc { get; set; }
        public virtual DbSet<DdfactDet> DdfactDet { get; set; }
        public virtual DbSet<DdfactEnc> DdfactEnc { get; set; }
        public virtual DbSet<DdingInvDet> DdingInvDet { get; set; }
        public virtual DbSet<DdingInvEnc> DdingInvEnc { get; set; }
        public virtual DbSet<DdmaeInventario> DdmaeInventario { get; set; }
        public virtual DbSet<DdmovimientoCc> DdmovimientoCc { get; set; }
        public virtual DbSet<DdpagoNoAp> DdpagoNoAp { get; set; }
        public virtual DbSet<Ddproyecto> Ddproyecto { get; set; }
        public virtual DbSet<DdreciboCc> DdreciboCc { get; set; }
        public virtual DbSet<Ddsuplidor> Ddsuplidor { get; set; }
        public virtual DbSet<DdtipComprobante> DdtipComprobante { get; set; }
        public virtual DbSet<DdtipoTraAju> DdtipoTraAju { get; set; }
        public virtual DbSet<DdtraAjuInv> DdtraAjuInv { get; set; }

        // Unable to generate entity type for table 'dbo.DDAgente'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DDTraPrecioInv'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=VIXAR-7510\\SQLDEV;Initial Catalog=AndamiosDominicanos;Integrated Security=True");
//            }
//        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DdbalanceCc>(entity =>
            {
                entity.HasKey(e => e.CcbalId);

                entity.ToTable("DDBalanceCC");

                entity.HasIndex(e => new { e.CcbalClienteId, e.CcbalProyectoId, e.CcbalCotiId, e.CcbalFactId, e.CcbalFactTipo, e.CcbalFactClas })
                    .HasName("UC_DDBalanceCC")
                    .IsUnique();

                entity.Property(e => e.CcbalId).HasColumnName("CCBalID");

                entity.Property(e => e.CcbalBalStatus)
                    .IsRequired()
                    .HasColumnName("CCBalBalStatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcbalClienteId).HasColumnName("CCBalClienteID");

                entity.Property(e => e.CcbalCotiId).HasColumnName("CCBalCotiID");

                entity.Property(e => e.CcbalFactClas)
                    .IsRequired()
                    .HasColumnName("CCBalFactClas")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcbalFactId).HasColumnName("CCBalFactID");

                entity.Property(e => e.CcbalFactTipo)
                    .IsRequired()
                    .HasColumnName("CCBalFactTipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcbalMontoFact)
                    .HasColumnName("CCBalMontoFact")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcbalProyectoId).HasColumnName("CCBalProyectoID");

                entity.Property(e => e.CcbalRecibidoFact)
                    .HasColumnName("CCBalRecibidoFact")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CcbalCliente)
                    .WithMany(p => p.DdbalanceCc)
                    .HasForeignKey(d => d.CcbalClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDBalanceCC_DDCliente");
            });

            modelBuilder.Entity<Ddbanco>(entity =>
            {
                entity.HasKey(e => e.CcbancoId);

                entity.ToTable("DDBanco");

                entity.Property(e => e.CcbancoId)
                    .HasColumnName("CCBancoID")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CcbancoDescripcion)
                    .IsRequired()
                    .HasColumnName("CCBancoDescripcion")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CcbancoEstatus)
                    .IsRequired()
                    .HasColumnName("CCBancoEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcbancoFechaCrea)
                    .HasColumnName("CCBancoFechaCrea")
                    .HasColumnType("datetime");

                entity.Property(e => e.CcbancoFechaMod)
                    .HasColumnName("CCBancoFechaMod")
                    .HasColumnType("datetime");

                entity.Property(e => e.CcbancoNumCta)
                    .IsRequired()
                    .HasColumnName("CCBancoNumCta")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CcbancoTipoCta)
                    .IsRequired()
                    .HasColumnName("CCBancoTipoCta")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcbancoUsuCrea)
                    .IsRequired()
                    .HasColumnName("CCBancoUsuCrea")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CcbancoUsuMod)
                    .IsRequired()
                    .HasColumnName("CCBancoUsuMod")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdclaseProd>(entity =>
            {
                entity.HasKey(e => e.ClaProdId);

                entity.ToTable("DDClaseProd");

                entity.Property(e => e.ClaProdId).HasColumnName("ClaProdID");

                entity.Property(e => e.ClaProdCtrlInventario)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaProdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaProdEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClaProdFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.ClaProdFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.ClaProdUsuarioCreacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClaProdUsuarioModifica)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ddcliente>(entity =>
            {
                entity.HasKey(e => e.ClienteId);

                entity.ToTable("DDCliente");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.ClienteCodigoVendedor)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteContacto)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteContactoCel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteContactoCel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteCorreoElec)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteDescripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteDireccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.ClienteFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.ClienteGerente)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteGestorCobros)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteTelFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteTelOf1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteTelOf2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteTipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteTipoComprobante).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ClienteTipoId)
                    .HasColumnName("ClienteTipoID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteUsuarioModifica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteUsuarioRegistro)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdconDespDet>(entity =>
            {
                entity.HasKey(e => e.ConDespDetId);

                entity.ToTable("DDConDespDet");

                entity.Property(e => e.ConDespDetId).HasColumnName("ConDespDetID");

                entity.Property(e => e.ConDespDetProdId)
                    .HasColumnName("ConDespDetProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConDespEnDetId).HasColumnName("ConDespEnDetID");

                entity.HasOne(d => d.ConDespDetProd)
                    .WithMany(p => p.DdconDespDet)
                    .HasForeignKey(d => d.ConDespDetProdId)
                    .HasConstraintName("FK_DDConDespDet_DDMaeInventario");

                entity.HasOne(d => d.ConDespEnDet)
                    .WithMany(p => p.DdconDespDet)
                    .HasForeignKey(d => d.ConDespEnDetId)
                    .HasConstraintName("FK_DDConDespDet_DDConDespEnc");
            });

            modelBuilder.Entity<DdconDespEnc>(entity =>
            {
                entity.HasKey(e => e.ConDespEnId);

                entity.ToTable("DDConDespEnc");

                entity.Property(e => e.ConDespEnId).HasColumnName("ConDespEnID");

                entity.Property(e => e.ConDespEnCliId).HasColumnName("ConDespEnCliID");

                entity.Property(e => e.ConDespEnConteoId).HasColumnName("ConDespEnConteoID");

                entity.Property(e => e.ConDespEnCotiId).HasColumnName("ConDespEnCotiID");

                entity.Property(e => e.ConDespEnEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConDespEnFechaEmision).HasColumnType("datetime");

                entity.Property(e => e.ConDespEnOrdenC)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ConDespEnProyectoId).HasColumnName("ConDespEnProyectoID");

                entity.Property(e => e.ConDespEnTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConDespEnUsuarioCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConDespEnCli)
                    .WithMany(p => p.DdconDespEnc)
                    .HasForeignKey(d => d.ConDespEnCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDespEnc_DDCliente");

                entity.HasOne(d => d.ConDespEnCoti)
                    .WithMany(p => p.DdconDespEnc)
                    .HasForeignKey(d => d.ConDespEnCotiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDespEnc_DDCotiEncabezado");

                entity.HasOne(d => d.ConDespEnProyecto)
                    .WithMany(p => p.DdconDespEnc)
                    .HasForeignKey(d => d.ConDespEnProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDespEnc_DDProyecto");
            });

            modelBuilder.Entity<DdconDevoDet>(entity =>
            {
                entity.HasKey(e => e.ConDevoDetId);

                entity.ToTable("DDConDevoDet");

                entity.Property(e => e.ConDevoDetId).HasColumnName("ConDevoDetID");

                entity.Property(e => e.ConDevoDetEnId).HasColumnName("ConDevoDetEnID");

                entity.Property(e => e.ConDevoProdId)
                    .HasColumnName("ConDevoProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConDevoDetEn)
                    .WithMany(p => p.DdconDevoDet)
                    .HasForeignKey(d => d.ConDevoDetEnId)
                    .HasConstraintName("FK_DDConDevoDet_DDConDevoEnc");

                entity.HasOne(d => d.ConDevoProd)
                    .WithMany(p => p.DdconDevoDet)
                    .HasForeignKey(d => d.ConDevoProdId)
                    .HasConstraintName("FK_DDConDevoDet_DDMaeInventario");
            });

            modelBuilder.Entity<DdconDevoEnc>(entity =>
            {
                entity.HasKey(e => e.ConDevoEnId);

                entity.ToTable("DDConDevoEnc");

                entity.Property(e => e.ConDevoEnId).HasColumnName("ConDevoEnID");

                entity.Property(e => e.ConDevoEnCliId).HasColumnName("ConDevoEnCliID");

                entity.Property(e => e.ConDevoEnContId).HasColumnName("ConDevoEnContID");

                entity.Property(e => e.ConDevoEnCotiId).HasColumnName("ConDevoEnCotiID");

                entity.Property(e => e.ConDevoEnEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConDevoEnProyectoId).HasColumnName("ConDevoEnProyectoID");

                entity.Property(e => e.ConDevoEnTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConDevoFechaEmision).HasColumnType("datetime");

                entity.Property(e => e.ConDevoOrdenC)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ConDevoUsuarioCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConDevoEnCli)
                    .WithMany(p => p.DdconDevoEnc)
                    .HasForeignKey(d => d.ConDevoEnCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDevoEnc_DDCliente");

                entity.HasOne(d => d.ConDevoEnCont)
                    .WithMany(p => p.DdconDevoEnc)
                    .HasForeignKey(d => d.ConDevoEnContId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDevoEnc_DDConteoDevoEnc");

                entity.HasOne(d => d.ConDevoEnCoti)
                    .WithMany(p => p.DdconDevoEnc)
                    .HasForeignKey(d => d.ConDevoEnCotiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDevoEnc_DDCotiEncabezado");

                entity.HasOne(d => d.ConDevoEnProyecto)
                    .WithMany(p => p.DdconDevoEnc)
                    .HasForeignKey(d => d.ConDevoEnProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConDevoEnc_DDProyecto");
            });

            modelBuilder.Entity<DdconteoDespDet>(entity =>
            {
                entity.HasKey(e => e.ContDespDetId)
                    .HasName("PK_DDConteoDespDetalle");

                entity.ToTable("DDConteoDespDet");

                entity.Property(e => e.ContDespDetId).HasColumnName("ContDespDetID");

                entity.Property(e => e.ContDespDetEncId).HasColumnName("ContDespDetEncID");

                entity.Property(e => e.ContDespProdId)
                    .HasColumnName("ContDespProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContDespDetEnc)
                    .WithMany(p => p.DdconteoDespDet)
                    .HasForeignKey(d => d.ContDespDetEncId)
                    .HasConstraintName("FK_DDConteoDespDet_DDConteoDespEnc");

                entity.HasOne(d => d.ContDespProd)
                    .WithMany(p => p.DdconteoDespDet)
                    .HasForeignKey(d => d.ContDespProdId)
                    .HasConstraintName("FK_DDConteoDespDet_DDMaeInventario");
            });

            modelBuilder.Entity<DdconteoDespEnc>(entity =>
            {
                entity.HasKey(e => e.ContDespEncId);

                entity.ToTable("DDConteoDespEnc");

                entity.Property(e => e.ContDespEncId).HasColumnName("ContDespEncID");

                entity.Property(e => e.ContDespEncClienteId).HasColumnName("ContDespEncClienteID");

                entity.Property(e => e.ContDespEncCotiId).HasColumnName("ContDespEncCotiID");

                entity.Property(e => e.ContDespEncEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContDespEncFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.ContDespEncFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.ContDespEncOrden)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ContDespEncProyectoId).HasColumnName("ContDespEncProyectoID");

                entity.Property(e => e.ContDespEncUserCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContDespEncUserModifica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContDespEncCliente)
                    .WithMany(p => p.DdconteoDespEnc)
                    .HasForeignKey(d => d.ContDespEncClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConteoDespEnc_DDCliente");

                entity.HasOne(d => d.ContDespEncCoti)
                    .WithMany(p => p.DdconteoDespEnc)
                    .HasForeignKey(d => d.ContDespEncCotiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConteoDespEnc_DDCotiEncabezado");

                entity.HasOne(d => d.ContDespEncProyecto)
                    .WithMany(p => p.DdconteoDespEnc)
                    .HasForeignKey(d => d.ContDespEncProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConteoDespEnc_DDProyecto");
            });

            modelBuilder.Entity<DdconteoDevoDet>(entity =>
            {
                entity.HasKey(e => e.ContDevoDetId);

                entity.ToTable("DDConteoDevoDet");

                entity.Property(e => e.ContDevoDetId).HasColumnName("ContDevoDetID");

                entity.Property(e => e.ContDevoDetEncId).HasColumnName("ContDevoDetEncID");

                entity.Property(e => e.ContDevoProdId)
                    .HasColumnName("ContDevoProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContDevoDetEnc)
                    .WithMany(p => p.DdconteoDevoDet)
                    .HasForeignKey(d => d.ContDevoDetEncId)
                    .HasConstraintName("FK_DDConteoDevoDet_DDConteoDevoEnc");

                entity.HasOne(d => d.ContDevoProd)
                    .WithMany(p => p.DdconteoDevoDet)
                    .HasForeignKey(d => d.ContDevoProdId)
                    .HasConstraintName("FK_DDConteoDevoDet_DDMaeInventario");
            });

            modelBuilder.Entity<DdconteoDevoEnc>(entity =>
            {
                entity.HasKey(e => e.ContDevoEncId);

                entity.ToTable("DDConteoDevoEnc");

                entity.Property(e => e.ContDevoEncId).HasColumnName("ContDevoEncID");

                entity.Property(e => e.ContDevoEncClienteId).HasColumnName("ContDevoEncClienteID");

                entity.Property(e => e.ContDevoEncEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContDevoEncFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.ContDevoEncFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.ContDevoEncProyectoId).HasColumnName("ContDevoEncProyectoID");

                entity.Property(e => e.ContDevoEncUsuCreacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContDevoEncUsuModifica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContDevoEncCliente)
                    .WithMany(p => p.DdconteoDevoEnc)
                    .HasForeignKey(d => d.ContDevoEncClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConteoDevoEnc_DDCliente");

                entity.HasOne(d => d.ContDevoEncCotiNavigation)
                    .WithMany(p => p.DdconteoDevoEnc)
                    .HasForeignKey(d => d.ContDevoEncCoti)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConteoDevoEnc_DDCotiEncabezado");

                entity.HasOne(d => d.ContDevoEncProyecto)
                    .WithMany(p => p.DdconteoDevoEnc)
                    .HasForeignKey(d => d.ContDevoEncProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDConteoDevoEnc_DDProyecto");
            });

            modelBuilder.Entity<DdcontrolBal>(entity =>
            {
                entity.HasKey(e => e.BalId);

                entity.ToTable("DDControlBal");

                entity.HasIndex(e => new { e.BalClienteId, e.BalProyectoId, e.BalCotiId, e.BalProdId })
                    .HasName("UC_DDControlBal")
                    .IsUnique();

                entity.Property(e => e.BalId).HasColumnName("BalID");

                entity.Property(e => e.BalClienteId).HasColumnName("BalClienteID");

                entity.Property(e => e.BalCotiId).HasColumnName("BalCotiID");

                entity.Property(e => e.BalProdId)
                    .IsRequired()
                    .HasColumnName("BalProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalProyectoId).HasColumnName("BalProyectoID");

                entity.HasOne(d => d.BalCliente)
                    .WithMany(p => p.DdcontrolBal)
                    .HasForeignKey(d => d.BalClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDControlBal_DDBalanceCC");

                entity.HasOne(d => d.BalClienteNavigation)
                    .WithMany(p => p.DdcontrolBal)
                    .HasForeignKey(d => d.BalClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDControlBal_DDCliente");

                entity.HasOne(d => d.BalCoti)
                    .WithMany(p => p.DdcontrolBal)
                    .HasForeignKey(d => d.BalCotiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDControlBal_DDCotiEncabezado");

                entity.HasOne(d => d.BalProd)
                    .WithMany(p => p.DdcontrolBal)
                    .HasForeignKey(d => d.BalProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDControlBal_DDMaeInventario");

                entity.HasOne(d => d.BalProyecto)
                    .WithMany(p => p.DdcontrolBal)
                    .HasForeignKey(d => d.BalProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDControlBal_DDProyecto");
            });

            modelBuilder.Entity<DdcontrolFact>(entity =>
            {
                entity.HasKey(e => e.CtrlGenFactura);

                entity.ToTable("DDControlFact");

                entity.Property(e => e.CtrlGenFactura).HasColumnType("date");
            });

            modelBuilder.Entity<DdcotiDetalle>(entity =>
            {
                entity.HasKey(e => e.CotiDeId);

                entity.ToTable("DDCotiDetalle");

                entity.HasIndex(e => e.CotiEnDeId)
                    .HasName("ix_coti_encabezado");

                entity.Property(e => e.CotiDeId).HasColumnName("CotiDeID");

                entity.Property(e => e.CotiEnDeId).HasColumnName("CotiEnDeID");

                entity.Property(e => e.CotiPrecioProd).HasColumnType("money");

                entity.Property(e => e.CotiProdId)
                    .HasColumnName("CotiProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CotiValorProd).HasColumnType("money");

                entity.HasOne(d => d.CotiEnDe)
                    .WithMany(p => p.DdcotiDetalle)
                    .HasForeignKey(d => d.CotiEnDeId)
                    .HasConstraintName("FK_DDCotiDetalle_DDCotiEncabezado");

                entity.HasOne(d => d.CotiProd)
                    .WithMany(p => p.DdcotiDetalle)
                    .HasForeignKey(d => d.CotiProdId)
                    .HasConstraintName("FK_DDCotiDetalle_DDMaeInventario");
            });

            modelBuilder.Entity<DdcotiEncabezado>(entity =>
            {
                entity.HasKey(e => e.CotiEnId);

                entity.ToTable("DDCotiEncabezado");

                entity.Property(e => e.CotiEnId).HasColumnName("CotiEnID");

                entity.Property(e => e.CotiEnClas)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnClienteId).HasColumnName("CotiEnClienteID");

                entity.Property(e => e.CotiEnCondicionPago)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnDescripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnDescuento).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.CotiEnEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnFechaActivacion).HasColumnType("datetime");

                entity.Property(e => e.CotiEnFechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.CotiEnFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.CotiEnImpuesto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnOrden)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnPorDeposito).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.CotiEnProyectoId).HasColumnName("CotiEnProyectoID");

                entity.Property(e => e.CotiEnTipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnTransporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnUsuarioActivacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnUsuarioAnulacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnUsuarioCreacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CotiEnUsuarioVendedor)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.CotiEnCliente)
                    .WithMany(p => p.DdcotiEncabezado)
                    .HasForeignKey(d => d.CotiEnClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDCotiEncabezado_DDCliente");

                entity.HasOne(d => d.CotiEnProyecto)
                    .WithMany(p => p.DdcotiEncabezado)
                    .HasForeignKey(d => d.CotiEnProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDCotiEncabezado_DDProyecto");
            });

            modelBuilder.Entity<DddepositoBal>(entity =>
            {
                entity.HasKey(e => e.CcdepBalId);

                entity.ToTable("DDDepositoBal");

                entity.Property(e => e.CcdepBalId).HasColumnName("CCDepBalID");

                entity.Property(e => e.CcdepBalAplicado)
                    .HasColumnName("CCDepBalAplicado")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepBalCliId).HasColumnName("CCDepBalCliID");

                entity.Property(e => e.CcdepBalMonto)
                    .HasColumnName("CCDepBalMonto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepBalProyectoId).HasColumnName("CCDepBalProyectoID");

                entity.HasOne(d => d.CcdepBalCli)
                    .WithMany(p => p.DddepositoBal)
                    .HasForeignKey(d => d.CcdepBalCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDepositoBal_DDCliente");

                entity.HasOne(d => d.CcdepBalProyecto)
                    .WithMany(p => p.DddepositoBal)
                    .HasForeignKey(d => d.CcdepBalProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDepositoBal_DDProyecto");
            });

            modelBuilder.Entity<DddepositoBco>(entity =>
            {
                entity.HasKey(e => e.CcdepositoId)
                    .HasName("PK_DDDepositoCC");

                entity.ToTable("DDDepositoBco");

                entity.HasIndex(e => new { e.CcdepositoFecha, e.CcdepositoBanco })
                    .HasName("UC_DDDepositoCC")
                    .IsUnique();

                entity.Property(e => e.CcdepositoId).HasColumnName("CCDepositoID");

                entity.Property(e => e.CcdepositoBanco)
                    .HasColumnName("CCDepositoBanco")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CcdepositoCheque)
                    .HasColumnName("CCDepositoCheque")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepositoEfectivo)
                    .HasColumnName("CCDepositoEfectivo")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepositoEstatus)
                    .IsRequired()
                    .HasColumnName("CCDepositoEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcdepositoFecha)
                    .HasColumnName("CCDepositoFecha")
                    .HasColumnType("date");

                entity.Property(e => e.CcdepositoTarjeta)
                    .HasColumnName("CCDepositoTarjeta")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepositoTransferencia)
                    .HasColumnName("CCDepositoTransferencia")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CcdepositoBancoNavigation)
                    .WithMany(p => p.DddepositoBco)
                    .HasForeignKey(d => d.CcdepositoBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDepositoBco_DDBanco");
            });

            modelBuilder.Entity<DddepositoCoti>(entity =>
            {
                entity.HasKey(e => e.CcdepReciboId);

                entity.ToTable("DDDepositoCoti");

                entity.Property(e => e.CcdepReciboId).HasColumnName("CCDepReciboID");

                entity.Property(e => e.CcdepCotiCheque)
                    .HasColumnName("CCDepCotiCheque")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepCotiEfectivo)
                    .HasColumnName("CCDepCotiEfectivo")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepCotiTarjetaCredito)
                    .HasColumnName("CCDepCotiTarjetaCredito")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepCotiTransferencia)
                    .HasColumnName("CCDepCotiTransferencia")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcdepReciboCliId).HasColumnName("CCDepReciboCliID");

                entity.Property(e => e.CcdepReciboOrigId).HasColumnName("CCDepReciboOrigID");

                entity.Property(e => e.CcdepReciboProyectoId).HasColumnName("CCDepReciboProyectoID");

                entity.HasOne(d => d.CcdepReciboCli)
                    .WithMany(p => p.DddepositoCoti)
                    .HasForeignKey(d => d.CcdepReciboCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDepositoCoti_DDCliente");

                entity.HasOne(d => d.CcdepReciboOrig)
                    .WithMany(p => p.DddepositoCoti)
                    .HasForeignKey(d => d.CcdepReciboOrigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDepositoCoti_DDReciboCC");

                entity.HasOne(d => d.CcdepReciboProyecto)
                    .WithMany(p => p.DddepositoCoti)
                    .HasForeignKey(d => d.CcdepReciboProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDepositoCoti_DDProyecto");
            });

            modelBuilder.Entity<DddetalleReciboCc>(entity =>
            {
                entity.HasKey(e => e.CcdetalleReciboId);

                entity.ToTable("DDDetalleReciboCC");

                entity.Property(e => e.CcdetalleReciboId).HasColumnName("CCDetalleReciboID");

                entity.Property(e => e.CcdetalleFacturaId).HasColumnName("CCDetalleFacturaID");

                entity.Property(e => e.CcdetalleReciboAltMov)
                    .IsRequired()
                    .HasColumnName("CCDetalleReciboAltMov")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CcdetalleReciboAltSec).HasColumnName("CCDetalleReciboAltSec");

                entity.Property(e => e.CcdetalleReciboMonto)
                    .HasColumnName("CCDetalleReciboMonto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcreciboId).HasColumnName("CCReciboID");

                entity.HasOne(d => d.CcdetalleReciboAltMovNavigation)
                    .WithMany(p => p.DddetalleReciboCc)
                    .HasForeignKey(d => d.CcdetalleReciboAltMov)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDetalleReciboCC_DDMovimientoCC");

                entity.HasOne(d => d.Ccrecibo)
                    .WithMany(p => p.DddetalleReciboCc)
                    .HasForeignKey(d => d.CcreciboId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDDetalleReciboCC_DDReciboCC");
            });

            modelBuilder.Entity<DdfactDet>(entity =>
            {
                entity.HasKey(e => e.FactDetId);

                entity.ToTable("DDFactDet");

                entity.Property(e => e.FactDetId).HasColumnName("FactDetID");

                entity.Property(e => e.FactDetMonto).HasColumnType("money");

                entity.Property(e => e.FactDetProdId)
                    .HasColumnName("FactDetProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnDetId).HasColumnName("FactEnDetID");

                entity.HasOne(d => d.FactDetProd)
                    .WithMany(p => p.DdfactDet)
                    .HasForeignKey(d => d.FactDetProdId)
                    .HasConstraintName("FK_DDFactDet_DDMaeInventario");

                entity.HasOne(d => d.FactEnDet)
                    .WithMany(p => p.DdfactDet)
                    .HasForeignKey(d => d.FactEnDetId)
                    .HasConstraintName("FK_DDFactDet_DDFactEnc");
            });

            modelBuilder.Entity<DdfactEnc>(entity =>
            {
                entity.HasKey(e => e.FactEnId);

                entity.ToTable("DDFactEnc");

                entity.Property(e => e.FactEnId).HasColumnName("FactEnID");

                entity.Property(e => e.FactEnClase)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnClienteId).HasColumnName("FactEnClienteID");

                entity.Property(e => e.FactEnConduceId).HasColumnName("FactEnConduceID");

                entity.Property(e => e.FactEnCotiId).HasColumnName("FactEnCotiID");

                entity.Property(e => e.FactEnDescGlobal).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.FactEnEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnFechaConteo).HasColumnType("datetime");

                entity.Property(e => e.FactEnFechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FactEnFechaValida).HasColumnType("datetime");

                entity.Property(e => e.FactEnImpuesto).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.FactEnNumeroComprobante)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnOrden)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnProyectoId).HasColumnName("FactEnProyectoID");

                entity.Property(e => e.FactEnTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnTipoComprobante).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.FactEnUsuarioCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FactEnVendedor)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.FactEnCliente)
                    .WithMany(p => p.DdfactEnc)
                    .HasForeignKey(d => d.FactEnClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDFactEnc_DDCliente");

                entity.HasOne(d => d.FactEnConduce)
                    .WithMany(p => p.DdfactEnc)
                    .HasForeignKey(d => d.FactEnConduceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDFactEnc_DDConDespEnc");

                entity.HasOne(d => d.FactEnCoti)
                    .WithMany(p => p.DdfactEnc)
                    .HasForeignKey(d => d.FactEnCotiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDFactEnc_DDCotiEncabezado");

                entity.HasOne(d => d.FactEnProyecto)
                    .WithMany(p => p.DdfactEnc)
                    .HasForeignKey(d => d.FactEnProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDFactEnc_DDProyecto");

                entity.HasOne(d => d.FactEnTipoComprobanteNavigation)
                    .WithMany(p => p.DdfactEnc)
                    .HasForeignKey(d => d.FactEnTipoComprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDFactEnc_DDTipComprobante");
            });

            modelBuilder.Entity<DdingInvDet>(entity =>
            {
                entity.HasKey(e => e.TraDeIngId);

                entity.ToTable("DDIngInvDet");

                entity.Property(e => e.TraDeIngId).HasColumnName("TraDeIngID");

                entity.Property(e => e.TraDeCosto).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.TraDeEnIngId).HasColumnName("TraDeEnIngID");

                entity.Property(e => e.TraDeProdId)
                    .IsRequired()
                    .HasColumnName("TraDeProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.TraDeEnIng)
                    .WithMany(p => p.DdingInvDet)
                    .HasForeignKey(d => d.TraDeEnIngId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDIngInvDet_DDIngInvEnc");

                entity.HasOne(d => d.TraDeProd)
                    .WithMany(p => p.DdingInvDet)
                    .HasForeignKey(d => d.TraDeProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDIngInvDet_DDMaeInventario");
            });

            modelBuilder.Entity<DdingInvEnc>(entity =>
            {
                entity.HasKey(e => e.TraEnIngId);

                entity.ToTable("DDIngInvEnc");

                entity.Property(e => e.TraEnIngId).HasColumnName("TraEnIngID");

                entity.Property(e => e.TraEnCodAgeId).HasColumnName("TraEnCodAgeID");

                entity.Property(e => e.TraEnCodSupId).HasColumnName("TraEnCodSupID");

                entity.Property(e => e.TraEnFactAge)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraEnFecCrea).HasColumnType("datetime");

                entity.Property(e => e.TraEnFecFactAge).HasColumnType("date");

                entity.Property(e => e.TraEnNumEmbarque)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraEnOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraEnUsuCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.TraEnCodAge)
                    .WithMany(p => p.DdingInvEncTraEnCodAge)
                    .HasForeignKey(d => d.TraEnCodAgeId)
                    .HasConstraintName("FK_DDIngInvEnc_DDSuplidor1");

                entity.HasOne(d => d.TraEnCodSup)
                    .WithMany(p => p.DdingInvEncTraEnCodSup)
                    .HasForeignKey(d => d.TraEnCodSupId)
                    .HasConstraintName("FK_DDIngInvEnc_DDSuplidor");
            });

            modelBuilder.Entity<DdmaeInventario>(entity =>
            {
                entity.HasKey(e => e.MinvId);

                entity.ToTable("DDMaeInventario");

                entity.Property(e => e.MinvId)
                    .HasColumnName("MInvID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MinvClase).HasColumnName("MInvClase");

                entity.Property(e => e.MinvCostoAdquisicion)
                    .HasColumnName("MInvCostoAdquisicion")
                    .HasColumnType("money");

                entity.Property(e => e.MinvDescripcion)
                    .HasColumnName("MInvDescripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MinvEstatus)
                    .HasColumnName("MInvEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MinvFechaCreacion)
                    .HasColumnName("MInvFechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinvFechaModifica)
                    .HasColumnName("MInvFechaModifica")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinvPeso)
                    .HasColumnName("MInvPeso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinvPiezaServicio)
                    .HasColumnName("MInvPiezaServicio")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MinvPrecioRentaDia)
                    .HasColumnName("MInvPrecioRentaDia")
                    .HasColumnType("money");

                entity.Property(e => e.MinvPrecioRentaFija)
                    .HasColumnName("MInvPrecioRentaFija")
                    .HasColumnType("money");

                entity.Property(e => e.MinvPrecioVenta)
                    .HasColumnName("MInvPrecioVenta")
                    .HasColumnType("money");

                entity.Property(e => e.MinvRutaImagen)
                    .HasColumnName("MInvRutaImagen")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.MinvTotalIngresado).HasColumnName("MInvTotalIngresado");

                entity.Property(e => e.MinvTotalOrdenado).HasColumnName("MInvTotalOrdenado");

                entity.Property(e => e.MinvTotalRentado).HasColumnName("MInvTotalRentado");

                entity.Property(e => e.MinvUnidad)
                    .HasColumnName("MInvUnidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinvUsuarioCreacion)
                    .HasColumnName("MInvUsuarioCreacion")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MinvUsuarioModifica)
                    .HasColumnName("MInvUsuarioModifica")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MinvClaseNavigation)
                    .WithMany(p => p.DdmaeInventario)
                    .HasForeignKey(d => d.MinvClase)
                    .HasConstraintName("FK_DDMaeInventario_DDClaseProd");
            });

            modelBuilder.Entity<DdmovimientoCc>(entity =>
            {
                entity.HasKey(e => e.CcmovId);

                entity.ToTable("DDMovimientoCC");

                entity.Property(e => e.CcmovId)
                    .HasColumnName("CCMovID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CcmovDesc)
                    .IsRequired()
                    .HasColumnName("CCMovDesc")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CcmovEstatus)
                    .IsRequired()
                    .HasColumnName("CCMovEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcmovFechaCrea)
                    .HasColumnName("CCMovFechaCrea")
                    .HasColumnType("datetime");

                entity.Property(e => e.CcmovUsuCrea)
                    .IsRequired()
                    .HasColumnName("CCMovUsuCrea")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdpagoNoAp>(entity =>
            {
                entity.HasKey(e => e.CcpagoId);

                entity.ToTable("DDPagoNoAp");

                entity.Property(e => e.CcpagoId).HasColumnName("CCPagoID");

                entity.Property(e => e.CcpagoCheque)
                    .HasColumnName("CCPagoCheque")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcpagoClienteId).HasColumnName("CCPagoClienteID");

                entity.Property(e => e.CcpagoEfectivo)
                    .HasColumnName("CCPagoEfectivo")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcpagoFecha)
                    .HasColumnName("CCPagoFecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.CcpagoProyectoId).HasColumnName("CCPagoProyectoID");

                entity.Property(e => e.CcpagoReciboId).HasColumnName("CCPagoReciboID");

                entity.Property(e => e.CcpagoTarjetaCredito)
                    .HasColumnName("CCPagoTarjetaCredito")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcpagoTransferencia)
                    .HasColumnName("CCPagoTransferencia")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CcpagoCliente)
                    .WithMany(p => p.DdpagoNoAp)
                    .HasForeignKey(d => d.CcpagoClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDPagoNoAp_DDCliente1");

                entity.HasOne(d => d.CcpagoProyecto)
                    .WithMany(p => p.DdpagoNoAp)
                    .HasForeignKey(d => d.CcpagoProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDPagoNoAp_DDProyecto");

                entity.HasOne(d => d.CcpagoRecibo)
                    .WithMany(p => p.DdpagoNoAp)
                    .HasForeignKey(d => d.CcpagoReciboId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDPagoNoAp_DDReciboCC");
            });

            modelBuilder.Entity<Ddproyecto>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("DDProyecto");

                entity.Property(e => e.ProId)
                    .HasColumnName("ProID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProClienteId).HasColumnName("ProClienteID");

                entity.Property(e => e.ProContacto)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProCorreoContacto)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProDescuentoGlobal).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.ProDireccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.ProFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.ProFechaProyecto).HasColumnType("date");

                entity.Property(e => e.ProNombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProTelContacto).HasMaxLength(10);

                entity.Property(e => e.ProUsuarioCreacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProUsuarioModifica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProVendedorId)
                    .IsRequired()
                    .HasColumnName("ProVendedorID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProCliente)
                    .WithMany(p => p.Ddproyecto)
                    .HasForeignKey(d => d.ProClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDProyecto_DDCliente1");
            });

            modelBuilder.Entity<DdreciboCc>(entity =>
            {
                entity.HasKey(e => e.CcreciboId);

                entity.ToTable("DDReciboCC");

                entity.Property(e => e.CcreciboId).HasColumnName("CCReciboID");

                entity.Property(e => e.CcreciboCheque)
                    .HasColumnName("CCReciboCheque")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcreciboCliId).HasColumnName("CCReciboCliID");

                entity.Property(e => e.CcreciboConcepto)
                    .IsRequired()
                    .HasColumnName("CCReciboConcepto")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CcreciboEfectivo)
                    .HasColumnName("CCReciboEfectivo")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcreciboEstatus)
                    .IsRequired()
                    .HasColumnName("CCReciboEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CcreciboFecCrea)
                    .HasColumnName("CCReciboFecCrea")
                    .HasColumnType("datetime");

                entity.Property(e => e.CcreciboFecMod)
                    .HasColumnName("CCReciboFecMod")
                    .HasColumnType("datetime");

                entity.Property(e => e.CcreciboFecha)
                    .HasColumnName("CCReciboFecha")
                    .HasColumnType("date");

                entity.Property(e => e.CcreciboTarjetaCredito)
                    .HasColumnName("CCReciboTarjetaCredito")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcreciboTransferencia)
                    .HasColumnName("CCReciboTransferencia")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CcreciboUsuCrea)
                    .IsRequired()
                    .HasColumnName("CCReciboUsuCrea")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CcreciboUsuMod)
                    .IsRequired()
                    .HasColumnName("CCReciboUsuMod")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.CcreciboCli)
                    .WithMany(p => p.DdreciboCc)
                    .HasForeignKey(d => d.CcreciboCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDReciboCC_DDCliente");
            });

            modelBuilder.Entity<Ddsuplidor>(entity =>
            {
                entity.HasKey(e => e.SuplidorId);

                entity.ToTable("DDSuplidor");

                entity.Property(e => e.SuplidorId).HasColumnName("SuplidorID");

                entity.Property(e => e.SuplidorContacto)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorContactoTelCel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorCorreoElec)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorDescripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorDireccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.SuplidorFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.SuplidorPais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorTelFax1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorTelOficina1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorTelOficina2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SuplidorUsuRegistro)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdtipComprobante>(entity =>
            {
                entity.HasKey(e => e.TcompId);

                entity.ToTable("DDTipComprobante");

                entity.Property(e => e.TcompId)
                    .HasColumnName("TCompID")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TcompCantidadCtrl)
                    .HasColumnName("TCompCantidadCtrl")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TcompDescripcion)
                    .HasColumnName("TCompDescripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TcompEstatus)
                    .HasColumnName("TCompEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcompFechaCrea)
                    .HasColumnName("TCompFechaCrea")
                    .HasColumnType("datetime");

                entity.Property(e => e.TcompFechaModi)
                    .HasColumnName("TCompFechaModi")
                    .HasColumnType("datetime");

                entity.Property(e => e.TcompFechaValida)
                    .HasColumnName("TCompFechaValida")
                    .HasColumnType("datetime");

                entity.Property(e => e.TcompImpuesto)
                    .HasColumnName("TCompImpuesto")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcompNumerador)
                    .HasColumnName("TCompNumerador")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.TcompSecuenciaFin)
                    .HasColumnName("TCompSecuenciaFin")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.TcompSecuenciaIni)
                    .HasColumnName("TCompSecuenciaIni")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.TcompSerie)
                    .HasColumnName("TCompSerie")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcompUsuCrea)
                    .HasColumnName("TCompUsuCrea")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TcompUsuModi)
                    .HasColumnName("TCompUsuModi")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdtipoTraAju>(entity =>
            {
                entity.HasKey(e => e.TraTipoId);

                entity.ToTable("DDTipoTraAju");

                entity.Property(e => e.TraTipoId).HasColumnName("TraTipoID");

                entity.Property(e => e.TraTipoAjuste)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TraTipoDesc)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.TraTipoEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TraTipoFechaCrea).HasColumnType("datetime");

                entity.Property(e => e.TratipoUsuCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DdtraAjuInv>(entity =>
            {
                entity.HasKey(e => e.TraAjuId);

                entity.ToTable("DDTraAjuInv");

                entity.Property(e => e.TraAjuId).HasColumnName("TraAjuID");

                entity.Property(e => e.TraAjuCodId).HasColumnName("TraAjuCodID");

                entity.Property(e => e.TraAjuFechaCrea).HasColumnType("datetime");

                entity.Property(e => e.TraAjuProdId)
                    .HasColumnName("TraAjuProdID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TraAjuUsuCrea)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.TraAjuCod)
                    .WithMany(p => p.DdtraAjuInv)
                    .HasForeignKey(d => d.TraAjuCodId)
                    .HasConstraintName("FK_DDTraAjuInv_DDTipoTraAju");

                entity.HasOne(d => d.TraAjuProd)
                    .WithMany(p => p.DdtraAjuInv)
                    .HasForeignKey(d => d.TraAjuProdId)
                    .HasConstraintName("FK_DDTraAjuInv_DDMaeInventario");
            });
        }
    }
}
