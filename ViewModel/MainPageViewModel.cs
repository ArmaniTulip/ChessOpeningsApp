using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OpeningsApp.ViewModel
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _isPasswordHidden = true;

        public bool IsPasswordHidden
        {
            get => _isPasswordHidden;
            set
            {
                if (_isPasswordHidden != value)
                {
                    _isPasswordHidden = value;
                    OnPropertyChanged(nameof(IsPasswordHidden));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
