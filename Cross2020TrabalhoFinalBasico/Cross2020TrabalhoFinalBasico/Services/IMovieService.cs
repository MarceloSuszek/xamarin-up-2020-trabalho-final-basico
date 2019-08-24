using System.Threading.Tasks;
using System.Collections.Generic;
using Cross2020TrabalhoFinalBasico.Models;
using Cross2020TrabalhoFinalBasico.Repositories;

namespace Cross2020TrabalhoFinalBasico.Services
{
    public interface IMovieService
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }

    public sealed class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService()
        {
            movieRepository = new MovieRepository();
        }

        public Task<(string error, List<Movie>)> GetUpcoming() => movieRepository.GetUpcoming();
    }
}
