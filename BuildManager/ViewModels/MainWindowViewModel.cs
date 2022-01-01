using BuildManager.Commands;
using BuildManager.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        #region Title
        private string _Title;
        public string Title
        {
            get
            { 
                return _Title;
            }

            set
            {
                Set(ref _Title, value);
            }
        }
        #endregion

        #region Command

        #region CloseAppCommand
        public ICommand CloseAppCommand { get; }

        private void OnCloseAppCommandExecuted (object o)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseAppCommandExecute (object o)
        {
            return true;
        }

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            CloseAppCommand = new LamdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
        }
    }
}
