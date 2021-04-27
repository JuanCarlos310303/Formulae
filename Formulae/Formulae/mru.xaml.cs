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
    public partial class mru : ContentPage
    {
        public mru()
        {
            InitializeComponent();
            pkVar.Items.Add("Velocidad");
            pkVar.Items.Add("Distancia");
            pkVar.Items.Add("Tiempo");
        }
        private void pkVar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtN1.Text) && !string.IsNullOrEmpty(txtN2.Text))
            {
                String op = pkVar.SelectedItem.ToString();
                var n1 = double.Parse(txtN1.Text);
                var n2 = double.Parse(txtN2.Text);
                double resultado = 0;
                if (op == "Velocidad")
                {
                    resultado = n1 / n2;
                    lblRes.Text = resultado + "m/s";
                }
                else if (op == "Distancia")
                {
                    resultado = n1 * n2;
                    lblRes.Text = resultado + "m";
                }
                else 
                {
                    resultado = n1 / n2 ;
                    lblRes.Text = resultado + "s";
                }
            }
            else
            {
                DisplayAlert("Datos incompletos","Escribe todas las variables", "ok");
            }
        }
    }
}