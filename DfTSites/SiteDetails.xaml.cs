using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DfTSites
{
	public partial class SiteDetails : ContentPage
	{
		public SiteDetails()
		{
			InitializeComponent();
		}

		async void Save_Clicked(object sender, System.EventArgs e)
		{
			var siteItem = (Site)BindingContext;
			await App.DB.SaveSiteAsync(siteItem);
			await Navigation.PopAsync();
		}

		async void Delete_Clicked(object sender, System.EventArgs e)
		{
			var siteItem = (Site)BindingContext;
			await App.DB.DeleteSiteAsync(siteItem);
			await Navigation.PopAsync();
		}
	}
}
