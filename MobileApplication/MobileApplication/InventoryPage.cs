using System;

using Xamarin.Forms;

namespace MobileApplication
{
	public class InventoryPage : ContentPage
	{
		public InventoryPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

