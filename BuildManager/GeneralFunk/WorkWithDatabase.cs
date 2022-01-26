using BuildManager.Data;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos;
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
        public async Task<List<BuildingObject>> GetAllObjectForUser()
        {
            var user = await new UserRepos().FindUserWithActive();
            var res = await new BuildingObjectRepos().GetBuildingObjectsForUser(user);        
            return res;
        }
        public async Task<List<ResMaterial>> GetMaterialsForUser()
        {
            var mat = new List<ResMaterial>();

            var dataMaterial = Task.Run(() => new DataMaterialRepos().GetAll());
            var user = Task.Run(() => new UserRepos().FindUserWithActive());
            var material = Task.Run(() => new MaterialRepos().GetAll());

            await user;

            var buildObj = (await new BuildingObjectRepos().GetAll()).Where(o => o.UserId == user.Id &&
            UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();

            foreach (var item in await dataMaterial)
            {
                if (item.BuildingObjectId == buildObj.Id)
                {
                    var resMaterial = (await material).Where(m => m.Id == item.MaterialId).FirstOrDefault();
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
        public async Task<List<ResJobbers>> GetJobbersForUser()
        {
            var job = new List<ResJobbers>();

            var dataPeople = new DataPersonRepos().GetAll();

            var user = await new UserRepos().FindUserWithActive();

            var buildObj = (await new BuildingObjectRepos().GetAll()).Where(o => o.UserId == user.Id &&
            UsersBuildingObjectViewModel.selectedItem.Name == o.Name).FirstOrDefault();

            var Jobbers = new JobPersonRepos().GetAll();
            foreach (var item in await dataPeople)
            {
                if (item.BuildingObjectId == buildObj.Id)
                {
                    var resPerson = (await Jobbers).Where(m => m.Id == item.JobPersonId).FirstOrDefault();
                    job.Add(new ResJobbers()
                    {
                        jobPerson = resPerson,
                        Salary = item.Salary
                    });
                }
            }

            return job;

        }
        public async Task AddMaterial(string? materialName, string? materialMesurableValue, int materialPrice, Category materialCategory)
        {
                await new MaterialRepos().Add(new Material()
                {
                    Name = materialName,
                    MesurableValue = materialMesurableValue,
                    Price = materialPrice,
                    CategoryId = materialCategory.Id
                });
        }
        public async Task AddJobber(string jobberName, string jobberSurname, string jobberPhone)
        {
           await new JobPersonRepos().Add(new JobPerson() { Name = jobberName, SurName = jobberSurname, Phone = jobberPhone });   
        }
        public async Task<string> EditMatrial(Material oldMateral, string newName, string newMesValue, int newPrice, Category newCategory)
        {
            return await new MaterialRepos().EditMaterial(oldMateral,newName,newMesValue,newPrice,newCategory);
        }
        public async Task<string> EditJobber(JobPerson oldJobber, string jobberName, string jobberSurname, string jobberPhone)
        {
            return await new JobPersonRepos().EditMaterial(oldJobber,jobberName,jobberSurname,jobberPhone);
        }
    }
}
