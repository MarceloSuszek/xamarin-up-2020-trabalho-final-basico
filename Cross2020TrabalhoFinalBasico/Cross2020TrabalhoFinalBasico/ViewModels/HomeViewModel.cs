using Cross2020TrabalhoFinalBasico.Models;
using Cross2020TrabalhoFinalBasico.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cross2020TrabalhoFinalBasico.ViewModels
{
    public sealed class HomeViewModel : BaseViewModel
    {
        private IMovieService movieService;

        private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

        public HomeViewModel()
        {
            movieService = new MovieService();
        }

        public ObservableCollection<Movie> Movies
        {
            get => movies;
            set { movies = value; OnPropertyChanged(); }
        }

        public async override Task Initialize()
        {
            await ExecuteBusyAction(async () => {

                (var error, var upcomingMovies) = await movieService.GetUpcoming();

                if(error != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", error, "Ok");

                    return;
                }

                Movies = new ObservableCollection<Movie>(upcomingMovies);

            });
        }
    }
}
