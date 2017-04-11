using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApplication
{
	public partial class AppMainPage : ContentPage
	{
		public AppMainPage()
		{
			InitializeComponent();

			this.Title = "Application";
		}

		async void OnScore(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ScorePage());
		}

		async void OnCharacter(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CharactersPage());
		}

		async void OnInventory(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new InventoryPage());
		}

		async void OnMonsters(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MonstersPage());
		}

		async void OnItems(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ItemsPage());
		}

		async void OnBattle(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new BattlePage());
		}
	}
}
