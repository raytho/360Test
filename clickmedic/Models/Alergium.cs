using System;
using System.Collections.Generic;

#nullable disable

namespace clickmedic.Models
{
    public partial class Alergium
    {
        public int AlergiaId { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Medicament { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
