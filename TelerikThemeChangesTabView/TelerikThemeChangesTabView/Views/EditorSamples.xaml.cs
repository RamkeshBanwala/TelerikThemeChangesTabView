using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Input;
using TelerikThemeChangesTabView.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikThemeChangesTabView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorSamples : ContentPage
    {
        public EditorSamples()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            //var detailForm = new RadDataForm
            //{
            //    Source = new DailyLogSummary(),
            //    PropertyDataSourceProvider = new ReasonList()
            //};
            detailForm.Source = new DailyLogSummary();
            detailForm.PropertyDataSourceProvider = new ReasonList();
            detailForm.RegisterEditor(nameof(DailyLogSummary.WasInjured), EditorType.ToggleButtonEditor);
            detailForm.RegisterEditor(nameof(DailyLogSummary.Reason), EditorType.PickerEditor);
            detailForm.RegisterEditor(nameof(DailyLogSummary.Mileage), EditorType.IntegerEditor);
            detailForm.RegisterEditor(nameof(DailyLogSummary.EndTime), EditorType.TimeEditor);

        }
    }
}