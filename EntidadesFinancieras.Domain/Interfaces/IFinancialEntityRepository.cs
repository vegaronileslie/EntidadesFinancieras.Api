using EntidadesFinancieras.Domain.Entities;

namespace EntidadesFinancieras.Domain.Interfaces
{
    public interface IFinancialEntityRepository
    {
        Task<IEnumerable<FinancialEntity>> GetAllAsync();
        Task<FinancialEntity?> GetByIdAsync(int id);
    }
}
