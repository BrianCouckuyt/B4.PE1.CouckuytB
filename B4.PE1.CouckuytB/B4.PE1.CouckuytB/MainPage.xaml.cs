using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE1.CouckuytB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnPictureGallery_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PictureGallery());
        }

        private async void btnWikiPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WikiPage());
        }     
    }
}
