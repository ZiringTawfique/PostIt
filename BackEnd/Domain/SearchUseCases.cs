using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Ports;
using Domain.Interfaces;
using NLog;
namespace Domain
{
    public class SearchUseCases: ISearchUseCases
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        IRepository _mongoRepo;

        public SearchUseCases(IRepository MongoRepo)
        {
            _mongoRepo = MongoRepo;
        }


        public async Task<ICollection<Post>> SearchAsync(string searchStr)
        {
            return await _mongoRepo.SearchAsync(searchStr);
        }
    }
}
