using Flunt.Notifications;
using System.Collections.Generic;

namespace LivrariaAPI.Domain.Interfaces
{
    public interface ICommandResult
    {
        bool Sucesso { get; set; }
        string Mensagem { get; set; }
        object Dados { get; set; }
        List<Notification> Erros { get; set; }
    }
}