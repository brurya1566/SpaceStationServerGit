
using Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface ISpaceBL:IDisposable
    {
        public Task<SpaceLocationResponse> GetLocation();
        public List<ImportantLocation> SaveLocation(ImportantLocation importantLocation);
    }
}
