using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApplication
{
	public partial class ItemsDetails : ContentPage
	{
		public ItemsDetails()
		{
			InitializeComponent();
		}

		public ItemsDetails(Items item)
		{
			InitializeComponent();

			this.Title = item.Name;

			ImageXAML.Source = item.Image;

			DetailsXAML.Text = $" Description: {item.Description} \n\n" +
				$" Str: {item.StrValue}\n Dex: {item.DexValue}\n Spd: {item.SpdValue}\n HP: {item.HPValue}";

		}
	}
}
