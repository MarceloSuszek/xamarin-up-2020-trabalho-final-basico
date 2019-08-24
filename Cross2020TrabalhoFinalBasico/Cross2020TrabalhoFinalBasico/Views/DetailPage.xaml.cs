using Cross2020TrabalhoFinalBasico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cross2020TrabalhoFinalBasico.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Item item)
        {
            InitializeComponent();

            BindingContext = item;
        }
    }
}