using GPS.Domain.VO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Repository.Context
{
    public class GpsDbContext : DbContext
    {
        public DbSet<EmpresaVO> Empresas { get; set; }
        public DbSet<AtividadePrincipalVO> atividade_principais { get; set; }
        public DbSet<AtividadesSecundariasVO> atividades_secundarias { get; set; }
        public DbSet<BillingVO> billing { get; set; }
        public DbSet<QsaVO> qsas { get; set; }

        public GpsDbContext(DbContextOptions<GpsDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GPS;Data Source=DESKTECH-DK;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

    }
}
