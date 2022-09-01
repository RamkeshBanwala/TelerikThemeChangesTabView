using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreshMvvm;
using TelerikThemeChangesTabView.ViewModels;

namespace TelerikThemeChangesTabView.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var model = (AboutViewModel)this.BindingContext;
            await model.CoreMethods.PushPageModel<EditorSamplesViewModel>();
        }
    }
}