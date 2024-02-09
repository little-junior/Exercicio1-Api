using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImovelAPI.Domain.DTOs
{
    public class ImovelDTO
    {
        [Required(ErrorMessage = "O campo 'area' é obrigatorio")]
        public double Area { get; set; }

        [Required(ErrorMessage = "O campo 'tipo' é obrigatorio")]
        [MaxLength(30, ErrorMessage = "O campo 'tipo' deve ter no máximo 30 caracteres")]
        public string Tipo { get; set; }
    }
}
