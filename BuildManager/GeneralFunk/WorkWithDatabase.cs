﻿using BuildManager.Data;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk
{
    public class WorkWithDatabase
    {
        public List<BuildingObject> GetAllObjectForUser()
        {
            using (AppDBContent db = new AppDBContent())
            {

                var userTsk = new Task<User>(() => GetUser());
                var res = userTsk.ContinueWith(t => GetBuildingObjectsForUser(userTsk.Result));
                userTsk.Start();
                return res.Result;

            }
        }
        private List<BuildingObject> GetBuildingObjectsForUser(User user)
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.BuildingObjects.Where(o => o.User_id == user.id).ToList();
            }
        }
        public User GetUser()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
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
        public List<Category> GetCategories()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.Categories.ToList();
            }
        }
        public List<User> GetUsers()
        {
            using (AppDBContent db = new AppDBContent())
            {
                return db.Users.ToList();
            }
        }
        public List<ResMaterial> GetMaterialsForUser()
        {
            using (AppDBContent db = new AppDBContent())
            {
                var mat = new List<ResMaterial>();

                var dataMaterial = db.DataMaterials.ToList();
                var user = db.Users.Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                var buildObj = db.BuildingObjects.Where(o => o.User_id == user.id && UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();
                var material = db.Materials.ToList();

                // ParallelLoopResult result = Parallel.ForEach<int>(dataMaterial, Factorial);
                foreach (var item in dataMaterial)
                {
                    if (item.BuildObject_id == buildObj.Id)
                    {
                        var resMaterial = material.Where(m => m.id == item.Material_id).FirstOrDefault();
                        mat.Add(new ResMaterial()
                        {
                            material = resMaterial,
                            Count = item.Count,
                            FullPrice = item.Count * resMaterial.price
                        });
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
                var user = GetUsers().Where(u => u.login == LoginPageViewModel.UsersLogin).FirstOrDefault();
                var buildObj = db.BuildingObjects.Where(o => o.User_id == user.id && UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();
                var Jobbers = db.JobPeople.ToList();
                foreach (var item in dataPeople)
                {
                    if (item.BuildObject_id == buildObj.Id)
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
        public void AddMaterial(string? materialName, string? materialMesurableValue, int materialPrice, Category materialCategory)
        {
            using (AppDBContent db = new AppDBContent())
            {
                db.Materials.Add(new Material()
                {
                    name = materialName,
                    mesurableValue = materialMesurableValue,
                    price = materialPrice,
                    CategoryId = materialCategory.Id
                });
                db.SaveChanges();
            }
        }
        public void AddUser(string? jobberName, string? jobberSurname, string jobberPhone)
        {
            using (AppDBContent db = new AppDBContent())
            {
                db.JobPeople.Add(new JobPerson() { name = jobberName, Surname = jobberSurname, Phone = jobberPhone });
                db.SaveChanges();
            }
        }
        public string EditMatrial(Material oldMateral, string newName, string newMesValue, int newPrice, Category newCategory)
        {
            string result = "This material does not exist.";
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
                    result = "Success! Material " + material.name + "was changed";
                }
            }
            return result;
        }
        public string EditJobber(JobPerson oldJobber, string jobberName, string jobberSurname, string jobberPhone)
        {
            string result = "This employee does not exist.";

            using (AppDBContent db = new AppDBContent())
            {
                JobPerson person = db.JobPeople.FirstOrDefault(p => p.id == oldJobber.id);
                if (person != null)
                {
                    person.name = jobberName;
                    person.Surname = jobberSurname;
                    person.Phone = jobberPhone;
                    db.SaveChanges();

                    result = "Success! Jobber " + person.name + "was changed";
                }
            }
            return result;
        }
    }
}
