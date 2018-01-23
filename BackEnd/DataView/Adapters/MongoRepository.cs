using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataView.Interface;
using Domain.Aggregate;
using Domain.Model;
using Domain.Ports;

namespace DataView.Adapters
{
    public class MongoRepository : IRepository
    {
        private IApplicationDataView _applicationDataView;
        private IToDomainModelMappingFacade _toDomainModelMappingFacade;
        private IToDataEntityMappingFacade _toDataEntityMappingFacade;
        public MongoRepository(IApplicationDataView applicationDataView, IToDomainModelMappingFacade toDomainModelMappingFacade, IToDataEntityMappingFacade toDataEntityMappingFacade)
        {

            _applicationDataView = applicationDataView;
            _toDomainModelMappingFacade = toDomainModelMappingFacade;
            _toDataEntityMappingFacade = toDataEntityMappingFacade;
        }

        public async Task<ICollection<Post>> SearchAsync(SearchParameters searchParameter)
        {
            var searchResult = await _applicationDataView.SearchAsync(searchParameter.SearchWord, searchParameter.PageNo, searchParameter.PageSize);
            var mappedobject = _toDomainModelMappingFacade.Map(searchResult);
            return mappedobject;
        }

        #region GET
       
        public async Task<ICollection<Post>> GetAllPostAsync()
        {
            var allPosts = await _applicationDataView.GetAllPostAsync();
            var mappedobject = _toDomainModelMappingFacade.Map(allPosts);
            return mappedobject;
        }

        public async Task<Post> GetSinglePost(int postId)
        {
            var singlePost = await _applicationDataView.GetSinglePost(postId);
            var mappedobject = _toDomainModelMappingFacade.Map(singlePost);
            return mappedobject;
            
        }

        public async Task<ICollection<Post>> GetMyPostsAsync(string username)
        {
                var myPosts = await _applicationDataView.GetMyPostsAsync(username);
            var mappedObject = _toDomainModelMappingFacade.Map(myPosts);
            return mappedObject;
        }

        public User GetUserInfor()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SET
        public void AddPost(Post post)
        {
            var mappedToDataEntity = _toDataEntityMappingFacade.Map(post);
            _applicationDataView.AddPost(mappedToDataEntity);
        }

        public void SetUserInfor()
        {
            throw new NotImplementedException();
        }

        #endregion

        public async Task<bool> DeletePost(int postId){
            
            var isDeleted = await _applicationDataView.DeletePost(postId);

            return isDeleted;
        }

    }
}
