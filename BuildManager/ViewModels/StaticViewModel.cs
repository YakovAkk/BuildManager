using BuildManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.ViewModels
{
    public class StaticViewModel : ViewModel
    {
        public string SalaryJobber { get; set; } = "";

        public string AmountMaterial { get; set; } = "";
        private StaticViewModel() { }

        private static StaticViewModel _instance;

        public static StaticViewModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StaticViewModel();
            }
            return _instance;
        }
    }
}
