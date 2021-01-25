using LivrariaAPI.Domain.Entidades;
using LivrariaAPI.Domain.Query;
using System.Collections.Generic;

namespace LivrariaAPI.Domain.Interfaces.Repositories
{
    public interface ILivroRepository
    {
        long Inserir(Livro livro);
        void Alterar(Livro livro);
        void Deletar(long id);
        List<LivroQueryResult> Listar();
        LivroQueryResult ObterPorId(long id);
        bool CheckId(long id);
    }
}