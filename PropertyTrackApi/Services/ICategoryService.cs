using System.Collections.Generic;
using System.Threading.Tasks;
using PropertyTrackApi.Models;
using PropertyTrackApi.ViewModels;

namespace Services
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int catId);
        Task<List<CategoryViewModel>> GetCategoriesAsync();
        Task<BaseCategoryViewModel> GetCategoryAsync(int id);
        Task<CategoryWithItemsViewModel> GetCategoryWithItemsAsync(int categoryId);
        Task UpdateCategoryAsync(int catId, Category category);
    }

}