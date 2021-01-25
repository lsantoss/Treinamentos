using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Livraria.Api.Entidades;

namespace Livraria.Api.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Livraria;Data Source=SANTOS-PC\\SQLEXPRESS;";
        private readonly DynamicParameters _parametros = new DynamicParameters();

        [HttpPost]
        [Route("v1/livros")]
        public object Inserir([FromBody] Livro livro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    _parametros.Add("Nome", livro.Nome, DbType.String);
                    _parametros.Add("Autor", livro.Autor, DbType.String);
                    _parametros.Add("Edicao", livro.Edicao, DbType.Int32);
                    _parametros.Add("Isbn", livro.Isbn, DbType.String);
                    _parametros.Add("Imagem", livro.Imagem, DbType.String);

                    string sql = @"INSERT INTO Livro (Nome, Autor, Edicao, Isbn, Imagem) VALUES (@Nome, @Autor, @Edicao, @Isbn, @imagem); SELECT SCOPE_IDENTITY();";

                    livro.Id = connection.ExecuteScalar<long>(sql, _parametros);
                }

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

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    _parametros.Add("Id", livro.Id, DbType.Int64);
                    _parametros.Add("Nome", livro.Nome, DbType.String);
                    _parametros.Add("Autor", livro.Autor, DbType.String);
                    _parametros.Add("Edicao", livro.Edicao, DbType.Int32);
                    _parametros.Add("Isbn", livro.Isbn, DbType.String);
                    _parametros.Add("Imagem", livro.Imagem, DbType.String);

                    string sql = @"UPDATE Livro SET Nome=@Nome, Autor=@Autor, Edicao=@Edicao, Isbn=@Isbn, Imagem=@Imagem where Id=@Id";

                    connection.Execute(sql, _parametros);
                }

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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    _parametros.Add("Id", id, DbType.Int64);

                    string sql = @"DELETE FROM Livro WHERE Id=@Id";

                    connection.Execute(sql, _parametros);
                }

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
                List<Livro> livros;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Livro ORDER BY Nome";

                    livros = connection.Query<Livro>(sql).ToList();
                }

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
                Livro livro;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    _parametros.Add("Id", id, DbType.Int64);

                    string sql = "SELECT * FROM Livro WHERE Id=@Id";

                    livro = connection.Query<Livro>(sql, _parametros).FirstOrDefault();
                }

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