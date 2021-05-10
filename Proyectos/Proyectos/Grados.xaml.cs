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
    public partial class Grados : ContentPage
    {
        public Grados()
        {
            InitializeComponent();
        }

        private void Convertir_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Grados_.Text))
            {
                var grados_ = double.Parse(Grados_.Text);

                var centigrados_ = (grados_ - 32 ) * 5/9;
                Centigrados_.Text = centigrados_.ToString();
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Por favor, llena todos los campos", "OK");
            }
        }
    }
}