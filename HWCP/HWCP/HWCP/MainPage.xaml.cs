using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HWCP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Page1());
            Console.WriteLine("FUCK ME");
        }
    }
}
