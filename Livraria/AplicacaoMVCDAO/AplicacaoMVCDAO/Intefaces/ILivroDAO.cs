using AplicacaoMVCDAO.Models.Livros;
using System.Collections.Generic;

namespace AplicacaoMVCDAO.Intefaces
{
    public interface ILivroDAO
    {
        Livro Inserir(Livro livro);
        void Alterar(Livro livro);
        void Deletar(Livro livro);
        List<Livro> Listar();
        Livro ObterPorId(int id);
    }
}