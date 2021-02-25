using System.Collections.Generic;
using System.Threading.Tasks;
using MilkMarket.Domain.Models;
using MilkMarket.Domain.Services.Communication;

namespace MilkMarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
    }
}

