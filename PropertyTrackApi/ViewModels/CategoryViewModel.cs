using System.Collections.Generic;
using PropertyTrackApi.Models;

namespace PropertyTrackApi.ViewModels
{
    public class BaseCategoryViewModel
    {
        public BaseCategoryViewModel(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CategoryViewModel : BaseCategoryViewModel
    {
        public CategoryViewModel(Category category): base(category)
        {

            Description = category.Description;
            ItemsCount = category.Items.Count;
        }

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