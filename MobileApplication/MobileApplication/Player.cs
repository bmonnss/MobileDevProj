using System;
using System.Collections.ObjectModel;

namespace MobileApplication
{
	public class Player : Characters
	{
		public int CurrentXP { get; set; }
		public ObservableCollection<Items> CurrentItems { get; set; } // What's inventory for then?

		public void AddXP(int XP)
		{
			CurrentXP += XP;
		}

		public void LevelUp()
		{
			if (CurrentXP >= 100) Level++;
			CurrentXP = 0;

			if (Level % 2 == 0)
			{
				Str++;
				Spd++;
			}
			else if (Level % 3 == 0)
			{
				Dex++;
				HP += 3;
			}
			else if (Level % 10 == 0)
			{
				Str++;
				Spd++;
				Dex++;
				HP += 5;
			}
		}

		public void GetItem(Items Item)
		{
			CurrentItems.Add(Item);
		}
	}
}
