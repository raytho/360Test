using System;
using System.Collections.Generic;

namespace clickmedic.Models
{
    public class UserDataResponse
    {
        public int codigo { get; set; }
        public string mensaje { get; set; }
        public IEnumerable<Usuario> payload { get; set; }
    }
}
