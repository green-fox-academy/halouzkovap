using Avalonia.Controls.ApplicationLifetimes;
using Todo.Services;
using ToDo.Views;

namespace ToDo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Database db;

        public MainWindowViewModel(Database db)
        {
            this.db = db;
        }

        public IClassicDesktopStyleApplicationLifetime ApplicationLifetime { get; private set; }

        public new void OnFrameworkInitializationCompleted()
        {
            base.OnFrameworkInitializationCompleted();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var db = new Database();

                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(db),
                };
            }
        }
    }
}
