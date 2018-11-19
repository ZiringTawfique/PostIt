using System;
using System.Threading.Tasks;
using Model;

namespace BackEndService.Interfaces
{
	public interface IPostService
    {
        //Task<PostSearchResult> GetFilteredRequests(SearchParameters searchParameters);
        // Task<HttpResponseMessage> UpdateRequest(RequestUpdateParameters requestUpdateParameters);
        //Task<HttpResponseMessage> AssignToRequests(ICollection<RequestAssignmentParameters> requestAssignmentParameters);


		Task<Post> GetAPost(int postId);
    }
}
