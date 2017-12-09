using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataView.Interface;
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

        public async Task<ICollection<Post>> SearchAsync(string searchStr)
        {
            var searchResult = await _applicationDataView.SearchAsync(searchStr);
            var mappedobject = _toDomainModelMappingFacade.Map(searchResult);
            return mappedobject;
        }

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

        public User GetUserInfor()
        {
            throw new NotImplementedException();
        }

        public void AddPost(Post post)
        {
            var mappedToDataEntity = _toDataEntityMappingFacade.Map(post);
            _applicationDataView.AddPost(mappedToDataEntity);
        }

        public void SetUserInfor()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePost(int postId){
            
            var isDeleted = await _applicationDataView.DeletePost(postId);

            return isDeleted;
        }

    }
}
