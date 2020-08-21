using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MercadoLivreClone.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : MasterDetailPage
    {
        public MenuView()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MenuDetail());
        }
    }
}