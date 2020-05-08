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
            CategoryName = item.Category.Name;
            CategoryId = item.CategoryId;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PurchaseDateTime { get; set; }

        public double PurchasePrice { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}