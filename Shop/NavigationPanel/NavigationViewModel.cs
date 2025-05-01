using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace Shop.NavigationPanel
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        private IPageViewModel? _pageViewModel;
        private List<IPageViewModel>? _pageViewModels;

        private ICommand? _switchPageCommand;

        public ICommand SwitchPageCommand =>
            _switchPageCommand ??= new RelayCommand(vm => SwitchPage((IPageViewModel)vm));

        public List<IPageViewModel> PageViewModels => _pageViewModels ??= [];

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

        private void SwitchPage(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            PageViewModel = PageViewModels.FirstOrDefault(v => v == viewModel);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
