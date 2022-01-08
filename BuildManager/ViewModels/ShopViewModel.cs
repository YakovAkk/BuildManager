using BuildManager.Commands;
using BuildManager.GeneralFunk;
using BuildManager.ViewModels.Base;
using BuildManager.Views;

namespace BuildManager.ViewModels
{
    public class ShopViewModel : ViewModel
    {
        #region Command
        private RelayCommand back;

        public RelayCommand Back
        {
            get
            {
                return back ?? (new RelayCommand(obj =>
                {
                    ChangePage back = new ChangePage();
                    back.ChangePageForMainWindow(new UsersCabinetPage());
                }));

            }
        }
        #endregion
    }
}
