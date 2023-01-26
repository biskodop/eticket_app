using eticket_app.Models;
using eticket_app.Data.Base;
using System.Threading.Tasks;
using eticket_app.Data.ViewModels;

namespace eticket_app.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}