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

        

        public MainWindowViewModel()
        {
            Title = "My Proj";
        }
    }
}
