using Microsoft.AppCenter;
using Microsoft.AppCenter.Distribute;
using Xamarin.Forms;

namespace InAppUpdateDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android={_ANDROID_APP_CENTER_SECRET_}", typeof(Distribute));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
