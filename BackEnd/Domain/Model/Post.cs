using System;
namespace Domain.Model
{
	public class Post
	{
		public int PostId { get; set; }

		public string Title { get; set; }

        public DateTime DateAdded { get; set; }

		//public User User { get; set; }

		//public Category Category { get; set; }

		//public Item ItemForSalePost { get; set; }

		//public Recommendation RecommendationPost { get; set; }

		//public LookingFor LookingForPost { get; set; }

        //public LostAndFound LostAndFoundPost { get; set; }

        public bool isUrgent { get; set; }



	}
}
