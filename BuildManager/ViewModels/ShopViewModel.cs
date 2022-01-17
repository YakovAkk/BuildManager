﻿using BuildManager.Commands;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System.Collections.Generic;
using System.Linq;
using BuildManager.Data;
using System.Windows;
using System;
using BuildManager.Data.DataBase;

namespace BuildManager.ViewModels
{
    public class ShopViewModel : ViewModel
    {
        public static GenerateFunk _generateFunk = new GenerateFunk();

        // Materials
        private List<Material> _materials = new List<Material>();
        public List<Material> materials
        {
            get { return _materials; }
            set { _materials = value; }
        }

        public static Material SelectedMaterial { get; set; }

        // Jobbers

        public static JobPerson SelectedJobber { get; set; }

        private List<JobPerson> _jobbers = _generateFunk.GetJobbers();
        public List<JobPerson> jobbers
        {
            get { return _jobbers; }
            set { _jobbers = value; }
        }

        // Add matreial to DB

        private List<Category> allCatigories = _generateFunk.GetCategories();
        public List<Category> AllCatigories
        {
            get { return allCatigories; }
            set { allCatigories = value; }
        }
        public static string materialName { get; set; }
        public static string materialMesurableValue { get; set; }
        public static int materialPrice { get; set; }
        public static Category materialCategory { get; set; }

        // Add jobber to DB
        public static string JobberName { get; set; }
        public static string JobberSurname { get; set; }
        public static string JobberPhone { get; set; }




        #region Command
        private RelayCommand back;
        public RelayCommand Back
        {
            get
            {
                return back ?? (new RelayCommand(obj =>
                {
                    GenerateFunk back = new GenerateFunk();
                    back.ChangePageForMainWindow(new UsersCabinetPage());
                }));
            }
        }

        private RelayCommand openAddMaterialWindow;
        public RelayCommand OpenAddMaterialWindow
        {
            get
            {
                return openAddMaterialWindow ?? (new RelayCommand(obj =>
                {
                    AddNewMaterialWindow newMaterialWindow = new AddNewMaterialWindow();
                    _generateFunk.SetCenterPositionAndOpen(newMaterialWindow);
                }));
            }
        }


        private RelayCommand openAddJobberWindow;
        public RelayCommand OpenAddJobberWindow
        {
            get
            {
                return openAddJobberWindow ?? (new RelayCommand(obj =>
                {
                    AddNewJobberWindow addJobberWindow = new AddNewJobberWindow();
                    _generateFunk.SetCenterPositionAndOpen(addJobberWindow);
                }));
            }
        }

        private RelayCommand openEditWindow;
        public RelayCommand OpenEditWindow
        {
            get
            {
                return openEditWindow ?? (new RelayCommand(obj =>
                {
                    EditMaterialWindow newMaterialWindow = new EditMaterialWindow(SelectedMaterial);
                    _generateFunk.SetCenterPositionAndOpen(newMaterialWindow);
                }));
            }
        }

