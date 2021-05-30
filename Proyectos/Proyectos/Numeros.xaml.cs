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
    public partial class Numeros : ContentPage
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void Calcular_Numeros_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}