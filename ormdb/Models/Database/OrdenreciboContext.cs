using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ormdb.Models.Database;

public partial class OrdenreciboContext : DbContext
{
    public OrdenreciboContext()
    {
    }

    public OrdenreciboContext(DbContextOptions<OrdenreciboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CentrosDistribucion> CentrosDistribucions { get; set; }

    public virtual DbSet<EstandaresCxP> EstandaresCxPs { get; set; }

    public virtual DbSet<OrdenRecibo> OrdenRecibos { get; set; }

    public virtual DbSet<OrdenReciboEdit> OrdenReciboEdits { get; set; }

    public virtual DbSet<OrdenReciboProducto> OrdenReciboProductos { get; set; }

    public virtual DbSet<OrdenReciboProductosRevisado> OrdenReciboProductosRevisados { get; set; }

    public virtual DbSet<OrdenReciboRevisada> OrdenReciboRevisadas { get; set; }

    public virtual DbSet<PerfomanceRecibo> PerfomanceRecibos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<SapEtlOrdenRecibo> SapEtlOrdenRecibos { get; set; }

    public virtual DbSet<TransactionActionsOrder> TransactionActionsOrders { get; set; }

    //mapping de la base de datos del procedure
    public virtual DbSet<DTO.DtoORProductosRevisados> Resultado { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User= sa; Password= Ctek2314;Persist Security Info=False;Initial Catalog=ordenrecibo;Data Source=(local)\\A22; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CentrosDistribucion>(entity =>
        {
            entity.HasKey(e => e.IdCentro).HasName("PK__CentrosD__20ACC13417DA9D8C");

            entity.ToTable("CentrosDistribucion");

            entity.Property(e => e.Centro)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.CodCentro)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Region)
                .HasMaxLength(800)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstandaresCxP>(entity =>
        {
            entity.HasKey(e => e.IdCxp).HasName("PK__Estandar__0FA75B65B5B6782A");

            entity.ToTable("EstandaresCxP", tb => tb.HasTrigger("TranStandardCxP"));

            entity.Property(e => e.Codigo).IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechCarga).HasColumnType("datetime");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenRecibo>(entity =>
        {
            entity.HasKey(e => e.IdOrdenRecibo).HasName("PK__OrdenRec__56C1D04156F2C748");

            entity.ToTable("OrdenRecibo");

            entity.Property(e => e.Cedis)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCedis)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaExtraccion).HasColumnType("datetime");
            entity.Property(e => e.FechaOrdenRecibo).HasColumnType("datetime");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumOrdenCompra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumOrdenRecibo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Reg)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.RucProveedor)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenReciboEdit>(entity =>
        {
            entity.HasKey(e => e.IdOrdenReciboEdit).HasName("PK__OrdenRec__EBE33862E3F9A450");

            entity.ToTable("OrdenReciboEdit", tb => tb.HasTrigger("TranOrderEditSync"));

            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRevision).HasColumnType("datetime");
            entity.Property(e => e.FechaSync).HasColumnType("datetime");
            entity.Property(e => e.GestionadoPor)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.JsonOrder).IsUnicode(false);
            entity.Property(e => e.NumOrdenRecibo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Procesada)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Reg)
                .HasMaxLength(800)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenReciboProducto>(entity =>
        {
            entity.HasKey(e => e.IdOrdenReciboProducto).HasName("PK__OrdenRec__92AD209697B68ED0");

            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eanproducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EANProducto");
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaExtraccion).HasColumnType("datetime");
            entity.Property(e => e.FechaFabricacion).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.LoteProducto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumOrdenRecibo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Reg)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.SkuProducto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenReciboProductosRevisado>(entity =>
        {
            entity.HasKey(e => e.IdOrdenReciboProductoRevisado).HasName("PK__OrdenRec__ABD1E1BBBAC9FFAB");

            entity.Property(e => e.Averias).IsUnicode(false);
            entity.Property(e => e.Cedis)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCedis)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioRechazo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto).IsUnicode(false);
            entity.Property(e => e.Eanproducto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EANProducto");
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaFabricacion).HasColumnType("datetime");
            entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRechazo).HasColumnType("datetime");
            entity.Property(e => e.FechaRevision).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.GestionadoPor)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LiberadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProducto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NumOrdenRecibo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RechazadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reg)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.RucProveedor)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SkuProducto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenReciboRevisada>(entity =>
        {
            entity.HasKey(e => e.IdOrdenReciboRevisada).HasName("PK__OrdenRec__8702FE603F8965F2");

            entity.ToTable(tb => tb.HasTrigger("TranOrderSync"));

            entity.Property(e => e.Cedis)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCedis)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioRechazo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRechazo).HasColumnType("datetime");
            entity.Property(e => e.FechaRevision).HasColumnType("datetime");
            entity.Property(e => e.FechaSync).HasColumnType("datetime");
            entity.Property(e => e.GestionadoPor)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.JsonHoraInicio).IsUnicode(false);
            entity.Property(e => e.JsonInspecciones).IsUnicode(false);
            entity.Property(e => e.JsonNovedades).IsUnicode(false);
            entity.Property(e => e.JsonOrder).IsUnicode(false);
            entity.Property(e => e.LiberadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumOrdenRecibo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Procesada)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RechazadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reg)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.RucProveedor)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerfomanceRecibo>(entity =>
        {
            entity.HasKey(e => e.IdPerfomanceRecibo).HasName("PK__Perfoman__DA4CEFB0159B0433");

            entity.ToTable("PerfomanceRecibo");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__E8B631AF59D003B0");

            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaExtraccion).HasColumnType("datetime");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RucProveedor)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SapEtlOrdenRecibo>(entity =>
        {
            entity.HasKey(e => e.IdSecuencial).HasName("PK__SapEtlOr__7366E580F426D176");

            entity.ToTable("SapEtlOrdenRecibo");

            entity.Property(e => e.Centro)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCentro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eanproducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EANProducto");
            entity.Property(e => e.FechaExtraccion).HasColumnType("datetime");
            entity.Property(e => e.FechaOrden).HasColumnType("datetime");
            entity.Property(e => e.OrdenCompra)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RucProveedor)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SkuProducto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransactionActionsOrder>(entity =>
        {
            entity.HasKey(e => e.IdTransactionActionsOrder).HasName("PK__Transact__119E37E8A59E21A3");

            entity.ToTable(tb => tb.HasTrigger("TranOrderActions"));

            entity.Property(e => e.Accion).IsUnicode(false);
            entity.Property(e => e.DatoAccion1).IsUnicode(false);
            entity.Property(e => e.DatoAccion2).IsUnicode(false);
            entity.Property(e => e.DatoAccion3).IsUnicode(false);
            entity.Property(e => e.DatoAccion4).IsUnicode(false);
            entity.Property(e => e.DatoAccion5).IsUnicode(false);
            entity.Property(e => e.DatoAccion6).IsUnicode(false);
            entity.Property(e => e.DatoAccion7).IsUnicode(false);
            entity.Property(e => e.DatoAccion8).IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.Tabla).IsUnicode(false);
            entity.Property(e => e.UsuarioIngreso)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
