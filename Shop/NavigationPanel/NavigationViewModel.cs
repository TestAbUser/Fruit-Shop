using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shop.NavigationPanel
{
    public class NavigationViewModel: INotifyPropertyChanged
    {
        private IPageViewModel? _pageViewModel;

        public IPageViewModel? PageViewModel
        {
            get => _pageViewModel;
            set
            {
                if (_pageViewModel == value) return;
                _pageViewModel = value;
                OnPropertyChanged(nameof(PageViewModel));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
