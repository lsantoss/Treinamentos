using Flunt.Notifications;
using LivrariaAPI.Domain.Interfaces.Commands;
using System;

namespace LivrariaAPI.Domain.Commands.Livro.Input
{
    public class ApagarLivroCommand : Notifiable, ICommandPadrao
    {
        public long Id { get; set; }

        public bool ValidarCommand()
        {
            try
            {
                if (Id <= 0)
                    AddNotification("Id", "Id é um campo obrigatório");

                return Valid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}