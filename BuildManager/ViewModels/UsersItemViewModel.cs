using BuildManager.Commands;
using BuildManager.GeneralFunk;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.ViewModels
{
    public class UsersItemViewModel : ViewModel
    {
        #region Command
        private RelayCommand back;

        public RelayCommand Back
        {
            get {
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
