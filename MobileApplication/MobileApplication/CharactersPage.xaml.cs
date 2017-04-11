using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


using Xamarin.Forms;

namespace MobileApplication
{
	public partial class CharactersPage : ContentPage
	{
		public ObservableCollection<Player> PlayerList = new ObservableCollection<Player>();

		public CharactersPage()
		{
			InitializeComponent();

			Title = "Characters";

			PlayersView.ItemsSource = PlayerList;
			populateList();
			PlayersView.ItemSelected += async (sender, e) =>
			 {
				var player = e.SelectedItem as Player;
				if (e.SelectedItem == null) return;
				await Navigation.PushAsync(new PlayerDetails(player));
			 };
		}

		public void populateList()
		{
			PlayerList.Add(new Player
			{
				Name = "Kirito",
				Icon = "kirito.png",
				Str = 9,
				Dex = 7,
				Spd = 7,
				HP = 10,
				Level = 1,
				CurrentXP = 0,
				CurrentItems = new ObservableCollection<Items>()
			});
			PlayerList.Add(new Player
			{
				Name = "Asuna",
				Icon = "asuna.png",
				Str = 9,
				Dex = 5,
				Spd = 10,
				HP = 10,
				Level = 1,
				CurrentXP = 0,
				CurrentItems = new ObservableCollection<Items>()
			});
			/*
			PlayerList.Add(new Player
			{
				Name = "Leafa",
				Icon = "leafa.png",
				Str = 5,
				Dex = 7,
				Spd = 12,
				HP = 9,
				Level = 1,
				CurrentXP = 0,
				CurrentItems = new ObservableCollection<Items>()
			});*/
			PlayerList.Add(new Player
			{
				Name = "Sinon",
				Icon = "sinon.png",
				Str = 14,
				Dex = 12,
				Spd = 2,
				HP = 8,
				Level = 1,
				CurrentXP = 0,
				CurrentItems = new ObservableCollection<Items>()
			});
			PlayerList.Add(new Player
			{
				Name = "Yuuki",
				Icon = "yuuki.png",
				Str = 12,
				Dex = 10,
				Spd = 9,
				HP = 9,
				Level = 1,
				CurrentXP = 0,
				CurrentItems = new ObservableCollection<Items>()
			});
		}
	}
}
