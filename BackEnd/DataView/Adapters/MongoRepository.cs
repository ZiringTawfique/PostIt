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

        public async Task<ICollection<Post>> GetAllPostAsync()
        {
            var allPosts = await _applicationDataView.GetAllPostAsync();
            var mappedobject = _toDomainModelMappingFacade.Map(allPosts);
            return mappedobject;
        }

        public Post GetSinglePost()
        {
            throw new NotImplementedException();
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
    }
}
