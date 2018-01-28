using System;
using Domain.Exceptions;
using Domain.Model.Enum;

namespace Domain.Model
{
	public class Post
	{
		public int PostId { get; set; }

		public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

		public User User { get; set; }

        public bool isUrgent { get; set; }

		
        // Type of Posts
        public Item ItemInfo { get; set; }

		public Recommendation RecommendationPost { get; set; }

		public LookingFor LookingForPost { get; set; }

        public LostAndFound LostAndFoundPost { get; set; }


        public PostType PostType {
            get{
                if (ItemInfo != null) return PostType.ItemForSale;
                if (RecommendationPost != null) return PostType.Recommendation;
                throw new PostTypeIsUnknownException();
            }
        }



	}
}
