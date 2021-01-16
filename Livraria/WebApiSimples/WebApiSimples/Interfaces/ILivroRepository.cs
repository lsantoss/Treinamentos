using System.Collections.Generic;
using WebApiSimples.Entidades;

namespace WebApiSimples.Interfaces
{
    public interface ILivroRepository
    {
        Livro Inserir(Livro livro);
        void Alterar(Livro livro);
        void Deletar(long id);
        List<Livro> Listar();
        Livro ObterPorId(long id);
    }
}