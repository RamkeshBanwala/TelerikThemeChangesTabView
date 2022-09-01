using System;
using System.Collections.Generic;
using TelerikThemeChangesTabView.ViewModels;
using TelerikThemeChangesTabView.Views;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(EditorSamples), typeof(EditorSamples));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
