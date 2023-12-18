namespace HR.LeaveManagement.Application.Persistence.Contracts;

public interface IGenericRepository<T>
    where T : class
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyCollection<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<IReadOnlyCollection<T>> AddListAsync(IReadOnlyCollection<T> entities);
    Task<IReadOnlyCollection<T>> UpdateListAsync(IReadOnlyCollection<T> entities);
    Task<IReadOnlyCollection<T>> DeleteListAsync(IReadOnlyCollection<T> entities);
}
