using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace ToDo.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        internal void OnFrameworkInitializationCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
