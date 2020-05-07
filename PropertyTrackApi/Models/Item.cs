using System;

namespace PropertyTrackApi.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PurchaseDateTime { get; set; }

        public double PurchasePrice { get; set; }
    }
}
