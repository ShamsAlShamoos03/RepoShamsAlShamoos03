using ShamsAlShamoos03.Infrastructure.Persistence.Contexts;
using ShamsAlShamoos03.Infrastructure.Persistence.Repositories;

namespace ShamsAlShamoos03.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(
            ApplicationDbContext context,
            IDapperGenericRepository dapper)
        {
            _context = context;
            Dapper = dapper;
        }

        public IDapperGenericRepository Dapper { get; }

        public IBaseRepository<T> Repository<T>() where T : class
        {
            var type = typeof(T);

            if (!_repositories.ContainsKey(type))
            {
                _repositories[type] =
                    new GenericClass<T>(_context);
            }

            return (IBaseRepository<T>)_repositories[type];
        }

        public IBaseRepository<HistoryRegisterKala01>
            HistoryRegisterKala01UW =>
            Repository<HistoryRegisterKala01>();

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task InsertAsync<T>(T entity)
            where T : class
        {
            await Repository<T>().AddAsync(entity);

            await SaveChangesAsync();
        }
    }
}
