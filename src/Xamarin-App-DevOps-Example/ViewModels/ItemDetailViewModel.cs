using System;

using Xamarin_App_DevOps_Example.Models;

namespace Xamarin_App_DevOps_Example.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
