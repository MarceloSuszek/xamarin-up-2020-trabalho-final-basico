using Cross2020TrabalhoFinalBasico.Models;
using Refit;
using System.Threading.Tasks;

namespace Cross2020TrabalhoFinalBasico.Api
{
    public interface IMovieApi
    {
        [Get("/movie/upcoming?api_key={apiKey}")]
        Task<UpcomingResponse> GetUpcoming(string apiKey);
    }
}