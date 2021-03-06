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
    public partial class sln : ContentPage
    {
        public sln()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtN1.Text) && !String.IsNullOrEmpty(txtN2.Text))
            {
                var m = double.Parse(txtN1.Text);
                var a = double.Parse(txtN2.Text);

                var fuerza = (a * m) + " N";

                resultado.Text = fuerza.ToString();
            }
            else
            {
                DisplayAlert("Datos incompletos", "Escribe todos los datos", "ok");
            }
        }
    }
}