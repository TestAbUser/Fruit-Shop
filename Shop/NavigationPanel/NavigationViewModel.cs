using Shop.CartPage;
using Shop.HomePage;
using Shop.ProfilePage;
using Shop.UtilityClasses;
using System.Windows.Input;

namespace Shop.NavigationPanel
{
    public class NavigationViewModel : ObservableObject
    {
        private IPageViewModel? _pageViewModel;
        private List<IPageViewModel>? _pageViewModels;

        private ICommand? _switchPageCommand;

        public NavigationViewModel()
        {
            ProductModel product = new();
            PageViewModels.Add(new HomePageViewModel(product));
            PageViewModels.Add(new CartViewModel(product));
            PageViewModels.Add(new ProfileViewModel());

            PageViewModel = PageViewModels[0];
        }

        public ICommand SwitchPageCommand =>
            _switchPageCommand ??= new RelayCommand(vm => SwitchPage((IPageViewModel?)vm));

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

        private void SwitchPage(IPageViewModel? viewModel)
        {
            ArgumentNullException.ThrowIfNull(viewModel, nameof(viewModel));

            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            PageViewModel = PageViewModels.FirstOrDefault(v => v == viewModel);
        }
    }
}
