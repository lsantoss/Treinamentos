using System.Collections.Generic;
using Votacao.Domain.Entidades;
using Votacao.Domain.Query.Usuario;
using Votacao.Domain.ValueObjects;

namespace Votacao.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        int Salvar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Deletar(int id);

        UsuarioQueryResult Obter(int id);
        List<UsuarioQueryResult> Listar();

        UsuarioQueryResult Logar(Email login, string senha);

        bool CheckLogin(Email login);
        bool CheckId(int id);
    }
}