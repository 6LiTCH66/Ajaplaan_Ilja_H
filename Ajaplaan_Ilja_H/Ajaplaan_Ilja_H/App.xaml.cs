using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ajaplaan_Ilja_H
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ajaplaan_TimePicker();
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
