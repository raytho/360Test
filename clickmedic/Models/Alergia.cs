using System;
using System.ComponentModel.DataAnnotations;

namespace clickmedic.Models
{
    public class Alergia
    {
        public int AlergiaId { get; set; }
        public string Nombre { get; set; }
        public string FechaAlta { get; set; }
        public string Medicamento { get; set; }
    }
}
