using GPS.Domain.VO;
using GPS.Repository.Context;
using GPS.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GPS.Repository
{
    public class GpsRepository : IGpsRepository
    {
        private readonly GpsDbContext _gpsDbContext;
        public GpsRepository(GpsDbContext gpsDbContext)
        {
            _gpsDbContext = gpsDbContext;
            _gpsDbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public void Add<T>(T entity) where T : class
        {
            _gpsDbContext.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _gpsDbContext.Update(entity);
        }
        public async Task<bool> SaveChancesAsync()
        {
            return (await _gpsDbContext.SaveChangesAsync()) > 0;
        }
        public EmpresaVO GeyByCNPJ(string cnpj)
        {
            IQueryable<EmpresaVO> query = _gpsDbContext.Empresas
             .Include(p => p.atividade_principais)
             .Include(s => s.atividades_secundarias)
             .Include(b => b.billing).AsNoTracking()
             .Include(q => q.qsas)
             .Where(c => c.cnpj == cnpj);

            query = query.AsNoTracking()
            .OrderByDescending(c => c.cnpj);

            return query.FirstOrDefault();
        }
    }
}
