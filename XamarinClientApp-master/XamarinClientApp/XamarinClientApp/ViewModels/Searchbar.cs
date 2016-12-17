using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using XamarinClientApp.Models;
namespace XamarinClientApp.ViewModels
{
   public class Searchbar : BindableObject
    {
        private RestClient _client =
                   new RestClient("http://mboh.azurewebsites.net/");

        private ObservableCollection<BarangKategori> listBarangVM;
        public ObservableCollection<BarangKategori> ListBarangVM
        {
            get { return listBarangVM; }
            set { listBarangVM = value; OnPropertyChanged("ListBarangVM"); }
        }

        private async void RefreshDataAsync(string Nama)
        {
            RestRequest _request = new RestRequest("api/Barang/?namabarang=" + Nama, Method.GET);
            var _response = await _client.Execute<List<BarangKategori>>(_request);
            ListBarangVM = new ObservableCollection<BarangKategori>(_response.Data);
        }

        public Searchbar(string Nama)
        {
            RefreshDataAsync(Nama);
        }
    }
}
