using Android.Content.Res;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using testApp.Models;
using testApp.Views;
using Xamarin.Forms;

namespace testApp.ViewModels
{
        public class LoginViewModel : ObservableObject
        {
                private ObservableCollection<Item> _items = new ObservableCollection<Item>()
                {
                        new Item()
                        {
                                Name = "아이템1"
                        },
                        new Item()
                        {
                                Name = "아이템2"
                        },
                        new Item()
                        {
                                Name = "아이템3"
                        },
                        new Item()
                        {
                                Name = "아이템4"
                        },
                        new Item()
                        {
                                Name = "아이템5"
                        },
                        new Item()
                        {
                                Name = "아이템6"
                        },
                        new Item()
                        {
                                Name = "아이템7"
                        }
                };

                public ObservableCollection<Item> items
                {
                        get => _items;
                        set => SetProperty(ref  _items, value);
                }

                public LoginViewModel()
                {
                       
                }

                public RelayCommand<Item> MinusItem => new RelayCommand<Item>((item) =>
                {
                        item.DisCounting();
                });

                public RelayCommand<Item> PlusItem => new RelayCommand<Item>((item) =>
                {
                        item.Countting();
                });

                public RelayCommand Confirm => new RelayCommand(() =>
                {
                });
        }
}
