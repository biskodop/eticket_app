using eticket_app.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eticket_app.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);

    }
}
