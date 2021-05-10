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
    public partial class Hipotenusa : ContentPage
    {
        public Hipotenusa()
        {
            InitializeComponent();
        }

        private void Cal_Hipotenusa_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cateto1_.Text) && !string.IsNullOrEmpty(Cateto2_.Text))
            {
                var cateto1_ = double.Parse(Cateto1_.Text);
                var cateto2_ = double.Parse(Cateto2_.Text);

                var hipotenusa = Math.Sqrt((cateto1_ * cateto1_)+(cateto2_ * cateto2_));
                Hipotenusa_.Text = hipotenusa.ToString();
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Por favor, llena todos los campos", "OK");
            }
        }
    }
}