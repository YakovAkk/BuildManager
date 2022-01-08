using BuildManager.ViewModels.Base;
using BuildManager.Commands.UserCabinet;
using BuildManager.Commands;
using BuildManager.GeneralFunk;
using BuildManager.Views;

namespace BuildManager.ViewModels
{
    public class UsersCabinetModelView : ViewModel
    {
        #region Command
        public ExitCommand ExitCommand { get; set; }

        private RelayCommand shopCommand;
        public RelayCommand ShopCommand
        {
            get
            {
                return shopCommand ?? (new RelayCommand(obj =>
                {
                    var changePage = new ChangePage();
                    changePage.ChangePageForMainWindow(new ShopMaterialPage());
                }));
            }
                
        }

        private RelayCommand usersItemCommand;

        public RelayCommand UsersItemCommand
        {
            get
            {
                return usersItemCommand ?? (new RelayCommand(obj =>
                {
                    var changePage = new ChangePage();
                    changePage.ChangePageForMainWindow(new UsersItemPage());
                }));
            }

        }
        #endregion

        public UsersCabinetModelView()
        {
            ExitCommand = new ExitCommand();
        }
    }
}