        private RelayCommand materialsCement;
        public RelayCommand MaterialsCement
        {
            get
            {
                return materialsCement ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId ==  ((int)CategoryEnum.Cement)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand materialsTile;
        public RelayCommand MaterialsTile
        {
            get
            {
                return materialsTile ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId == ((int)CategoryEnum.Tile)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand materialsBrick;
        public RelayCommand MaterialsBrick
        {
            get
            {
                return materialsBrick ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId == ((int)CategoryEnum.Brick)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand materialsGasBlock;
        public RelayCommand MaterialsGasBlock
        {
            get
            {
                return materialsGasBlock ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId == ((int)CategoryEnum.GasBlock)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand materialsSlate;
        public RelayCommand MaterialsSlate
        {
            get
            {
                return materialsSlate ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId == ((int)CategoryEnum.Slate)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand materialsStyrofoam;
        public RelayCommand MaterialsStyrofoam
        {
            get
            {
                return materialsStyrofoam ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId == ((int)CategoryEnum.Styrofoam)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }
        private RelayCommand materialsFurniture;
        public RelayCommand MaterialsFurniture
        {
            get
            {
                return materialsFurniture ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials().Where(m => m.CategoryId == ((int)CategoryEnum.Furniture)).ToList();
                    UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand allMaterial;
        public RelayCommand AllMaterial
        {
            get
            {
                return allMaterial ?? (new RelayCommand(obj =>
                {
                    _materials = _generateFunk.GetMaterials();
                     UpdateAllMaterialView();
                }));
            }
        }

        private RelayCommand addToBasket;
        public RelayCommand AddToBasket
        {
            get
            {
                return addToBasket ?? (new RelayCommand(obj =>
                {
                    _generateFunk.SetCenterPositionAndOpen(new AddWindow());

                    using (AppDBContent db = new AppDBContent())
                    {
                        var user = db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                        var buildObj = db.BuildingObjects.Where(o => o.User_id == user.id && UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();

                        try
                        {
                            db.DataMaterials.Add(new DataMaterial(buildObj.Id, SelectedMaterial.id, int.Parse(AddWindowViewModel.count)));
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Dude it's symbols , i don't know how these convert to integer, if you know help me pls");
                        }
                      
                    }
                }));
            }
        }
        private RelayCommand addJobberToBuilding;
        public RelayCommand AddJobberToBuilding
        {
            get {
                return addJobberToBuilding ?? (new RelayCommand(obj =>
                {
                    _generateFunk.SetCenterPositionAndOpen(new AddJobberWindow());

                    using (AppDBContent db = new AppDBContent())
                    {
                        var user = db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                        var buildObj = db.BuildingObjects.Where(o => o.User_id == user.id && UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();

                        try
                        {
                            db.DataPeople.Add(new DataPerson(buildObj.Id, SelectedJobber.id, int.Parse(AddJobberViewModel.count)));
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Invalid data, do you think, the jobber wants to earn symbols instead of dollars?");
                        }
                        
                        
                    }
                }));
            }
        }

        private RelayCommand addNewMaterial;
        public RelayCommand AddNewMaterial
        {
            get
            {
                return addNewMaterial ?? (new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (materialName == null || materialName.Replace(" ", "").Length == 0)
                    {
                        MessageBox.Show("Fill the  name");
                    }
                    if (materialPrice == 0)
                    {
                        MessageBox.Show("Fill the Price");
                        return;
                    }
                    if (materialMesurableValue == null || materialName.Replace(" ", "").Length == 0)
                    {
                        MessageBox.Show("Fill the MesurableValue");
                    }
                    if (materialCategory == null)
                    {
                        MessageBox.Show("Change Category");
                    }
                    else
                    {
                        _generateFunk.AddMaterial(materialName, materialMesurableValue, materialPrice, materialCategory);
                        UpdateAllMaterialView();

                        MessageBox.Show("Success");
                        wnd.Close();
                    }
                }));
            }
        }
        private RelayCommand addNewJobber;
        public RelayCommand AddNewJobber
        {
            get
            {
                return addNewJobber ?? (new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (JobberName == null || JobberName.Replace(" ", "").Length == 0)
                    {
                        MessageBox.Show("Fill the  name");
                    }
                    if (JobberSurname == null || JobberSurname.Replace(" ", "").Length == 0)
                    {
                        MessageBox.Show("Fill the MesurableValue");
                    }
                    if (JobberPhone == null || JobberPhone.Replace(" ", "").Length == 0)
                    {
                        MessageBox.Show("Fill the MesurableValue");
                    }
                    else
                    {
                        _generateFunk.AddUser(JobberName, JobberSurname, JobberPhone);
                        MessageBox.Show("Success");
                        _jobbers = _generateFunk.GetJobbers();
                        UpdateAllJobberlView();
                       
                        wnd.Close();
                    }
                }));
            }
        }

        private RelayCommand editMaterial;
        public RelayCommand EditMaterial {
            get 
            {
                return editMaterial ?? (new RelayCommand(obj =>
                {
                    try
                    {
                        if (SelectedMaterial != null && materialCategory != null && materialName.Length != 0 &&
                    materialMesurableValue.Length != 0 && materialPrice != 0)
                        {
                            MessageBox.Show(_generateFunk.EditMatrial(SelectedMaterial, materialName, materialMesurableValue, materialPrice, materialCategory));
                            UpdateAllMaterialView();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong!");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    
                    
                }));
            }
        }



        #endregion


        private void UpdateAllMaterialView()
        {
            ShopMaterialPage.AllMaterialsView.ItemsSource = null;
            ShopMaterialPage.AllMaterialsView.Items.Clear();
            ShopMaterialPage.AllMaterialsView.ItemsSource = materials;
            ShopMaterialPage.AllMaterialsView.Items.Refresh();
        }

        private void UpdateAllJobberlView()
        {
            ShopMaterialPage.AllJobbersView.ItemsSource = null;
            ShopMaterialPage.AllJobbersView.Items.Clear();
            ShopMaterialPage.AllJobbersView.ItemsSource = jobbers;
            ShopMaterialPage.AllJobbersView.Items.Refresh();
        }
        public ShopViewModel()
        {

        }
    }
}
