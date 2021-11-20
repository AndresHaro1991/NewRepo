using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS5v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewInsertar : ContentPage
    {
        public viewInsertar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("id", txtId.Text);
                parametros.Add("nombres", txtNombres.Text);
                parametros.Add("apellidos", txtApellidos.Text);
                parametros.Add("correo", txtCorreo.Text);
                parametros.Add("usuario", txtUsuario.Text);
                parametros.Add("contrasena", txtContrasena.Text);

                cliente.UploadValues("http://192.168.1.10/moviles/post", "POST", parametros);
                DisplayAlert("alerta", "Ingreso correcto", "ok");

            }
            catch (Exception ex)
            {
                DisplayAlert("alerta", ex.Message, "ok");

            }

        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }
    }
}