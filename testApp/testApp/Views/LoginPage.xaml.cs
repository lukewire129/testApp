using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp.Views
{
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class LoginPage : ContentPage
        {
                LoginViewModel vm;
                public LoginPage()
                {
                        InitializeComponent();
                        this.BindingContext = vm = new LoginViewModel();
                }

                private void Button_Clicked(object sender, EventArgs e)
                {
                        Navigation.PushAsync(new ResultPage(vm.items));
                }
        }
}