using Cross2020TrabalhoFinalBasico.Models;
using Cross2020TrabalhoFinalBasico.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Cross2020TrabalhoFinalBasico.ViewModels
{
    public sealed class HomeViewModel : BaseViewModel
    {
        private IItemService itemService;

        private ObservableCollection<Item> items = new ObservableCollection<Item>();

        public HomeViewModel()
        {
            itemService = new ItemService();
        }

        public ObservableCollection<Item> Items
        {
            get => items;
            set { items = value; OnPropertyChanged(); }
        }

        public async override Task Initialize()
        {
            await ExecuteBusyAction(async () => {

                var itemsColletion = await itemService.GetAll();

                Items.Clear();

                foreach (var item in itemsColletion)
                {
                    Items.Add(item);
                }
            });
        }
    }
}
