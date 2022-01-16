using BuildManager.Commands;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System.Collections.Generic;
using System.Linq;

namespace BuildManager.ViewModels
{
    public class UsersBuildingObjectViewModel : ViewModel
    {
        public static GenerateFunk _generateFunk = new GenerateFunk();

        public static string newBuildingObjectName { get; set; }



        public static BuildingObject selectedItem { get; set; }

        private List<BuildingObject> buildingObjects = _generateFunk.GetAllObjectForUser();
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
                return openAddWindow ?? (new RelayCommand(obj =>
                {
                    _generateFunk.SetCenterPositionAndOpen(new AddNewBuildingObjectWindow());

                    using (AppDBContent db = new AppDBContent())
                    {
                        var user = db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                        db.BuildingObjects.Add(new BuildingObject() { Name = newBuildingObjectName, User_id = user.id });
                        db.SaveChanges();
                    }
                    buildingObjects = _generateFunk.GetAllObjectForUser();
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
                    _generateFunk.ChangePageForMainWindow(new UsersCabinetPage());

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
