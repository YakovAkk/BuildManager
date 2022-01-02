using BuildManager.Commands;
using BuildManager.Commands.Base;
using BuildManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        #region Command

            
            public CloseApplicationCommand CloseAppCommand { get; }
            public AboutApplicationCommand AboutAppCommand { get; }


        #endregion

        public MainPageViewModel()
        {
            AboutAppCommand = new AboutApplicationCommand();
            CloseAppCommand = new CloseApplicationCommand();
        }
    }
}
