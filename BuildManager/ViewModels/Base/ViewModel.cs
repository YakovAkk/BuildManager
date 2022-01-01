using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BuildManager.ViewModels.Base
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected virtual void OnPropertyChanged([CallerMemberName]string ProtertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(ProtertyName));
        }

        protected virtual bool Set<T>(ref T field,T value, [CallerMemberName] string ProtertyName = null)
        {
            if (Equals(field, value))
            { 
                return false; 
            }
            else
            {
                field = value;
                OnPropertyChanged(ProtertyName);
                return true;
            }
        }
    }
}
