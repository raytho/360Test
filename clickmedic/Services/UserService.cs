using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using clickmedic.Models;
using Microsoft.AspNetCore.Mvc;

namespace clickmedic.Services
{
    public static class UserService
    {
        public static HttpStatusCode statusCode { get; set; }

        public static DatosUsuarioRepuesta GetAllUsers()
        {
            var context = new MedicclickDBContext();

            var usuarios = context.Usuarios.ToList();
            var listaAlergias = context.Alergias.ToList();

            var usuariosRespuesta = new DatosUsuarioRepuesta()
            {
                codigo = 200,
                mensaje = "Operacion completada",
                payload = usuarios
            };
            return usuariosRespuesta;
        }
    }
}
