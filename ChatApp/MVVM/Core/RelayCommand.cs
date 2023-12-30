using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    // It stores the function which will be executed 
    readonly Action<object> _execute;

    // It store the function which check whether to perform function(action) or not 
    readonly Predicate<object> _predicate;


    // Occurs when changes occur which tells whether to execute the command or not
    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }


    public RelayCommand(Action<object> execute, Predicate<object> canExecute)
    {
        if (execute == null)
        {
            throw new NullReferenceException("execute");
        }
        _execute = execute;
        _predicate = canExecute;
    }
    public RelayCommand(Action<object> execute) : this(execute, null)
    {

    }




    public bool CanExecute(object parameter)
    {
        if (_predicate != null)
        {
            return _predicate(parameter);
        }
        return true;
    }

    public void Execute(object parameter)
    {
        _execute(parameter);
    }
}
