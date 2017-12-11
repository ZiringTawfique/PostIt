using System;
namespace Domain.Aggregate
{
    public class SearchParameters
    {
        public int PageNo { get; set;}
        public int PageSize { get; set; }
        public string SearchWord { get; set; }


    }
}
