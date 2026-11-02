using EntidadesFinancieras.Domain.Entities;
using EntidadesFinancieras.Domain.Interfaces;
using EntidadFinanciera.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EntidadFinanciera.Infrastructure.Repositories
{
    public class FinancialEntityRepository : IFinancialEntityRepository
    {
        private readonly AppDbContext _context;
        public FinancialEntityRepository(AppDbContext context)
        {
            _context = context;   
        }
        public async Task<IEnumerable<FinancialEntity>> GetAllAsync()
        {
            return await _context.FinancialEntities
                .AsNoTracking() 
                .Include(e => e.ClassificationType)
                .OrderBy(e => e.Name)
                .ToListAsync();
        }

        public async Task<FinancialEntity?> GetByIdAsync(int id)
        {
            return await _context.FinancialEntities
                .AsNoTracking()
                .Include(e => e.ClassificationType)
                .FirstOrDefaultAsync(e => e.Id == id);  
        }
    }
}
