using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab10
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerDemo : ContentPage
	{
		public PickerDemo()
		{
			InitializeComponent();
			BindingContext = new MonkeysPageViewModel();
		}
	}

}
