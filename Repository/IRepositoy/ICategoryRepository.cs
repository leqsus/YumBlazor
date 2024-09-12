using YumBlazor.Data;

namespace YumBlazor.Repository.IRepositoy
{
    public interface ICategoryRepository
    {
        public Task<Category> createAsync(Category obj);
        public Task<Category> UpdateAsync(Category obj);   
        public Task<bool> DeleteAsync(int id);
        public Task<Category> GetAsync(int id);   
        public Task<IEnumerable<Category>> GetAllAsync();   
    }
}
