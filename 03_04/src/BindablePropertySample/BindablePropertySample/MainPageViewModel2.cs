using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindablePropertySample
{
    class MainPageViewModel2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void PropertyChangedEvent([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string text;

        public string Text
        {
            get { return text; }
            set {
                text = value;
                this.PropertyChangedEvent();
            }
        }


    }
}
