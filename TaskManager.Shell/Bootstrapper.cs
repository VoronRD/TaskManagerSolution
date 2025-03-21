using System.Windows;
using TaskManager.Shell.ViewModels;
using TaskManager.Shell.Views;

namespace TaskManager.Shell
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Регистрация MainWindow и его ViewModel
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>("MainWindow");
        }

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    base.ConfigureModuleCatalog(moduleCatalog);

        //    // Регистрация модулей
        //    moduleCatalog.AddModule<TasksModule>();
        //    moduleCatalog.AddModule<TagsModule>();
        //    moduleCatalog.AddModule<SettingsModule>();
        //}
    }
}