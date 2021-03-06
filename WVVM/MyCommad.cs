﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WVVM
{
    public class MyCommad : ICommand
    {
        private Action<Object> _execute;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
        public MyCommad(Action<object> execute)
        {
            this._execute = execute;
        }
    }
}
