using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int scores = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //DATOS PERSONALES
            if (button.Text == bomb)
            {
                await DisplayAlert("Nombre", "Apellido", "Direccion", "Telefono");
                bomb = new Random().Next(1, 4).ToString();
                scores = 0;
            } else
            {
                scores += 1;
                await DisplayAlert("DATOS PERSONALES", "DATOS ESCOLARES" + scores, "CONTINUAR");
                bomb = new Random().Next(1, 4).ToString();
                
            }
        }
    }
}
