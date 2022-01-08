using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BuildManager.GeneralFunk
{
    public class ChangePage
    {
        public void ChangePageForMainWindow(Page page)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = page;
                }
            }
        }
    }
}
