using System;

using Xamarin.Forms;

namespace MobileApplication
{
	public class CharactersPage : ContentPage
	{
		public CharactersPage()
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

