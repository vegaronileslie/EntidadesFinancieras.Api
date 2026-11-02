using EntidadesFinancieras.Domain.Entities;

namespace EntidadesFinancieras.Domain.Interfaces
{
    public interface IClassificationTypeRepository
    {
        Task<IEnumerable<ClassificationType>> GetAllAsync();
        Task<ClassificationType?> GetByIdAsync(int id);

    }
}
