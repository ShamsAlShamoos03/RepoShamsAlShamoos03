using ShamsAlShamoos03.Infrastructure.Persistence.Repositories;

namespace ShamsAlShamoos03.Infrastructure.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<T> Repository<T>() where T : class;
        Task<int> SaveChangesAsync();

        IDapperGenericRepository Dapper { get; }

        // Example specific repository
        IBaseRepository<HistoryRegisterKala01> HistoryRegisterKala01UW { get; }

        Task InsertAsync<T>(T entity) where T : class;
    }
}
