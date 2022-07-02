using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public class ActorRepository2 : IActor2
    {
        private FMSDbContext _db;
        public ActorRepository2(FMSDbContext context)
        {
            this._db = context;
        }
        public IEnumerable<Actor> GetActors()
        {
            var actList = _db.Actors;
            return actList;
        }

    }
}