using System;
using PropertyTrackApi.Models;

namespace PropertyTrackApi.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel(Item item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            PurchaseDateTime = item.PurchaseDateTime;
            PurchasePrice = item.PurchasePrice;
            Category = new BaseCategoryViewModel(item.Category);
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PurchaseDateTime { get; set; }

        public double PurchasePrice { get; set; }

        public BaseCategoryViewModel Category { get; set;}
    }
}