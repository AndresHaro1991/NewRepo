using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS5v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDelUp : ContentPage
    {
        public viewDelUp()
        {
            InitializeComponent();
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}