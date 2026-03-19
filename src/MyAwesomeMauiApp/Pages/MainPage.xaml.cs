using MyAwesomeMauiApp.Models;
using MyAwesomeMauiApp.PageModels;

namespace MyAwesomeMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}