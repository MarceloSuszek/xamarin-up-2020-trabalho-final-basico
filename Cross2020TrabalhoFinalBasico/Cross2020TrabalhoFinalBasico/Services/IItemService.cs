using System.Threading.Tasks;
using System.Collections.Generic;
using Cross2020TrabalhoFinalBasico.Models;

namespace Cross2020TrabalhoFinalBasico.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();
    }

    public sealed class ItemService : IItemService
    {
        public async Task<List<Item>> GetAll()
        {
            await Task.Delay(2000);

            return new List<Item>
            {
                Item.Create("Marvel 1", "Desc 1", "https://s.aficionados.com.br/imagens/esta-e-a-ordem-cronologica-correta-para-assistir-aos-filmes-e-series-da-marvel_f.png"),
                Item.Create("Marvel 2", "Desc 2", "https://cinepop.com.br/wp-content/uploads/2019/04/marvelstudios_2-750x380.jpg"),
                Item.Create("Marvel 3", "Desc 3", "https://www.heroisdateve.com.br/wp-content/uploads/2017/11/706c70753d7a121c274b402244870612.jpg.jpeg")
            };
        }
    }
}
