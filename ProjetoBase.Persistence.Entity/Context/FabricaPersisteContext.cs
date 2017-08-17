using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ProjetoBase.Persistence.Entity.Context
{
    class FabricaPersisteContext : IDesignTimeDbContextFactory<ProjetoBaseCoreDbContext>
    {
        private const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjetoBaseCore;Integrated Security=True;user id=Xapps; password=XappsDev;";

        public ProjetoBaseCoreDbContext CreateDbContext(string[] args)
        {
            var construtor = new DbContextOptionsBuilder<ProjetoBaseCoreDbContext>();
            construtor.UseSqlServer(CONNECTIONSTRING);
            return new ProjetoBaseCoreDbContext(construtor.Options);
        }
    }
}
