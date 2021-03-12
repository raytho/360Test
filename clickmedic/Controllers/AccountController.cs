using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clickmedic.Models;
using clickmedic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace clickmedic.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet("/demo/v1/account")]
        public UserDataResponse Get()
        {
            var usuarios = UserService.GetAllUsers();
            return usuarios;
        }

        [HttpGet("/demo/v1/account/{id}/record")]
        public UserDataResponse GetUserById(int id)
        {
            var usuarios = UserService.GetUserId(id);
            return usuarios;
        }
    }
}