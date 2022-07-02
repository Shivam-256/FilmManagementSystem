using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public class ActorRepository : IActor
    {
        private FMSDbContext _db;
        public ActorRepository(FMSDbContext context)
        {
            this._db = context;
        }
        public Actor AddActor(Actor act)
        {
            _db.Actors.Add(act);
            _db.SaveChanges();
            return act;
        }

        public bool DeleteActor(int actorId)
        {
            var act = _db.Actors.FirstOrDefault(a => a.ActorId == actorId);
            if (act != null)
            {
                _db.Actors.Remove(act);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Actor> GetActors()
        {
            var actList = _db.Actors;
            return actList;
        }

        public Actor SearchActor(int actorId)
        {
            var act = _db.Actors.FirstOrDefault(a => a.ActorId == actorId);
            if (act != null)
                return act;
            else
                return null;
        }

        public void UpdateActor(int actorId, Actor act)
        {
            var newAct = _db.Actors.FirstOrDefault(a => a.ActorId == actorId);
            if (newAct != null)
            {
                newAct.ActorId = act.ActorId;
                newAct.FirstName = act.FirstName;
                newAct.LastName = act.LastName;
                _db.SaveChanges();
            }
        }
    }
}
