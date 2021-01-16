using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApiSimples.Entidades;
using WebApiSimples.Interfaces;

namespace WebApiSimples.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpPost]
        [Route("v1/livros")]
        public object Inserir([FromBody] Livro livro)
        {
            try
            {
                livro = _livroRepository.Inserir(livro);

                object retorno = new
                {
                    Sucesso = true,
                    Mensagem = "Livro inserido com sucesso",
                    Dados = livro
                };

                return retorno;
            }
            catch (Exception ex)
            {
                object retorno = new
                {
                    Sucesso = false,
                    Mensagem = "Erro ao inserir o livro",
                    Dados = ex.Message
                };

                return retorno;
            }
        }

        [HttpPut]
        [Route("v1/livros/{id}")]
        public object Alterar(long id, [FromBody] Livro livro)
        {
            try
            {
                livro.Id = id;

                _livroRepository.Alterar(livro);

                object retorno = new
                {
                    Sucesso = true,
                    Mensagem = "Livro alterado com sucesso",
                    Dados = livro
                };

                return retorno;
            }
            catch (Exception ex)
            {
                object retorno = new
                {
                    Sucesso = false,
                    Mensagem = "Erro ao alterar o livro",
                    Dados = ex.Message
                };

                return retorno;
            }
        }

        [HttpDelete]
        [Route("v1/livros/{id}")]
        public object Apagar(long id)
        {
            try
            {
                _livroRepository.Deletar(id);

                object retorno = new
                {
                    Sucesso = true,
                    Mensagem = "Livro apagado com sucesso",
                    Dados = id
                };

                return retorno;
            }
            catch (Exception ex)
            {
                object retorno = new
                {
                    Sucesso = false,
                    Mensagem = "Erro ao apagar o livro",
                    Dados = ex.Message
                };

                return retorno;
            }
        }

        [HttpGet]
        [Route("v1/livros")]
        public object Listar()
        {
            try
            {
                List<Livro> livros = _livroRepository.Listar();


                string mensagem = livros.Count == 0 ? "Nenhum livro cadastrado" : "Livros obtidos com sucesso";

                object retorno = new
                {
                    Sucesso = true,
                    Mensagem = mensagem,
                    Dados = livros
                };

                return retorno;
            }
            catch (Exception ex)
            {
                object retorno = new
                {
                    Sucesso = false,
                    Mensagem = "Erro ao obter os livros",
                    Dados = ex.Message
                };

                return retorno;
            }
        }

        [HttpGet]
        [Route("v1/livros/{id}")]
        public object ObterPorId(long id)
        {
            try
            {
                var livro = _livroRepository.ObterPorId(id);

                string mensagem = livro == null ? "Livro não cadastrado" : "Livro obtido com sucesso";

                object retorno = new
                {
                    Sucesso = true,
                    Mensagem = mensagem,
                    Dados = livro
                };

                return retorno;
            }
            catch (Exception ex)
            {
                object retorno = new
                {
                    Sucesso = false,
                    Mensagem = "Erro ao obter o livro",
                    Dados = ex.Message
                };

                return retorno;
            }
        }
    }
}