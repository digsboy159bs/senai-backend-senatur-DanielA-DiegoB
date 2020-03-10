using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.DataBaseFirst.Interfaces;
using Senai.Senatur.WebApi.DataBaseFirst.Repositories;

namespace Senai.Senatur.WebApi.DataBaseFirst.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tipoUsuarioRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public TiposUsuarioController()
        {
            _tipoUsuarioRepository = new TiposUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Faz a chamada para o método .Listar()
            // Retorna a lista e um status code 200 - Ok
            return Ok(_tipoUsuarioRepository.Listar());
        }
    }
}