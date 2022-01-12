using BuildManager.Data;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BuildManager.GeneralFunk
{
    public class GenerateFunk
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

        public List<Material> GetMaterials()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.Materials.ToList();
            }
        }

        

        public List<JobPerson> GetPeople()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.JobPeople.ToList();
            }
        }

        public List<JobPerson> GetJobbers()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.JobPeople.ToList();
            }
        }

        public List<User> GetUsers()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.Users.ToList();
            }
        }

        public void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        public string EditMatrial(Material oldMateral, string newName, string newMesValue, int newPrice, Category newCategory)
        {
            string result = "Такого сотрудника не существует";
            using (AppDBContent db = new AppDBContent())
            {
                //check user is exist
                Material material = db.Materials.FirstOrDefault(p => p.id == oldMateral.id);
                if (material != null)
                {
                    material.name = newName;
                    material.mesurableValue = newMesValue;
                    material.price = newPrice;
                    material.CategoryId = newCategory.Id;
                    db.SaveChanges();
                    result = "Success! Material " + material.name + " changed";
                }
            }
            return result;
        }

        public List<ResMaterial> GetMaterialsForUser()
        {
            using (AppDBContent db = new AppDBContent())
            {
                var mat = new List<ResMaterial>();
                var dataMaterial = db.DataMaterials.ToList();
                var user = db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                var material = db.Materials.ToList();
                foreach (var item in dataMaterial)
                {
                    if(item.User_id == user.id)
                    {
                        var resMaterial = material.Where(m => m.id == item.Material_id).FirstOrDefault();
                        mat.Add(new ResMaterial() { material = resMaterial,Count = item.Count ,
                            FullPrice = item.Count * resMaterial.price });
                    }
                }

                return mat;
            }
        }

        public List<ResJobbers> GetJobbersForUser()
        {
            using (AppDBContent db = new AppDBContent())
            {
                var job = new List<ResJobbers>();
                var dataPeople = db.DataPeople.ToList();
                var user = db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                var Jobbers = db.JobPeople.ToList();
                foreach (var item in dataPeople)
                {
                    if (item.User_id == user.id)
                    {
                        var resPerson = Jobbers.Where(m => m.id == item.JobPerson_id).FirstOrDefault();
                        job.Add(new ResJobbers()
                        {
                            jobPerson = resPerson,
                            Salary = item.Salary
                        });
                    }
                }

                return job;
            }
        }
    }
}
