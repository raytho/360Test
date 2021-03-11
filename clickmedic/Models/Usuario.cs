using System;
using System.Collections.Generic;

#nullable disable

namespace clickmedic.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Alergia = new HashSet<Alergium>();
        }

        public int NoExpediente { get; set; }
        public DateTime? FechaUltimaConsulta { get; set; }
        public string TipoSangre { get; set; }

        public virtual ICollection<Alergium> Alergia { get; set; }
    }
}
