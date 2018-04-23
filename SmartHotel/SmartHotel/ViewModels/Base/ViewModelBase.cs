using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmartHotel.Mvvm;
using SmartHotel.Services.Navigation;

namespace SmartHotel.ViewModels.Base
{
    public class ViewModelBase : BindableBase
    {
        private string _title;
        private bool _isBusy;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        protected INavigationService NavigationService { get; }
        public ViewModelBase()
        {
            NavigationService = ServiceLocator.Instance.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync(object navigation)
        {
            return Task.CompletedTask;
        }
    }
}
