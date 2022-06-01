using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApp.Models;
using testApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp.Views
{
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class ResultPage : ContentPage
        {
                public ResultPage(ObservableCollection<Item> items)
                {
                        InitializeComponent();
                        this.BindingContext = new ResultPageModel(items);
                }
        }
}