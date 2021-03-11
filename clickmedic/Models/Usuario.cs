using System;
using System.Collections.Generic;

namespace clickmedic.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int NumeroExpediente { get; set; }
        public DateTime FechaUltimaConsulta { get; set; }
        public string TipoSangre { get; set; }
        public IEnumerable<Alergia> alergias { get; set; }
    }
}
