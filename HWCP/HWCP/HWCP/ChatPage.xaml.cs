using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HWCP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatPage : ContentPage
	{

        private Label label;

		public ChatPage ()
		{
			InitializeComponent ();
          //  WSConnection wSConnection = new WSConnection();
           // wSConnection.connect();
            label = new Label()
		}

        public void SendMessage()
        {

        }
    }
}