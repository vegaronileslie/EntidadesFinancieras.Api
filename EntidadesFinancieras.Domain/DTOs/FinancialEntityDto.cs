using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFinancieras.Domain.DTOs
{
    public class FinancialEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Website { get; set; }
        public int ClassificationTypeId { get; set; }
        public string ClassificationTypeName { get; set; } = string.Empty;
    }
}
