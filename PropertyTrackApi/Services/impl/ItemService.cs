using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyTrackApi.Models;
using PropertyTrackApi.ViewModels;

namespace Services.Impl
{
    class ItemService : IItemService
    {
        private PropertyTrackContext _context;

        public ItemService(PropertyTrackContext context)
        {
            _context = context;
        }

        public async Task CreateItemAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();            
        }

        public async Task DeleteItemAsync(int itemId)
        {
            var item = await _context.Items.FindAsync(itemId);
            if (item == null)
            {
                ThrowNotFoundException(itemId);
            }

            _context.Items.Remove(item);
        }

        public async Task<List<ItemViewModel>> GetItemsAsync()
        {
            return await _context.Items
                .Include(i => i.Category)
                .Select(i => new ItemViewModel(i))
                .ToListAsync();
        }

        public async Task<ItemViewModel> GetItemAsync(int id)
        {
            var item = await _context.Items
                .Include(x => x.Category)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            
            return new ItemViewModel(item);
        }

        public async Task UpdateItemAsync(int itemId, Item item)
        {
            var itemExists = await ItemExistsAsync(itemId);
            if (!itemExists)
            {
                ThrowNotFoundException(itemId);
            }

            try
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {   
                throw new ItemServiceException($"Cannot update item {itemId}", ex);                
            }
        }

        private async Task<bool> ItemExistsAsync(int id)
        {
            return await _context.Items.AnyAsync(e => e.Id == id);
        }

        private static void ThrowNotFoundException(int itemId)
        {
            throw new NotFoundException($"The requested Item with ItemId {itemId} does not exist");
        }
    }

}