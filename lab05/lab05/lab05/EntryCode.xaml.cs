using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab05
{	
	public partial class EntryCode : ContentPage
	{	
		public EntryCode ()
		{
			InitializeComponent ();
			StackLayout stack = new StackLayout();
			var entry = new Entry { Text = "this is a read-only Entry"};
			stack.Children.Add(entry);

			Content = stack;
		}
	}
}

