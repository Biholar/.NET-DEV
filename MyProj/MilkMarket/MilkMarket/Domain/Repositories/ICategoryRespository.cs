using System.Collections.Generic;
using System.Threading.Tasks;
using MilkMarket.Domain.Models;

namespace MilkMarket.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
    }
}
