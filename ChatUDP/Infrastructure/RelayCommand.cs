using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatUDP.Infrastructure
{
    class RelayCommand : ICommand
    {
        readonly Action<object> act;
        readonly Predicate<object> pre;
        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> a, Predicate<object> p = null)
        {
            act = a;
            pre = p;
        }
        public bool CanExecute(object parameter)
        {
            return pre == null ? true : pre(parameter);
        }

        public void Execute(object parameter)
        {
            act(parameter);
        }
    }
}
