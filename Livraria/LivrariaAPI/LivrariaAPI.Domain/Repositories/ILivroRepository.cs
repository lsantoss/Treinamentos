using LivrariaAPI.Domain.Entidades;
using LivrariaAPI.Domain.Query;
using System.Collections.Generic;

namespace LivrariaAPI.Domain.Repositories
{
    public interface ILivroRepository
    {
        Livro Inserir(Livro livro);
        void Alterar(Livro livro);
        void Deletar(int id);
        List<LivroQueryResult> Listar();
        LivroQueryResult ObterPorId(int id);
        bool CheckId(int id);
    }
}