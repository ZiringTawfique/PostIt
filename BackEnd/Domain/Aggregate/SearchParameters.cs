using System;
using Domain.Model;
using Domain.Model.Enum;

namespace Domain.Aggregate
{
    public class SearchParameters
    {
        public int PageNo { get; set;}
        public int PageSize { get; set; }
        public string SearchWord { get; set; }
        public Category Category{ get; set; }
        public PostType PostType{ get; set; }


    }
}
