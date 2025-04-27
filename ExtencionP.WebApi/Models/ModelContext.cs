using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExtencionP.WebApi.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<TcAnonima> TcAnonimas { get; set; } = null!;
        public virtual DbSet<TcCalificacion> TcCalificacions { get; set; } = null!;
        public virtual DbSet<TcEstatusDenuncium> TcEstatusDenuncia { get; set; } = null!;
        public virtual DbSet<TcPersonaJuridica> TcPersonaJuridicas { get; set; } = null!;
        public virtual DbSet<TcTermino> TcTerminos { get; set; } = null!;
        public virtual DbSet<TcTipoDenuncium> TcTipoDenuncia { get; set; } = null!;
        public virtual DbSet<TmDenuncia> TmDenuncias { get; set; } = null!;
        public virtual DbSet<VDirectorio> VDirectorios { get; set; } = null!;
        public virtual DbSet<VEmplea> VEmpleas { get; set; } = null!;
        public virtual DbSet<VFinancieroEmpleado> VFinancieroEmpleados { get; set; } = null!;
        public virtual DbSet<VRolsnidum> VRolsnida { get; set; } = null!;
        public virtual DbSet<VSistemasnidum> VSistemasnida { get; set; } = null!;
        public virtual DbSet<VTcAbreviaturaProfesion> VTcAbreviaturaProfesions { get; set; } = null!;
        public virtual DbSet<VTcAsueto> VTcAsuetos { get; set; } = null!;
        public virtual DbSet<VTcComunidadLenguistica> VTcComunidadLenguisticas { get; set; } = null!;
        public virtual DbSet<VTcDepartamento> VTcDepartamentos { get; set; } = null!;
        public virtual DbSet<VTcDepartamento1> VTcDepartamentos1 { get; set; } = null!;
        public virtual DbSet<VTcDepartamentosPg> VTcDepartamentosPgs { get; set; } = null!;
        public virtual DbSet<VTcIdioma> VTcIdiomas { get; set; } = null!;
        public virtual DbSet<VTcIdioma1> VTcIdiomas1 { get; set; } = null!;
        public virtual DbSet<VTcMunicipio> VTcMunicipios { get; set; } = null!;
        public virtual DbSet<VTcMunicipio1> VTcMunicipios1 { get; set; } = null!;
        public virtual DbSet<VTcMunicipiosPg> VTcMunicipiosPgs { get; set; } = null!;
        public virtual DbSet<VTcPai> VTcPais { get; set; } = null!;
        public virtual DbSet<VTcPaise> VTcPaises { get; set; } = null!;
        public virtual DbSet<VTcPueblo> VTcPueblos { get; set; } = null!;
        public virtual DbSet<VTcSexo> VTcSexos { get; set; } = null!;
        public virtual DbSet<VTcUnidadAdministrativa> VTcUnidadAdministrativas { get; set; } = null!;
        public virtual DbSet<VTmEmpleado> VTmEmpleados { get; set; } = null!;
        public virtual DbSet<VTmEndpoint> VTmEndpoints { get; set; } = null!;
        public virtual DbSet<VTmFirmasRegistrada> VTmFirmasRegistradas { get; set; } = null!;
        public virtual DbSet<VTmParametro> VTmParametros { get; set; } = null!;
        public virtual DbSet<VTmUsuariosFirma> VTmUsuariosFirmas { get; set; } = null!;
        public virtual DbSet<VUsuariorolsnidum> VUsuariorolsnida { get; set; } = null!;
        public virtual DbSet<VUsuariosAplicacione> VUsuariosAplicaciones { get; set; } = null!;
        public virtual DbSet<VUsuariosnidum> VUsuariosnida { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseOracle("User Id=NEWSICODA;Password=n3wsic0da;Data Source=192.168.2.11:1521/MARN;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("NEWSICODA");

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.ToTable("CATEGORIA");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<TcAnonima>(entity =>
            {
                entity.HasKey(e => e.IdAnonima)
                    .HasName("SYS_C0058709");

                entity.ToTable("TC_ANONIMA");

                entity.Property(e => e.IdAnonima)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ANONIMA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<TcCalificacion>(entity =>
            {
                entity.HasKey(e => e.IdCalificacion)
                    .HasName("SYS_C0058727");

                entity.ToTable("TC_CALIFICACION");

                entity.Property(e => e.IdCalificacion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_CALIFICACION");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<TcEstatusDenuncium>(entity =>
            {
                entity.HasKey(e => e.IdEstatusDenu)
                    .HasName("SYS_C0058705");

                entity.ToTable("TC_ESTATUS_DENUNCIA");

                entity.Property(e => e.IdEstatusDenu)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ESTATUS_DENU");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<TcPersonaJuridica>(entity =>
            {
                entity.HasKey(e => e.IdPersonaJ)
                    .HasName("SYS_C0058840");

                entity.ToTable("TC_PERSONA_JURIDICA");

                entity.Property(e => e.IdPersonaJ)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_PERSONA_J");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<TcTermino>(entity =>
            {
                entity.HasKey(e => e.IdTerminos)
                    .HasName("SYS_C0058711");

                entity.ToTable("TC_TERMINOS");

                entity.Property(e => e.IdTerminos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_TERMINOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<TcTipoDenuncium>(entity =>
            {
                entity.HasKey(e => e.IdTipoDenuncia)
                    .HasName("SYS_C0058704");

                entity.ToTable("TC_TIPO_DENUNCIA");

                entity.Property(e => e.IdTipoDenuncia)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_TIPO_DENUNCIA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .HasColumnName("TITULO");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<TmDenuncia>(entity =>
            {
                entity.HasKey(e => e.IdSicoda)
                    .HasName("SYS_C0058710");

                entity.ToTable("TM_DENUNCIAS");

                entity.Property(e => e.IdSicoda)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_SICODA");

                entity.Property(e => e.Asunto)
                    .HasMaxLength(1000)
                    .HasColumnName("ASUNTO");

                entity.Property(e => e.ComunidadDdo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMUNIDAD_DDO");

                entity.Property(e => e.ComunidadLinguistica)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMUNIDAD_LINGUISTICA");

                entity.Property(e => e.CorreoDdo)
                    .HasMaxLength(150)
                    .HasColumnName("CORREO_DDO");

                entity.Property(e => e.CorreoDenunciante)
                    .HasMaxLength(150)
                    .HasColumnName("CORREO_DENUNCIANTE");

                entity.Property(e => e.DireccionDdo)
                    .HasMaxLength(1000)
                    .HasColumnName("DIRECCION_DDO");

                entity.Property(e => e.DireccionDenunciante)
                    .HasMaxLength(1000)
                    .HasColumnName("DIRECCION_DENUNCIANTE");

                entity.Property(e => e.DpiDdo)
                    .HasMaxLength(13)
                    .HasColumnName("DPI_DDO");

                entity.Property(e => e.DpiDenunciante)
                    .HasMaxLength(13)
                    .HasColumnName("DPI_DENUNCIANTE");

                entity.Property(e => e.Edad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EDAD");

                entity.Property(e => e.EmpresaDdo)
                    .HasMaxLength(100)
                    .HasColumnName("EMPRESA_DDO");

                entity.Property(e => e.Etnia)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ETNIA");

                entity.Property(e => e.EtniaDdo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ETNIA_DDO");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaToken)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_TOKEN");

                entity.Property(e => e.FormaIngreso)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FORMA_INGRESO");

                entity.Property(e => e.IdAnonima)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ANONIMA");

                entity.Property(e => e.IdCalificacion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_CALIFICACION");

                entity.Property(e => e.IdDenuncia)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_DENUNCIA");

                entity.Property(e => e.IdDepartamentoDdo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_DEPARTAMENTO_DDO");

                entity.Property(e => e.IdDepartamentoDenunciante)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_DEPARTAMENTO_DENUNCIANTE");

                entity.Property(e => e.IdEstatusDenu)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ESTATUS_DENU");

                entity.Property(e => e.IdExpediente)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_EXPEDIENTE");

                entity.Property(e => e.IdMunicipioDdo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_MUNICIPIO_DDO");

                entity.Property(e => e.IdMunicipioDenunciante)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_MUNICIPIO_DENUNCIANTE");

                entity.Property(e => e.IdPersona)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_PERSONA");

                entity.Property(e => e.IdTipoDenuncia)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_TIPO_DENUNCIA");

                entity.Property(e => e.MotivoDenegacion)
                    .HasMaxLength(1000)
                    .HasColumnName("MOTIVO_DENEGACION");

                entity.Property(e => e.NoDenuncia)
                    .HasMaxLength(100)
                    .HasColumnName("NO_DENUNCIA");

                entity.Property(e => e.NoExpediente)
                    .HasMaxLength(100)
                    .HasColumnName("NO_EXPEDIENTE");

                entity.Property(e => e.Otros)
                    .HasMaxLength(300)
                    .HasColumnName("OTROS");

                entity.Property(e => e.PeriodoDenuncia)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERIODO_DENUNCIA");

                entity.Property(e => e.PeriodoExpediente)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERIODO_EXPEDIENTE");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .HasColumnName("PRIMER_APELLIDO");

                entity.Property(e => e.PrimerApellidoDdo)
                    .HasMaxLength(50)
                    .HasColumnName("PRIMER_APELLIDO_DDO");

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(50)
                    .HasColumnName("PRIMER_NOMBRE");

                entity.Property(e => e.PrimerNombreDdo)
                    .HasMaxLength(50)
                    .HasColumnName("PRIMER_NOMBRE_DDO");

                entity.Property(e => e.ReferenciaDireccionDdo)
                    .HasMaxLength(1000)
                    .HasColumnName("REFERENCIA_DIRECCION_DDO");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .HasColumnName("SEGUNDO_APELLIDO");

                entity.Property(e => e.SegundoApellidoDdo)
                    .HasMaxLength(50)
                    .HasColumnName("SEGUNDO_APELLIDO_DDO");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(50)
                    .HasColumnName("SEGUNDO_NOMBRE");

                entity.Property(e => e.SegundoNombreDdo)
                    .HasMaxLength(50)
                    .HasColumnName("SEGUNDO_NOMBRE_DDO");

                entity.Property(e => e.Sexo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEXO");

                entity.Property(e => e.SexoDdo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEXO_DDO");

                entity.Property(e => e.TelefonoDdo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TELEFONO_DDO");

                entity.Property(e => e.TelefonoDenunciante)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TELEFONO_DENUNCIANTE");

                entity.Property(e => e.Terminos)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TERMINOS");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .HasColumnName("TOKEN");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_ACTUALIZA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(150)
                    .HasColumnName("USUARIO_INGRESO");

                entity.HasOne(d => d.IdAnonimaNavigation)
                    .WithMany(p => p.TmDenuncia)
                    .HasForeignKey(d => d.IdAnonima)
                    .HasConstraintName("FK_ANONIMA");

                entity.HasOne(d => d.IdCalificacionNavigation)
                    .WithMany(p => p.TmDenuncia)
                    .HasForeignKey(d => d.IdCalificacion)
                    .HasConstraintName("FK_CALIFICACION");

                entity.HasOne(d => d.IdEstatusDenuNavigation)
                    .WithMany(p => p.TmDenuncia)
                    .HasForeignKey(d => d.IdEstatusDenu)
                    .HasConstraintName("FK_ESTATUS_DENUNCIA");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.TmDenuncia)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_PERSONAJ");

                entity.HasOne(d => d.IdTipoDenunciaNavigation)
                    .WithMany(p => p.TmDenuncia)
                    .HasForeignKey(d => d.IdTipoDenuncia)
                    .HasConstraintName("FK_TIPO_DENUNCIA");

                entity.HasOne(d => d.TerminosNavigation)
                    .WithMany(p => p.TmDenuncia)
                    .HasForeignKey(d => d.Terminos)
                    .HasConstraintName("FK_TERMINOS");
            });

            modelBuilder.Entity<VDirectorio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DIRECTORIO");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTAMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Extension)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("EXTENSION");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(188)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<VEmplea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EMPLEA");

                entity.Property(e => e.Celular)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.CodigoEvaluacion)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_EVALUACION");

                entity.Property(e => e.CodigoPuesto)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_PUESTO");

                entity.Property(e => e.CodigoUnidadAdministrativa)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTAMENTO");

                entity.Property(e => e.DireccionElectronica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ELECTRONICA");

                entity.Property(e => e.Dpi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DPI");

                entity.Property(e => e.Edad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EDAD");

                entity.Property(e => e.Emailpersonal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILPERSONAL");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS");

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXTENSION");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ALTA");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_NAC");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(188)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasColumnName("PUESTO");

                entity.Property(e => e.Renglon)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RENGLON");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SEXO");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUELDO");
            });

            modelBuilder.Entity<VFinancieroEmpleado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINANCIERO_EMPLEADOS");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.CodigoEvaluacion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CODIGO_EVALUACION");

                entity.Property(e => e.CodigoPuesto)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_PUESTO");

                entity.Property(e => e.CodigoUnidadAdministrativa)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTAMENTO");

                entity.Property(e => e.DireccionElectronica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ELECTRONICA");

                entity.Property(e => e.Dpi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DPI");

                entity.Property(e => e.Edad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(123)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasColumnName("PUESTO");

                entity.Property(e => e.Renglon)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RENGLON");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SEXO");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUELDO");
            });

            modelBuilder.Entity<VRolsnidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ROLSNIDA");

                entity.Property(e => e.Descripcionrol)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCIONROL");

                entity.Property(e => e.Idrol)
                    .HasPrecision(2)
                    .HasColumnName("IDROL");

                entity.Property(e => e.Idsistema)
                    .HasPrecision(2)
                    .HasColumnName("IDSISTEMA");

                entity.Property(e => e.Nombrerol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREROL");
            });

            modelBuilder.Entity<VSistemasnidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SISTEMASNIDA");

                entity.Property(e => e.Idsistema)
                    .HasPrecision(4)
                    .HasColumnName("IDSISTEMA");

                entity.Property(e => e.Nombresistema)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRESISTEMA");
            });

            modelBuilder.Entity<VTcAbreviaturaProfesion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_ABREVIATURA_PROFESION");

                entity.Property(e => e.Abreviatura)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ABREVIATURA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcAsueto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_ASUETO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Fecha)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Periodo)
                    .HasPrecision(4)
                    .HasColumnName("PERIODO");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcComunidadLenguistica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_COMUNIDAD_LENGUISTICA");

                entity.Property(e => e.CodComunidadLenguistica)
                    .HasPrecision(6)
                    .HasColumnName("COD_COMUNIDAD_LENGUISTICA");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreComunidad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_COMUNIDAD");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcDepartamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_DEPARTAMENTOS");

                entity.Property(e => e.CodigoDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_DEPARTAMENTO");

                entity.Property(e => e.CodigoRegion)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_REGION");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_DEPARTAMENTO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcDepartamento1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_DEPARTAMENTO");

                entity.Property(e => e.CodDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("COD_DEPARTAMENTO");

                entity.Property(e => e.CodPais)
                    .HasPrecision(6)
                    .HasColumnName("COD_PAIS");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_DEPARTAMENTO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcDepartamentosPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_DEPARTAMENTOS_PG");

                entity.Property(e => e.CodigoDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_DEPARTAMENTO");

                entity.Property(e => e.CodigoRegion)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_REGION");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_DEPARTAMENTO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcIdioma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_IDIOMAS");

                entity.Property(e => e.CodigoIdioma)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_IDIOMA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcIdioma1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_IDIOMA");

                entity.Property(e => e.CodIdioma)
                    .HasPrecision(6)
                    .HasColumnName("COD_IDIOMA");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreIdioma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_IDIOMA");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcMunicipio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_MUNICIPIOS");

                entity.Property(e => e.CodigoDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_DEPARTAMENTO");

                entity.Property(e => e.CodigoMunicipio)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_MUNICIPIO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MUNICIPIO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcMunicipio1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_MUNICIPIO");

                entity.Property(e => e.CodDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("COD_DEPARTAMENTO");

                entity.Property(e => e.CodMunicipio)
                    .HasPrecision(6)
                    .HasColumnName("COD_MUNICIPIO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MUNICIPIO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcMunicipiosPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_MUNICIPIOS_PG");

                entity.Property(e => e.CodigoDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_DEPARTAMENTO");

                entity.Property(e => e.CodigoMunicipio)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_MUNICIPIO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreMunicipio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MUNICIPIO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcPai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_PAIS");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Grupo)
                    .HasPrecision(3)
                    .HasColumnName("GRUPO");

                entity.Property(e => e.Pais)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PAIS");

                entity.Property(e => e.Prefijo)
                    .HasPrecision(3)
                    .HasColumnName("PREFIJO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcPaise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_PAISES");

                entity.Property(e => e.CodPais)
                    .HasPrecision(6)
                    .HasColumnName("COD_PAIS");

                entity.Property(e => e.CodigoAlfa2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_ALFA2");

                entity.Property(e => e.CodigoAlfa3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_ALFA3");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreComun)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_COMUN");

                entity.Property(e => e.NombreIso)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_ISO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcPueblo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_PUEBLO");

                entity.Property(e => e.CodPueblo)
                    .HasPrecision(6)
                    .HasColumnName("COD_PUEBLO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombrePueblo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PUEBLO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcSexo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_SEXO");

                entity.Property(e => e.CodSexo)
                    .HasPrecision(6)
                    .HasColumnName("COD_SEXO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.NombreSexo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_SEXO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTcUnidadAdministrativa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TC_UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.Actividad)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVIDAD");

                entity.Property(e => e.CodigoDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_DEPARTAMENTO");

                entity.Property(e => e.CodigoMunicipio)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_MUNICIPIO");

                entity.Property(e => e.CodigoUnidadAdministrativa)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Hpertenece)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HPERTENECE");

                entity.Property(e => e.Periodo)
                    .HasPrecision(4)
                    .HasColumnName("PERIODO");

                entity.Property(e => e.Pertenece)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERTENECE");

                entity.Property(e => e.Programa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA");

                entity.Property(e => e.Region)
                    .HasPrecision(6)
                    .HasColumnName("REGION");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTmEmpleado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TM_EMPLEADOS");

                entity.Property(e => e.Bono662000)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BONO_662000");

                entity.Property(e => e.BonoAntiguedad)
                    .HasColumnType("NUMBER(10,2)")
                    .HasColumnName("BONO_ANTIGUEDAD");

                entity.Property(e => e.BonoCompPersonal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BONO_COMP_PERSONAL");

                entity.Property(e => e.BonoMarn)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BONO_MARN");

                entity.Property(e => e.BonoProfesional)
                    .HasColumnType("NUMBER(10,2)")
                    .HasColumnName("BONO_PROFESIONAL");

                entity.Property(e => e.BonoSalarioMinimo)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BONO_SALARIO_MINIMO");

                entity.Property(e => e.BonoSecretaria)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BONO_SECRETARIA");

                entity.Property(e => e.Categoria)
                    .HasPrecision(1)
                    .HasColumnName("CATEGORIA");

                entity.Property(e => e.CodigoAutorizaVac)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_AUTORIZA_VAC");

                entity.Property(e => e.CodigoBanco)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_BANCO");

                entity.Property(e => e.CodigoColegio)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_COLEGIO");

                entity.Property(e => e.CodigoComision)
                    .HasPrecision(8)
                    .HasColumnName("CODIGO_COMISION");

                entity.Property(e => e.CodigoDoctorado)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_DOCTORADO");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.CodigoEvaluacion)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_EVALUACION");

                entity.Property(e => e.CodigoMaestria)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_MAESTRIA");

                entity.Property(e => e.CodigoNivel)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_NIVEL");

                entity.Property(e => e.CodigoNmedio)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_NMEDIO");

                entity.Property(e => e.CodigoProfesion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PROFESION");

                entity.Property(e => e.CodigoPuesto)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_PUESTO");

                entity.Property(e => e.CodigoUltgrado)
                    .HasPrecision(4)
                    .HasColumnName("CODIGO_ULTGRADO");

                entity.Property(e => e.CodigoUnidadAdministrativa)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.CodigoUnidadPartida)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_UNIDAD_PARTIDA");

                entity.Property(e => e.CodigoUniversidad)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_UNIVERSIDAD");

                entity.Property(e => e.CodigoUniversidadDoctorado)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_UNIVERSIDAD_DOCTORADO");

                entity.Property(e => e.CodigoUniversidadMaestria)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_UNIVERSIDAD_MAESTRIA");

                entity.Property(e => e.CodigoUniversidadUltimogrado)
                    .HasPrecision(2)
                    .HasColumnName("CODIGO_UNIVERSIDAD_ULTIMOGRADO");

                entity.Property(e => e.ColegiadoVigente)
                    .HasColumnType("DATE")
                    .HasColumnName("COLEGIADO_VIGENTE");

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CUENTA_BANCARIA");

                entity.Property(e => e.Dependencia)
                    .HasPrecision(6)
                    .HasColumnName("DEPENDENCIA");

                entity.Property(e => e.DeptoAsignado)
                    .HasPrecision(4)
                    .HasColumnName("DEPTO_ASIGNADO");

                entity.Property(e => e.DeptoCedula)
                    .HasPrecision(4)
                    .HasColumnName("DEPTO_CEDULA");

                entity.Property(e => e.DeptoDireccion)
                    .HasPrecision(4)
                    .HasColumnName("DEPTO_DIRECCION");

                entity.Property(e => e.DeptoNacimiento)
                    .HasPrecision(4)
                    .HasColumnName("DEPTO_NACIMIENTO");

                entity.Property(e => e.DireccionCasa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_CASA");

                entity.Property(e => e.DireccionElectronica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ELECTRONICA");

                entity.Property(e => e.DireccionElectronicaPersonal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_ELECTRONICA_PERSONAL");

                entity.Property(e => e.Dpi)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DPI");

                entity.Property(e => e.EdadHijos)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EDAD_HIJOS");

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO_CIVIL");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS");

                entity.Property(e => e.EstudiosActuales)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ESTUDIOS_ACTUALES");

                entity.Property(e => e.Etnia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ETNIA");

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXTENSION");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ALTA");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_BAJA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_NAC");

                entity.Property(e => e.Fotografia)
                    .HasColumnType("BLOB")
                    .HasColumnName("FOTOGRAFIA");

                entity.Property(e => e.Fotografia2)
                    .HasColumnType("BLOB")
                    .HasColumnName("FOTOGRAFIA2");

                entity.Property(e => e.Fotografia3)
                    .HasColumnType("BLOB")
                    .HasColumnName("FOTOGRAFIA3");

                entity.Property(e => e.GastosRepresentacion)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GASTOS_REPRESENTACION");

                entity.Property(e => e.InformacionFamiliares)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("INFORMACION_FAMILIARES");

                entity.Property(e => e.MunicipioAsignado)
                    .HasPrecision(4)
                    .HasColumnName("MUNICIPIO_ASIGNADO");

                entity.Property(e => e.MunicipioCedula)
                    .HasPrecision(4)
                    .HasColumnName("MUNICIPIO_CEDULA");

                entity.Property(e => e.MunicipioDireccion)
                    .HasPrecision(4)
                    .HasColumnName("MUNICIPIO_DIRECCION");

                entity.Property(e => e.MunicipioNacimiento)
                    .HasPrecision(4)
                    .HasColumnName("MUNICIPIO_NACIMIENTO");

                entity.Property(e => e.NoColegiado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NO_COLEGIADO");

                entity.Property(e => e.NoEmpadronamiento)
                    .HasPrecision(10)
                    .HasColumnName("NO_EMPADRONAMIENTO");

                entity.Property(e => e.NoOrden)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NO_ORDEN");

                entity.Property(e => e.NoPartida)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NO_PARTIDA");

                entity.Property(e => e.NoRegistro)
                    .HasPrecision(7)
                    .HasColumnName("NO_REGISTRO");

                entity.Property(e => e.NumeroContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_CONTRATO");

                entity.Property(e => e.NumeroHijos)
                    .HasPrecision(2)
                    .HasColumnName("NUMERO_HIJOS");

                entity.Property(e => e.NumeroIgss)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_IGSS");

                entity.Property(e => e.NumeroProbidad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PROBIDAD");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.PartidaCompleta)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PARTIDA_COMPLETA");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRIMER_APELLIDO");

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRIMER_NOMBRE");

                entity.Property(e => e.Programa)
                    .HasPrecision(2)
                    .HasColumnName("PROGRAMA");

                entity.Property(e => e.PuestoOnsec)
                    .HasPrecision(4)
                    .HasColumnName("PUESTO_ONSEC");

                entity.Property(e => e.Renglon)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RENGLON");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDO_APELLIDO");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDO_NOMBRE");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEXO");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUELDO");

                entity.Property(e => e.TelefonoCasa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_CASA");

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_CELULAR");

                entity.Property(e => e.TercerApellido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TERCER_APELLIDO");

                entity.Property(e => e.TercerNombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TERCER_NOMBRE");

                entity.Property(e => e.TipoCalculo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CALCULO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioDb)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_DB");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");

                entity.Property(e => e.Zona)
                    .HasPrecision(2)
                    .HasColumnName("ZONA");
            });

            modelBuilder.Entity<VTmEndpoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TM_ENDPOINT");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENDPOINT");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.IdEstado)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ESTADO");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTmFirmasRegistrada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TM_FIRMAS_REGISTRADAS");

                entity.Property(e => e.EstadoRecibido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO_RECIBIDO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaFirma)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIRMA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.PatchArchivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PATCH_ARCHIVO");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioFirma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_FIRMA");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTmParametro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TM_PARAMETROS");

                entity.Property(e => e.BillingPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_PASSWORD");

                entity.Property(e => e.BillingUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_USERNAME");

                entity.Property(e => e.Env)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENV");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FORMAT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.IdEstado)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ESTADO");

                entity.Property(e => e.ImgSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMG_SIZE");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Npage)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NPAGE");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("POSITION");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VTmUsuariosFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TM_USUARIOS_FIRMA");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_ACTUALIZACION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.IdEstado)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_ESTADO");

                entity.Property(e => e.NitEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIT_EMPLEADO");

                entity.Property(e => e.PasswordFea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD_FEA");

                entity.Property(e => e.PathFirma)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PATH_FIRMA");

                entity.Property(e => e.PinFea)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PIN_FEA");

                entity.Property(e => e.UserFea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_FEA");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ACTUALIZACION");

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_INGRESO");
            });

            modelBuilder.Entity<VUsuariorolsnidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_USUARIOROLSNIDA");

                entity.Property(e => e.Idrol)
                    .HasPrecision(4)
                    .HasColumnName("IDROL");

                entity.Property(e => e.Idsistema)
                    .HasPrecision(4)
                    .HasColumnName("IDSISTEMA");

                entity.Property(e => e.Idusuario)
                    .HasPrecision(6)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.MantAnualFechaIngreso)
                    .HasColumnType("DATE")
                    .HasColumnName("MANT_ANUAL_FECHA_INGRESO");

                entity.Property(e => e.MantAnualUsuarioIngreso)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANT_ANUAL_USUARIO_INGRESO");

                entity.Property(e => e.MantenimientoAnual)
                    .HasPrecision(1)
                    .HasColumnName("MANTENIMIENTO_ANUAL");

                entity.Property(e => e.TempRol)
                    .HasPrecision(1)
                    .HasColumnName("TEMP_ROL");
            });

            modelBuilder.Entity<VUsuariosAplicacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_USUARIOS_APLICACIONES");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.CodigoUnidadAdministrativa)
                    .HasPrecision(6)
                    .HasColumnName("CODIGO_UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.DescripcionRol)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_ROL");

                entity.Property(e => e.IdRol)
                    .HasPrecision(2)
                    .HasColumnName("ID_ROL");

                entity.Property(e => e.IdSistema)
                    .HasPrecision(4)
                    .HasColumnName("ID_SISTEMA");

                entity.Property(e => e.IdUsuario)
                    .HasPrecision(6)
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(185)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_COMPLETO");

                entity.Property(e => e.NombreSistema)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_SISTEMA");

                entity.Property(e => e.Rol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ROL");

                entity.Property(e => e.UnidadAdministrativa)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_ADMINISTRATIVA");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<VUsuariosnidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_USUARIOSNIDA");

                entity.Property(e => e.Bloqueado)
                    .HasPrecision(1)
                    .HasColumnName("BLOQUEADO");

                entity.Property(e => e.Cambiarclave)
                    .HasPrecision(1)
                    .HasColumnName("CAMBIARCLAVE");

                entity.Property(e => e.Clave)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CLAVE");

                entity.Property(e => e.ClaveFea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLAVE_FEA");

                entity.Property(e => e.CodigoVerificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_VERIFICACION");

                entity.Property(e => e.DirectorGestion)
                    .HasPrecision(1)
                    .HasColumnName("DIRECTOR_GESTION");

                entity.Property(e => e.EstadoCodigo)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ESTADO_CODIGO");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHACREACION");

                entity.Property(e => e.Firma)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.FirmaElectronica)
                    .HasPrecision(1)
                    .HasColumnName("FIRMA_ELECTRONICA");

                entity.Property(e => e.Idrol)
                    .HasPrecision(2)
                    .HasColumnName("IDROL");

                entity.Property(e => e.Idsistema)
                    .HasPrecision(2)
                    .HasColumnName("IDSISTEMA");

                entity.Property(e => e.Idusuario)
                    .HasPrecision(6)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Nombreusuario)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREUSUARIO");

                entity.Property(e => e.PasswordFea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD_FEA");

                entity.Property(e => e.PinFea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PIN_FEA");

                entity.Property(e => e.UltimoCambioClave)
                    .HasColumnType("DATE")
                    .HasColumnName("ULTIMO_CAMBIO_CLAVE");

                entity.Property(e => e.UsernameFea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME_FEA");

                entity.Property(e => e.UsuarioFea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_FEA");

                entity.Property(e => e.VersionFea)
                    .HasPrecision(1)
                    .HasColumnName("VERSION_FEA");
            });

            modelBuilder.HasSequence("CATEGORIA_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
