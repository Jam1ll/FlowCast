namespace FlowCast.Core.Domain.Interfaces
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        // basic crud

        Task<Entity?> AddAsync(Entity entity);
        Task<Entity?> UpdateAsync(Entity entity);
        Task<Entity?> UpdateAsync(int Id, Entity entity);
        Task DeleteAsync(Entity entity);
        Task DeleteAsync(int? Id);

        // navigation methods

        Task<Entity?> GetById(int id);
        Task<List<Entity>> GetAll();
        IQueryable<Entity> GetAllQuery();
        Task<Entity?> GetByIdWithInclude(int id, List<string> includeProperties);
        Task<List<Entity>> GetAllWithInclude(List<string> properties);
        IQueryable<Entity> GetAllQueryWithInclude(List<string> properties);
    }
}