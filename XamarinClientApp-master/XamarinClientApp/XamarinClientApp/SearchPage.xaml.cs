using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinClientApp.ViewModels;
using XamarinClientApp.Models;
using Xamarin.Forms;

namespace XamarinClientApp
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            btnSearch.Clicked += BtnSearch_Clicked;
            btnSearchbar.Clicked += BtnSearchbar_Clicked;
        }
        protected override void OnAppearing()
        {
            this.BindingContext = new BarangViewModel();
        }



        private void BtnSearchbar_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = new Searchbar(txtsnamabar.Text);
            txtsnamabar.Text = null; 
        }

        private void BtnSearch_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = new Searchkat(txtsnamakat.Text);
            txtsnamakat.Text = null;
        }
    }
}
