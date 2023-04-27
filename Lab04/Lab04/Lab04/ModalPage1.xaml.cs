using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab04
{	
	public partial class ModalPage1 : ContentPage
	{	
		public ModalPage1 ()
		{
			InitializeComponent ();
			btnClosePopup.Clicked += async (sender, a) =>
			{
				await Navigation.PopModalAsync(); 
		    };
		}
	}
}

