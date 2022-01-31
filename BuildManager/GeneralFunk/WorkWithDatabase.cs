using BuildManager.Data;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos;
using BuildManager.GeneralFunk.SingletonForActiveUser;
using BuildManager.ViewModels;
using Microsoft.EntityFrameworkCore;
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
            var user = SingletonActiveUser.GetInstance().GetUser();
            var res =  new BuildingObjectRepos().GetBuildingObjectsForUser(user);        
            return res;
        }
        public List<ResMaterial> GetMaterialsForUser()
        {
            var mat = new List<ResMaterial>();
            var dataMaterial = new DataMaterialRepos().GetAll();
            var user = SingletonActiveUser.GetInstance().GetUser();
            var buildObj = new BuildingObjectRepos().GetAll().Where(o => o.UserId == user.Id && 
            UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();
            var material = new MaterialRepos().GetAll();

            // ParallelLoopResult result = Parallel.ForEach<int>(dataMaterial, Factorial);
            foreach (var item in dataMaterial)
            {
                if (item.BuildingObjectId == buildObj.Id)
                {
                    var resMaterial = material.Where(m => m.Id == item.MaterialId).FirstOrDefault();
                    mat.Add(new ResMaterial()
                    {
                        material = resMaterial,
                        Count = item.Count,
                        FullPrice = item.Count * resMaterial.Price
                    });
                }
            }

            return mat;

        }
        public List<ResJobbers> GetJobbersForUser()
        {
            var job = new List<ResJobbers>();
            var dataPeople = new DataPersonRepos().GetAll();
            var user = SingletonActiveUser.GetInstance().GetUser();
            var buildObj = new BuildingObjectRepos().GetAll().Where(o => o.UserId == user.Id && UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();
            var Jobbers = new JobPersonRepos().GetAll();
            foreach (var item in dataPeople)
            {
                if (item.BuildingObjectId == buildObj.Id)
                {
                    var resPerson = Jobbers.Where(m => m.Id == item.JobPersonId).FirstOrDefault();
                    job.Add(new ResJobbers()
                    {
                        jobPerson = resPerson,
                        Salary = item.Salary
                    });
                }
            }
            return job;

        }
        public void AddMaterial(string? materialName, string? materialMesurableValue, int materialPrice, Category materialCategory)
        {
                new MaterialRepos().Add(new Material()
                {
                    Name = materialName,
                    MesurableValue = materialMesurableValue,
                    Price = materialPrice,
                    CategoryId = materialCategory.Id
                });
        }
        public void AddJobber(string? jobberName, string? jobberSurname, string jobberPhone)
        {
           new JobPersonRepos().Add(new JobPerson() { Name = jobberName, SurName = jobberSurname, Phone = jobberPhone });   
        }
        public string EditMatrial(Material oldMateral, string newName, string newMesValue, int newPrice, Category newCategory)
        {
            return new MaterialRepos().EditMaterial(oldMateral,newName,newMesValue,newPrice,newCategory);
        }
        public string EditJobber(JobPerson oldJobber, string jobberName, string jobberSurname, string jobberPhone)
        {
            return new JobPersonRepos().EditMaterial(oldJobber,jobberName,jobberSurname,jobberPhone);
        }
    }
}
