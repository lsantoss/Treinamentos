using LivrariaAPI.Domain.Base;
using LivrariaAPI.Domain.Commands.Livro.Input;
using LivrariaAPI.Domain.Commands.Livro.Output;
using LivrariaAPI.Domain.Handlers;
using LivrariaAPI.Domain.Query;
using LivrariaAPI.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LivrariaAPI.Api.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("Livro")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _repositorio;
        private readonly LivroHandler _handler;

        public LivroController(ILivroRepository repositorio, LivroHandler handler)
        {
            _repositorio = repositorio;
            _handler = handler;
        }

        /// <summary>
        /// Health Check
        /// </summary>        
        /// <remarks><h2><b>Afere a resposta deste contexto do serviço.</b></h2></remarks>
        /// <response code="200">OK Request</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("v1/HealthCheck")]
        public ActionResult<string> EmpresaHealthCheck()
        {
            try
            {
                return "Livraria API - Livro OK";
            }
            catch (Exception e)
            {
                //HttpContext.RiseError(e);
                return e.Message;
            }
        }

        /// <summary>
        /// Livros
        /// </summary>                
        /// <remarks><h2><b>Lista todos os Livros.</b></h2></remarks>
        /// <response code="200">OK Request</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("v1/Livros")]
        public IEnumerable<LivroQueryResult> Livros()
        {
            return _repositorio.Listar();
        }

        /// <summary>
        /// Livro
        /// </summary>                
        /// <remarks><h2><b>Consulta o Livro.</b></h2></remarks>
        /// <param name="Id">Parâmetro requerido Id do Livro</param>
        /// <response code="200">OK Request</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("v1/Livro/{Id:int}")]
        public LivroQueryResult Livro(int Id)
        {
            return _repositorio.ObterPorId(Id);
        }

        /// <summary>
        /// Incluir Livro 
        /// </summary>                
        /// <remarks><h2><b>Incluir novo Livro na base de dados.</b></h2></remarks>
        /// <param name="command">Parâmetro requerido command de Insert</param>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("v1/LivroNovo")]
        public ICommandResult LivroNovo([FromBody] AdicionarLivroCommand command)
        {
            var result = (AdicionarLivroCommandResult)_handler.Handle(command);
            return result;
        }

        /// <summary>
        /// Alterar Livro
        /// </summary>        
        /// <remarks><h2><b>Alterar Livro na base de dados.</b></h2></remarks>        
        /// <param name="command">Parâmetro requerido command de Update</param>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut]
        [Route("v1/LivroAlterar")]
        public ICommandResult LivroAlterar([FromBody] AtualizarLivroCommand command)
        {
            var result = (AtualizarLivroCommandResult)_handler.Handle(command);
            return result;
        }

        /// <summary>
        /// Excluir Livro
        /// </summary>                
        /// <remarks><h2><b>Excluir Livro na base de dados.</b></h2></remarks>
        /// <param name="command">Parâmetro requerido command de Delete</param>
        /// <response code="200">OK Request</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete]
        [Route("v1/LivroExcluir")]
        public ICommandResult LivroExcluir([FromBody] ApagarLivroCommand command)
        {
            var result = (ApagarLivroCommandResult)_handler.Handle(command);
            return result;
        }
    }
}