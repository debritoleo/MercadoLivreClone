using MercadoLivreClone.Views.Menu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MercadoLivreClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MenuView();
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
