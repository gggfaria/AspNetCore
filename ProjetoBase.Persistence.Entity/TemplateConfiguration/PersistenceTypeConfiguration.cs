using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoBase.Persistence.Entity.TemplateConfiguration
{
    public abstract class PersistenceTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {

        public PersistenceTypeConfiguration(EntityTypeBuilder<TEntity> builder)
        {
            Configure(builder);
        }
        public abstract void ConfiguraNomeTabela(EntityTypeBuilder<TEntity> builder);
        public abstract void ConfiguraCampos(EntityTypeBuilder<TEntity> builder);
        public abstract void ConfiguraChavePrimaria(EntityTypeBuilder<TEntity> builder);
        public abstract void ConfiguraRelacionamentos(EntityTypeBuilder<TEntity> builder);

        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            ConfiguraNomeTabela(builder);
            ConfiguraCampos(builder);
            ConfiguraChavePrimaria(builder);
            ConfiguraRelacionamentos(builder);
        }
    }
}

