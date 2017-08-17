using ProjetoBase.Persistence.Entity.TemplateConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBase.Domain.Entities;

namespace ProjetoBase.Persistence.Entity.Configuration
{
    public class PessoaConfiguration : PersistenceTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration(EntityTypeBuilder<Pessoa> builder)
            :base (builder)
        {

        }
        public override void ConfiguraCampos(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(p => p.PessoaId)
                .HasColumnName("PES_ID");

            builder.Property(p => p.Nome)
                .HasColumnName("PES_NOME")
                .HasMaxLength(200);

            builder.Property(p => p.CPF)
                .HasColumnName("PES_CPF")
                .HasMaxLength(11);
        }

        public override void ConfiguraChavePrimaria(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.PessoaId);

            builder.HasIndex(p => new { p.CPF });
        }

        public override void ConfiguraNomeTabela(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOAS");
        }

        public override void ConfiguraRelacionamentos(EntityTypeBuilder<Pessoa> builder)
        {
            //builder.HasMany(p => p.);

            //builder.HasOne(p => p.)
            //    .WithMany(p => p.)
            //    .HasForeignKey(p => p.);
        }
    }
}
