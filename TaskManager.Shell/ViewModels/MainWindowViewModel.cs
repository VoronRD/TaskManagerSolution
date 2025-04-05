using System.Collections.ObjectModel;
using System.Diagnostics;
using Prism.Mvvm;
using Prism.Navigation.Regions;

namespace TaskManager.Shell.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
           
        }
      




    }
}