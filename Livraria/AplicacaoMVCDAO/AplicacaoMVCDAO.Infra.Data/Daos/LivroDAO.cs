using AplicacaoMVCDAO.Infra.Data.DataContexts;
using AplicacaoMVCDAO.Infra.Data.Intefaces;
using AplicacaoMVCDAO.Infra.Data.Models.Livros;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AplicacaoMVCDAO.Infra.Data.Daos
{
    public class LivroDAO : ILivroDAO
    {
        private readonly DynamicParameters _parametros = new DynamicParameters();
        private readonly DataContext _dataContext;

        public LivroDAO(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Livro Inserir(Livro livro)
        {
            try
            {
                _parametros.Add("Nome", livro.Nome, DbType.String);
                _parametros.Add("Autor", livro.Autor, DbType.String);
                _parametros.Add("Edicao", livro.Edicao, DbType.Int32);
                _parametros.Add("Isbn", livro.Isbn, DbType.String);
                _parametros.Add("Imagem", livro.Imagem, DbType.String);

                string sql = @"INSERT INTO Livro (Nome, Autor, Edicao, Isbn, Imagem) VALUES (@Nome, @Autor, @Edicao, @Isbn, @imagem); SELECT SCOPE_IDENTITY();";

                livro.Id = _dataContext.SQLServerConexao.ExecuteScalar<long>(sql, _parametros);
                return livro;
            }
            catch (Exception ex)
            {
                throw new Exception(@$"Não foi possível inserir o livro! {ex.Message}");
            }
        }

        public void Alterar(Livro livro)
        {
            try
            {
                _parametros.Add("Id", livro.Id, DbType.Int64);
                _parametros.Add("Nome", livro.Nome, DbType.String);
                _parametros.Add("Autor", livro.Autor, DbType.String);
                _parametros.Add("Edicao", livro.Edicao, DbType.Int32);
                _parametros.Add("Isbn", livro.Isbn, DbType.String);
                _parametros.Add("Imagem", livro.Imagem, DbType.String);

                string sql = @"UPDATE Livro SET Nome=@Nome, Autor=@Autor, Edicao=@Edicao, Isbn=@Isbn, Imagem=@Imagem where Id=@Id";

                _dataContext.SQLServerConexao.Execute(sql, _parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(@$"Não foi possível alterar o livro! {ex.Message}");
            }
        }

        public void Deletar(Livro livro)
        {
            try
            {
                _parametros.Add("Id", livro.Id, DbType.Int64);

                string sql = @"DELETE FROM Livro WHERE Id=@Id";

                _dataContext.SQLServerConexao.Execute(sql, _parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(@$"Não foi possível apagar o livro! {ex.Message}");
            }
        }

        public List<Livro> Listar()
        {
            try
            {
                string sql = "SELECT * FROM Livro ORDER BY Nome";

                var livros = _dataContext.SQLServerConexao.Query<Livro>(sql).ToList();
                return livros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Livro ObterPorId(int id)
        {
            try
            {
                _parametros.Add("Id", id, DbType.Int64);

                string sql = "SELECT * FROM Livro WHERE Id=@Id";

                var livro = _dataContext.SQLServerConexao.Query<Livro>(sql, _parametros).FirstOrDefault();
                return livro;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}