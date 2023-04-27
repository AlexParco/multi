using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab04
{	
	public partial class Page1 : ContentPage
	{	
		public Page1 ()
		{
			InitializeComponent ();

			btnClose.Clicked += async (sender, a) =>
			{
				await Navigation.PopAsync();
			};

		}

		async void OnNextPageButtonClicked(object sender, EventArgs a)
		{
			await Navigation.PushAsync(new Page2());
		}
	}
}

