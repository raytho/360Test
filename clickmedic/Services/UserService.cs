using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using clickmedic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace clickmedic.Services
{
    public static class UserService
    {
        public static HttpStatusCode statusCode { get; set; }
        public static MedicclickDBContext context = new MedicclickDBContext();

        public static UserDataResponse GetAllUsers()
        {
            UserDataResponse usuariosRespuesta;

            var usuarios = context.Usuarios.ToList();
            context.Alergias.ToList();

            if (usuarios != null)
            {
                usuariosRespuesta = new UserDataResponse()
                {
                    codigo = 200,
                    mensaje = "Operacion completada",
                    payload = usuarios
                };
            }
            else
            {
                usuariosRespuesta = new UserDataResponse()
                {
                    codigo = 500,
                    mensaje = "Error al buscar informacion",
                    payload = null
                };
            }
            return usuariosRespuesta;
        }

        public static UserDataResponse GetUserId(int id)
        {
            var usuarioRespuesta = new UserDataResponse();
            context.Alergias.ToList();
            var usuario = context.Usuarios.Where(u => u.UsuarioId == id).ToList();
            if(usuario != null)
            {
                usuarioRespuesta = new UserDataResponse()
                {
                    codigo = 200,
                    mensaje = "Operacion completada",
                    payload = usuario
                };
            }
            else
            {
                usuarioRespuesta = new UserDataResponse()
                {
                    codigo = 400,
                    mensaje = "No se encontro información",
                    payload = null
                };
            }
            return usuarioRespuesta;
        }
    }
}
