using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clickmedic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace clickmedic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioMedicoController : ControllerBase
    {
        private readonly ILogger<UsuarioMedicoController> _logger;

        public UsuarioMedicoController(ILogger<UsuarioMedicoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            using (var context = new MediclickContext())
            {
                return context.Usuarios.ToList();
            }
        }
    }
}