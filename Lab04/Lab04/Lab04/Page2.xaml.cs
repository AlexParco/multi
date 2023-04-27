using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab04
{	
	public partial class Page2 : ContentPage
	{	
		public Page2 ()
		{
			InitializeComponent ();
		}

        async void OnPreviousPageButtonClicked(System.Object sender, System.EventArgs e)
		{
			await Navigation.PopAsync();
		}
    }
}

