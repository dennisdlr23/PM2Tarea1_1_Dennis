using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           
            InitializeComponent();
        }

        private void btnsumar_Clicked(object sender, EventArgs e)
        {

            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 + n2;
            Navigation.PushModalAsync(new Views.PageTwo(resultado));

        }

        private void btnrestar_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 - n2;
            Navigation.PushModalAsync(new Views.PageTwo(resultado));
        }

        private void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 * n2;
            Navigation.PushModalAsync(new Views.PageTwo(resultado));
        }

        private void btndividir_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 / n2;
            Navigation.PushModalAsync(new Views.PageTwo(resultado));
        }
    }
}
