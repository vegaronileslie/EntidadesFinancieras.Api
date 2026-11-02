using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFinancieras.Domain.Entities
{
    public class FinancialEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Website { get; set; }
        public int ClassificationTypeId { get; set; }
        public ClassificationType ClassificationType { get; set; } = null!;
    }
}
