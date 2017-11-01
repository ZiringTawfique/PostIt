using System;
namespace Domain.Model
{
    public class Item
    {
		public double Price { get; set; }

		public double Size { get; set; }

        public Category Category { get; set; }
    }
}
