using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;

namespace MercadoLivreClone.Droid.Activities
{
    [Activity(Label = "Mercado Livre Clone", Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
        }
    }
}