
using Common;
using DAL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class SpaceBL : ISpaceBL
    {
        private readonly ISpaceRepository _SpaceRepository;

        public SpaceBL(ISpaceRepository SpaceRepository)
        {
            _SpaceRepository = SpaceRepository; 
        }
        public void Dispose()
        {
        }

        public Task<SpaceLocationResponse> GetLocation()
        {
            return _SpaceRepository.GetLocation();
        }

        public List<ImportantLocation> SaveLocation(ImportantLocation importantLocation)
        {
            return _SpaceRepository.SaveLocation(importantLocation);
        }
    }
}
