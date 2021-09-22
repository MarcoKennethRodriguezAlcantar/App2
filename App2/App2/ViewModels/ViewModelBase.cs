using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string nombrepropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrepropiedad));
        }
    }
}
