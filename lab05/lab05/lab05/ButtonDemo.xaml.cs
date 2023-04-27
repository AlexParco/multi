using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab05
{
	public partial class ButtonDemo : ContentPage
	{	
		public ButtonDemo ()
		{
			InitializeComponent ();
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			await label.RelRotateTo(360, 1000);
		} 
	}
}

