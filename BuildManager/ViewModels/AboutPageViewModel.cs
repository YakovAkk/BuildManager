using BuildManager.Commands;
using BuildManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.ViewModels
{
    public class AboutPageViewModel : ViewModel
    {
        #region Command
        public BackApplicationCommand BackAppCommand { get; }
        #endregion

        public AboutPageViewModel()
        {
            BackAppCommand = new BackApplicationCommand();
        }
    }
}
