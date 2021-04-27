using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formulae
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mrua : ContentPage
    {
        public mrua()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtN1.Text) && !String.IsNullOrEmpty(txtN2.Text) && !String.IsNullOrEmpty(txtN3.Text))
            {
                var vf = double.Parse(txtN1.Text);
                var vi = double.Parse(txtN2.Text);
                var t = double.Parse(txtN3.Text);
                var distancia = ((vf - vi) / t) + " m/s²";

                resultado.Text = distancia.ToString();
            }
            else
            {
                DisplayAlert("Datos incompletos", "Escribe todos los datos", "ok");
            }
        }
    }
}