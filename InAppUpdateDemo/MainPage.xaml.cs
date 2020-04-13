using System.ComponentModel;
using Microsoft.AppCenter.Distribute;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace InAppUpdateDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CheckAppUpdateButton.Clicked += (s, e) =>
            {
                Distribute.CheckForUpdate();
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AppVersionLabel.Text = $"App version: {AppInfo.VersionString}";
        }
    }
}
