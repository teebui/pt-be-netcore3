using System.Collections.Generic;
using System.Threading.Tasks;
using PropertyTrackApi.Models;
using PropertyTrackApi.ViewModels;

namespace PropertyTrackApi.Services
{
    public interface IItemService
    {
        Task CreateItemAsync(Item item);
        Task DeleteItemAsync(int itemId);
        Task<List<ItemViewModel>> GetItemsAsync();
        Task<ItemViewModel> GetItemAsync(int id);
        Task UpdateItemAsync(int catId, Item category);        
    }

}