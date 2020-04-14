using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDo.Models;
using ToDo.ViewModels;

namespace Todo.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ToDoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }

        public ObservableCollection<TodoItem> Items { get; }
    }
}

