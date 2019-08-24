using Cross2020TrabalhoFinalBasico.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cross2020TrabalhoFinalBasico.Repositories
{
    public interface IMovieRepository
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }
}
