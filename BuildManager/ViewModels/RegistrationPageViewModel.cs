using BuildManager.Commands;
using BuildManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.ViewModels
{
    public class RegistrationPageViewModel : ViewModel
    {
        #region Command
        public BackFromRegistrationApplicationCommand backFromRegistration { get; }
        #endregion

        public RegistrationPageViewModel()
        {
            backFromRegistration = new BackFromRegistrationApplicationCommand();
        }
    }
}
