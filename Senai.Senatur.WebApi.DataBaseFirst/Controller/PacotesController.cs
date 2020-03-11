using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.DataBaseFirst.Domains;
using Senai.Senatur.WebApi.DataBaseFirst.Interfaces;
using Senai.Senatur.WebApi.DataBaseFirst.Repositories;

namespace Senai.Senatur.WebApi.DataBaseFirst.Controller
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacotesRepository _pacoteRepository;

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public PacotesController()
        {
            _pacoteRepository = new PacotesRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_pacoteRepository.Listar());
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Pacotes novoPacote)
        {
            // Faz a chamada para o método
            _pacoteRepository.Cadastrar(novoPacote);

            // Retorna um status code
            return StatusCode(201);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Pacotes pacoteAtualizado)
        {
            // Faz a chamada para o método
            _pacoteRepository.Atualizar(id, pacoteAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pacoteRepository.Deletar(id);

            return StatusCode(204);


        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_pacoteRepository.BuscarPorId(id));
        }


    }
}