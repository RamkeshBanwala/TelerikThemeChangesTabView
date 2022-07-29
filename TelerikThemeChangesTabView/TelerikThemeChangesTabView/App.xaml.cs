using System;
using TelerikThemeChangesTabView.Services;
using TelerikThemeChangesTabView.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikThemeChangesTabView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
