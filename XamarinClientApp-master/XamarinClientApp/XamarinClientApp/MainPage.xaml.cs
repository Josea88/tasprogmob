using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinClientApp.Models;
namespace XamarinClientApp
{
    public partial class MainPage : MasterDetailPage
    {
        public List<Pageslide> menuList { get; set; }

        public MainPage()
        {

            InitializeComponent();

            menuList = new List<Pageslide>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new Pageslide() { Title = "Barang", Icon = "itemIcon1.png", TargetType = typeof(BarangPage) };
            var page2 = new Pageslide() { Title = "Kategori", Icon = "itemIcon2.png", TargetType = typeof(KategoriPage) };
            var page3 = new Pageslide() { Title = "Jenis Motor", Icon = "itemIcon3.png", TargetType = typeof(JenisMotorPage) };
        var page4 = new Pageslide() { Title = "Search", Icon = "itemIcon4.png", TargetType = typeof(SearchPage) };


            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
         menuList.Add(page4);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(BarangPage)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (Pageslide)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
    
