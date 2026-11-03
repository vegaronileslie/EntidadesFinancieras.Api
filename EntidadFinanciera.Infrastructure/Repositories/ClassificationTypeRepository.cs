using EntidadesFinancieras.Domain.Entities;
using EntidadesFinancieras.Domain.Interfaces;
using EntidadFinanciera.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera.Infrastructure.Repositories
{
    public class ClassificationTypeRepository : IClassificationTypeRepository
    {
        private readonly AppDbContext _context;
        public ClassificationTypeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ClassificationType>> GetAllAsync()
        {
            return await _context.ClassificationTypes
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .ToListAsync();
        }

        public async Task<ClassificationType?> GetByIdAsync(int id)
        {
            return await _context.ClassificationTypes
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
