using System;

namespace PropertyTrackApi.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PurchaseDateTime { get; set; }

        public double PurchasePrice { get; set; }

        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}