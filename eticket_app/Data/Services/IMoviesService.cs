using eticket_app.Models;
using eticket_app.Data.Base;
using System.Threading.Tasks;

namespace eticket_app.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}