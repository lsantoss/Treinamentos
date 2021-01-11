using Dapper;
using LivrariaAPI.Domain.Repositories;
using LivrariaAPI.Infra.DataContexts;

namespace LivrariaAPI.Infra.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DynamicParameters _parametros = new DynamicParameters();
        private readonly DataContext _dataContext;

        public LivroRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}