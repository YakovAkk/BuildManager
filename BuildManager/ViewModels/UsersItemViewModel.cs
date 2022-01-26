using BuildManager.Commands;
using BuildManager.Data;
using BuildManager.Data.Models;
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
        public static WorkWithDatabase _workWithDatabase = new WorkWithDatabase();
           
        // Materials
        private List<ResMaterial> _materials = _workWithDatabase.GetMaterialsForUser().Result;
        public List<ResMaterial> materials
        {
            get { return _materials; }
            set { _materials = value; }
        }

        // Jobbers
        private List<ResJobbers> _jobbers = _workWithDatabase.GetJobbersForUser().Result;
        public List<ResJobbers> jobbers
        {
            get { return _jobbers; }
            set { _jobbers = value; }
        }

        #region Properties
        //Materials 

        public static Material SelectedMaterial { get; set; }
        public static string materialName { get; set; }
        public static string materialMesurableValue { get; set; }
        public static int materialPrice { get; set; }
        public static string materialCount { get; set; }
        #endregion

        #region Command
        private RelayCommand back;

        public RelayCommand Back
        {
            get {
                return back ?? (new RelayCommand(obj =>
                {
                    GenerateFunk back = new GenerateFunk();
                    back.ChangePageForMainWindow(new UsersCabinetPage());
                }));
                    
            }
        }
        #endregion
    }
}
