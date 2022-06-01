using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace testApp.Models
{
        public class Item :ObservableObject
        {
                public string Name { get; set; }
                private int _count = 1;

                public int count
                {
                        get => _count;
                        set => SetProperty(ref _count, value);
                }

                public void Countting()
                {
                        count++;
                }

                public void DisCounting()
                {
                        if (IsCountValueZero()) return;
                                count--;
                }

                private bool IsCountValueZero()
                {
                        return count == 0;
                }

        }
}