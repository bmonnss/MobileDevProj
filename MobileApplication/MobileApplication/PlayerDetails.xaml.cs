using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApplication
{
	public partial class PlayerDetails : ContentPage
	{
		public PlayerDetails()
		{
			InitializeComponent();
		}

		public PlayerDetails (Player player)
		{
			InitializeComponent();

			this.Title = player.Name;

			CharImage.Source = player.Icon;

			CharDetails.Text = $" Level: {player.Level}\n HP: {player.HP}\n Str: {player.Str}\n Dex: {player.Dex}\n Spd: {player.Spd}";
		}
	}
}
