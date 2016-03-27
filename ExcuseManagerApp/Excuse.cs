using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExcuseManagerApp.Annotations;

namespace ExcuseManagerApp
{
    class Excuse : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string LastUsed { get; set; }
        public string Description { get; set; }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
