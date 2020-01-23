using Todo.Services;
using ToDo.ViewModels;

namespace Todo.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new ToDoListViewModel(db.GetItems());
        }

        public ToDoListViewModel List { get; }

    }
}