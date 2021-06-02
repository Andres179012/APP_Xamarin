using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyectos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void btnArea_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new Area());
        }

        private async void btnCelsius_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new Grados());
        }

        private async void btnTriangulo_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new Hipotenusa());
        }

        private async void btnCelsius_Clicked_1(object sender, EventArgs e)
        {

        }

        private async void btnCal_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new CalMath());
        }

        private async void btnPrimos_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new VistaNumerosPrimos());
        }

        private async void btnPerfectos_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new VistaNumerosPerfectos());
        }

        private async void btnAmigos_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new VistaNumerosAmigos());
        }

        private async void btnVampiros_Clicked(object sender, EventArgs e)
        {
            App.MastDet.IsPresented = false;
            await App.MastDet.Detail.Navigation.PushAsync(new VistaNumerosVampiros());
        }
    }
}