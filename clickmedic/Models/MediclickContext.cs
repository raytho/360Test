using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace clickmedic.Models
{
    public partial class MediclickContext : DbContext
    {
        public MediclickContext()
        {
        }

        public MediclickContext(DbContextOptions<MediclickContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alergium> Alergia { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=mediclick.database.windows.net;Database=Mediclick;User Id=raymundosp; Password=.Somoshiroystacy");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alergium>(entity =>
            {
                entity.HasKey(e => e.AlergiaId)
                    .HasName("PK__alergia__3E09484FC76C2C9A");

                entity.ToTable("alergia");

                entity.Property(e => e.AlergiaId).HasColumnName("alergia_id");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_alta");

                entity.Property(e => e.Medicament)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("medicament");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Alergia)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__alergia__usuario__5EBF139D");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.NoExpediente)
                    .HasName("PK__medicUse__A31078AC9AA302F2");

                entity.ToTable("usuario");

                entity.Property(e => e.NoExpediente).HasColumnName("no_expediente");

                entity.Property(e => e.FechaUltimaConsulta)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ultima_consulta");

                entity.Property(e => e.TipoSangre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipo_sangre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
