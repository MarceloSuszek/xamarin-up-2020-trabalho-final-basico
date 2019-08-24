using Cross2020TrabalhoFinalBasico.Api;
using Cross2020TrabalhoFinalBasico.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cross2020TrabalhoFinalBasico.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public readonly IMovieApi movieApi;
        public MovieRepository()
        {
            movieApi = RestService.For<IMovieApi>(AppConstans.API_ENDPOINT);
        }

        async Task<(string error, List<Movie>)> IMovieRepository.GetUpcoming()
        {
            try
            {
                var response = await movieApi.GetUpcoming(AppConstans.API_KEY);

                if(response == null)
                {
                    return ("Falha na requisição, tente novamente.", null);
                }

                if(response.Movies.Count == 0)
                {
                    return ("Nenhum filme encontrado.", null);
                }

                return (null, response.Movies);
            }
            catch (ApiException ex)
            {
                return (ex.Message, null);
            }
        }
    }
}
