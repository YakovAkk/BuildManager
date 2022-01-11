using BuildManager.Commands;
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

        private List<Material> _materials = new List<Material>();
        public List<Material> materials
        {
            get { return _materials; }
            set { _materials = value; }
        }
        public static Material SelectedMaterial { get; set; }
        public static string materialName { get; set; }
        public static string materialMesurableValue { get; set; }
        public static int materialPrice { get; set; }
        public static Category materialCategory { get; set; }

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


        private RelayCommand openAddWindow;
        public RelayCommand OpenAddWindow
        {
            get
            {
                return openAddWindow ?? (new RelayCommand(obj =>
                {
                    AddNewMaterialWindow newMaterialWindow = new AddNewMaterialWindow();
                    GenerateFunk generateFunk = new GenerateFunk();
                    generateFunk.SetCenterPositionAndOpen(newMaterialWindow);
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

        private void UpdateAllMaterialView()
        {
            ShopMaterialPage.AllMaterialsView.ItemsSource = null;
            ShopMaterialPage.AllMaterialsView.Items.Clear();
            ShopMaterialPage.AllMaterialsView.ItemsSource = materials;
            ShopMaterialPage.AllMaterialsView.Items.Refresh();
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

                        db.DataMaterials.Add(new DataMaterial(user.id, SelectedMaterial.id, int.Parse(AddWindowViewModel.count)));
                        db.SaveChanges();
                    }
                }));
            }
        }

        #endregion


        public ShopViewModel()
        {

        }
    }
}
