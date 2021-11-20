using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPr1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string usuario)
        {
            InitializeComponent();
            lblUsuarioCo.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

        }
    }
}