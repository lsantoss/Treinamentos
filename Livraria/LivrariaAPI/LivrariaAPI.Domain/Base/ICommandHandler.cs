namespace LivrariaAPI.Domain.Base
{
    public interface ICommandHandler<T> where T : ICommandPadrao
    {
        ICommandResult Handle(T command);
    }
}