using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE1.CouckuytB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PictureGallery : ContentPage
	{
		public PictureGallery ()
		{
			InitializeComponent ();
		}

        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}