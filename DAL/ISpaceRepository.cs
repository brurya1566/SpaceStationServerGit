using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISpaceRepository:IDisposable
    {
        public  Task<SpaceLocationResponse> GetLocation();
        public List<ImportantLocation> SaveLocation(ImportantLocation importantLocation);
    }
}
