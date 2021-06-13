using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwiggyUserApp.viewmodels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetPropertyChanged(string propertyName) {

            if (PropertyChanged!=null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
