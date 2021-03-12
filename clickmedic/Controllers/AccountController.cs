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
    [Route("demo/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly string _connectionString;


        public AccountController(IConfiguration configuration, ILogger<AccountController> logger)
        {
            _logger = logger;
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public UserDataResponse Get()
        {
            var usuarios = UserService.GetAllUsers();
            return usuarios;
        }

        [HttpGet("{id}")]
        [Route("demo/v1/[controller]/{id}")]
        public UserDataResponse GetUser(int id)
        {
            var usuarios = UserService.GetUserId(id);
            return usuarios;
        }
    }
}