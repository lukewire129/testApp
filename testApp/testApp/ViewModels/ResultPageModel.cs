using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using testApp.Models;

namespace testApp.ViewModels
{
        public class ResultPageModel:ObservableObject
        {
                private ObservableCollection<Item> _items;

                public ObservableCollection<Item> items
                {
                        get => _items;
                        set => SetProperty(ref _items, value);
                }

                public ResultPageModel(ObservableCollection<Item> items)
                {
                        this.items = items;
                }
        }
}
