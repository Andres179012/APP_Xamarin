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
    public partial class CalMath : ContentPage
    {
        public CalMath()
        {
            InitializeComponent();
            PicOpe.Items.Add("Factorial");
            PicOpe.Items.Add("Logaritmo");
            PicOpe.Items.Add("Seno");
            PicOpe.Items.Add("Coseno");
            PicOpe.Items.Add("Tangente");
            PicOpe.Items.Add("Secante");
        }

        private void PicOpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Numero.Text))
            {
                string operacion_ = PicOpe.SelectedItem.ToString();

                //Variables para el factorial de un numero
                int numero = Int32.Parse(Numero.Text);
                int n, i, fac = 1;

                //Variables para Seno, Coseno, Tangente y Secante
                double angulo = 0;
                double num = 0;
                double radianes = 0;
                double pi = 3.14159;
                double seno = 0, coseno = 0, tangente = 0, secante = 0;

                if (operacion_ == "Factorial")
                {
                    n = Convert.ToInt32(Numero.Text);
                    for (i = 1; i <= n; i++)
                    {
                        fac = fac * i;
                        Res.Text = fac.ToString();
                    }
                }
                else if (operacion_ == "Logaritmo")
                {
                    //Recibimos el angulo
                    num = Convert.ToInt32(Numero.Text);
                    num = Math.Log(num);
                    Res.Text = num.ToString();
                }
                else if (operacion_ == "Seno")
                {
                    //Recibimos el angulo
                    angulo = Convert.ToInt32(Numero.Text);
                    //Lo convertimos a radianes
                    radianes = angulo * (pi / 180);
                    seno = Math.Sin(radianes);
                    Res.Text = seno.ToString();
                }
                else if (operacion_ == "Coseno")
                {
                    //Recibimos el angulo
                    angulo = Convert.ToInt32(Numero.Text);
                    //Lo convertimos a radianes
                    radianes = angulo * (pi / 180);
                    coseno = Math.Cos(radianes);
                    Res.Text = coseno.ToString();
                }
                else if (operacion_ == "Tangente")
                {
                    //Recibimos el angulo
                    angulo = Convert.ToInt32(Numero.Text);
                    //Lo convertimos a radianes
                    radianes = angulo * (pi / 180);
                    tangente = Math.Tan(radianes);
                    Res.Text = tangente.ToString();
                }
                else
                {
                    //Recibimos el angulo
                    angulo = Convert.ToInt32(Numero.Text);
                    //Lo convertimos a radianes
                    radianes = angulo * (pi / 180);
                    secante = Math.Tan(radianes);
                    Res.Text = secante.ToString();
                }

            }
            else
            {
                DisplayAlert("Datos Erroneos", "Por favor, llena todos los campos", "OK");
            }
            
        }
    }
}