using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView.ViewModels
{
    public class Items
    {
        public string Name { get; set; }
    }
    public class AboutViewModel : FreshBasePageModel
    {
        private List<Items> _manufacturers;

        public AboutViewModel()
        {
            //Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            SearchItems = new List<Items>();
            SearchItems.Add(new Items() { Name = "Name 1" });
            SearchItems.Add(new Items() { Name = "Name 2" });
            SearchItems.Add(new Items() { Name = "Name 3" });
            SearchItems.Add(new Items() { Name = "Name 4" });
        }

        public List<Items> SearchItems
        {
            get
            {
                return _manufacturers;
            }
            set
            {
                _manufacturers = value;
                RaisePropertyChanged(nameof(SearchItems));
            }
        }

        public ICommand OpenWebCommand { get; }
    }
}