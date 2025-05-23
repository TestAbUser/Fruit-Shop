﻿using System.Windows.Input;

namespace Shop.UtilityClasses
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<bool>? _canExecute;

        public RelayCommand(Action<object?> execute) : this(execute, null) { }

        public RelayCommand(Action<object?> execute, Func<bool>? canExecute)
        {
            _execute = execute
            ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public virtual bool CanExecute(object? parameter) => _canExecute == null || _canExecute();

        public virtual void Execute(object? parameter) { _execute(parameter); }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
