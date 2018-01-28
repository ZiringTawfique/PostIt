using System;
namespace Domain.Model
{
    public class Category
    {
		public string Parent { get; set; }
        public string Child { get; set; }
        public string LastChild { get; set; }
    }
}
   