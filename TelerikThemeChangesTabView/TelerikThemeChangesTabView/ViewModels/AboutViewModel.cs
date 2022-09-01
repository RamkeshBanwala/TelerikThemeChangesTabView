using FreshMvvm;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView.ViewModels
{
    public class AboutViewModel : FreshBasePageModel
    {
        public AboutViewModel()
        {
            //Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}