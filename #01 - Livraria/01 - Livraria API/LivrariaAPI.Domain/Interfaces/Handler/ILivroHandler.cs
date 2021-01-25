using LivrariaAPI.Domain.Commands.Livro.Input;
using LivrariaAPI.Domain.Interfaces.Commands;

namespace LivrariaAPI.Domain.Interfaces.Handler
{
    public interface ILivroHandler : ICommandHandler<AdicionarLivroCommand>,
                                     ICommandHandler<AtualizarLivroCommand>,
                                     ICommandHandler<ApagarLivroCommand>
    {
    }
}