using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFinancieras.Domain.Entities
{
    public class ClassificationType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<FinancialEntity> FinancialEntities { get; set; } = new List<FinancialEntity>();  
    }
}
