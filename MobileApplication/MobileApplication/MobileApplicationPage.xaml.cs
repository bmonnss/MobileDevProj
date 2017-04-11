using Xamarin.Forms;
using System;

namespace MobileApplication
{
	public partial class MobileApplicationPage : TabbedPage
	{
		public MobileApplicationPage()
		{
			InitializeComponent();

			Children.Add(new AboutPage());
			Children.Add(new AppMainPage());
		}
	}
}
