using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS5v2
{
    public partial class MainPage : ContentPage
    {

        private const string Url = "http://192.168.1.10/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<AppS5v2.Ws.Datos > _post;
        public MainPage()
        {
            InitializeComponent();
            get();
        }

        public async void get()
        {
           try
            {
                var content = await client.GetStringAsync(Url);
                List<AppS5v2.Ws.Datos> posts = JsonConvert.DeserializeObject<List<AppS5v2.Ws.Datos>>(content);
                _post = new ObservableCollection<AppS5v2.Ws.Datos>(posts);

                MyListView.ItemsSource = _post;

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "ERROR"+ ex.Message, "OK");
            }
            
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new viewInsertar());
        }

        private void btnPost_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new viewDelUp());
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new viewDelUp());
        }
    }
}
