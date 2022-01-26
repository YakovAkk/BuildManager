using BuildManager.Commands;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk;
using BuildManager.GeneralFunk.Repos;
using BuildManager.GeneralFunk.Repos.Base;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BuildManager.ViewModels
{
    public class UsersBuildingObjectViewModel : ViewModel
    {
        private static GenerateFunk _generateFunk = new GenerateFunk();
        private static WorkWithDatabase _workWithDatabase = new WorkWithDatabase();

        private static readonly User user = new UserRepos().FindUserWithActive().Result;
        public static string newBuildingObjectName { get; set; }
        public static BuildingObject selectedItem { get; set; }

        private List<BuildingObject> buildingObjects = _workWithDatabase.GetAllObjectForUser().Result;
        public List<BuildingObject> BuildingObjects
        {
            get { return buildingObjects; }
            set { buildingObjects = value; }
        }

        #region Command

        private RelayCommand backFromPage;

        public RelayCommand BackFromPage
        {
            get
            {
                return backFromPage ?? (new RelayCommand(obj =>
                {
                    var changePage = new GenerateFunk();
                    changePage.ChangePageForMainWindow(new LoginPage());
                }));

            }
        }

        private RelayCommand openAddWindow;

        public RelayCommand OpenAddWindow
        {
            get
            {
                return openAddWindow ?? (new RelayCommand(async obj =>
                {
                    _generateFunk.SetCenterPositionAndOpen(new AddNewBuildingObjectWindow());
                    using (BuildingObjectRepos repositoryBuilding = new BuildingObjectRepos())
                    {

                        await repositoryBuilding.Add(new BuildingObject()
                        {
                            Name = newBuildingObjectName,
                            UserId = user.Id
                        });

                        buildingObjects = await repositoryBuilding.GetBuildingObjectsForUser(await new UserRepos().FindUserWithActive());
                    }
                    UpdateAllMaterialView();
                }));
            }
        }

        private void UpdateAllMaterialView()
        {
            UsersBildingObjectPage.HelpingListBox.ItemsSource = null;
            UsersBildingObjectPage.HelpingListBox.Items.Clear();
            UsersBildingObjectPage.HelpingListBox.ItemsSource = BuildingObjects;
            UsersBildingObjectPage.HelpingListBox.Items.Refresh();
        }

        private RelayCommand select;

        public RelayCommand Select
        {
            get
            {
                return select ?? (new RelayCommand(obj =>
                {
                    if(selectedItem == null)
                    {
                        MessageBox.Show("Choose a building object or create a new one");
                    }
                    else
                    {
                        _generateFunk.ChangePageForMainWindow(new UsersCabinetPage());
                    }
                }));

            }
        }


        #endregion

        public UsersBuildingObjectViewModel()
        {
            newBuildingObjectName = "";
        }
    }
}
