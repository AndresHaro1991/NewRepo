using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPr1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "estudiante2021" && contrasena == "uisrael2021")
            {
                await Navigation.PushAsync(new Page1(usuario));
            }
            else
            {
                await DisplayAlert("Error", "Usuario o Contraseña ingresados incorrectos, vuelva a intentar", "OK");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
    }
}
