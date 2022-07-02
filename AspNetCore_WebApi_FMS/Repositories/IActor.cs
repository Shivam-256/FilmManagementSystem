using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface IActor
    {
        Actor AddActor(Actor act);
        void UpdateActor(int actorId, Actor act);
        bool DeleteActor(int actorId);
        Actor SearchActor(int actorId);
        IEnumerable<Actor> GetActors();
    }
}
