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
    public partial class VistaNumerosVampiros : ContentPage
    {
        int limiteNumerosVampiros = 8;
        int contadorNumeroVampiros = 0;
        public VistaNumerosVampiros()
        {
            InitializeComponent();
            lblTitulo.Text = $"Mostrar los {limiteNumerosVampiros} números Vampiros";
            lblCalculando.Text = "";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            lblCalculando.Text = "Generando números vampiros...";
            stlNumerosVampiros.Children.Clear();

            await ImprimirNumeros();
        }
        private async Task ImprimirNumeros()
        {
            // mientras sean 8 numeros vampiros
            int numeroAValidar = 1;

            while (contadorNumeroVampiros < limiteNumerosVampiros)
            {
                // buscando un numeros vampiros
                int numDivisores = 0;

                for (int indiceDivisores = 1; indiceDivisores <= (numeroAValidar / 2); indiceDivisores++)
                {
                    if (numeroAValidar % indiceDivisores == 0)
                    {
                        numDivisores += indiceDivisores;
                    }
                }

                if (numDivisores == numeroAValidar)
                {
                    contadorNumeroVampiros += 1;

                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        stlNumerosVampiros.Children.Add(new Label
                        {
                            FontSize = 15,
                            FontFamily = "Arial",
                            Text = $"{contadorNumeroVampiros}: {numeroAValidar}",
                            TextColor = Color.Black,
                            BackgroundColor = Color.White,
                            HorizontalOptions = LayoutOptions.FillAndExpand
                        });

                        await srclResultados.ScrollToAsync(stlNumerosVampiros, ScrollToPosition.End, false);
                    });
                }

                numeroAValidar += 1;
            }
        }

    }
}