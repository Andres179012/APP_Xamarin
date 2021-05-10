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
    public partial class Area : ContentPage
    {
        public Area()
        {
            InitializeComponent();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Base_.Text) && !string.IsNullOrEmpty(Altura_.Text))
            {
                var base_ = double.Parse(Base_.Text);
                var altura_ = double.Parse(Altura_.Text);

                var area_ = (base_ * altura_) / 2;
                Area_.Text = area_.ToString();
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Por favor, llena todos los campos", "OK");
            }
           
        }
    }
}