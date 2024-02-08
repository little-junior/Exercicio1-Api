using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImovelAPI.Domain.DTOs
{
    public class ImovelDTO
    {
        [JsonRequired]
        public double Area { get; set; }
        [JsonRequired]
        public string Tipo { get; set; }
    }
}
