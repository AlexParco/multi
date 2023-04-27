using System;
using System.Reflection;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace lab05
{
	[Preserve(AllMembers = true)]
	[ContentProperty(nameof(Source))]
	public class ImageResourceExtension : IMarkupExtension
	{
		public string Source { get; set; } 

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
			if(Source == null)
				return null;
			var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
			return imageSource;
        }
    }
}

