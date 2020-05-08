using System.Collections.Generic;
using PropertyTrackApi.Models;

namespace PropertyTrackApi.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel(Category category)
        {
            CategoryId = category.Id;
            Name = category.Name;
            Description = category.Description;
            ItemsCount = category.Items.Count;
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemsCount { get; set; }

    }

    public class CategoryWithItemsViewModel: CategoryViewModel
    {
        public CategoryWithItemsViewModel(Category category): base(category)
        {
            Items = new List<ItemViewModel>();
        }

        public IEnumerable<ItemViewModel> Items { get; set; }
    }
}