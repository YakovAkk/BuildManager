using BuildManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.DataBase
{
    public class DataForDatabase
    {
        public void AddData()
        {
            using(AppDBContent db = new AppDBContent())
            {
                AddCategories();
                AddJobPeople();
                AddMAterials();

            };
        }

        public void AddCategories()
        {
            using (AppDBContent db = new AppDBContent())
            {
                db.Categories.AddRange(
                    new Category() { Name = "Cement" },
                    new Category() { Name = "Tile" },
                    new Category() { Name = "Brick" },
                    new Category() { Name = "Gas Block" },
                    new Category() { Name = "Slate" },
                    new Category() { Name = "Styrofoam" },
                    new Category() { Name = "Furniture" });

                db.SaveChanges();
            };
        }
        public void AddJobPeople()
        {
            using (AppDBContent db = new AppDBContent())
            {
                db.JobPeople.AddRange(
                        new JobPerson() { Name = "Alex", SurName = "Alexanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Dima", SurName = "Dimanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "David", SurName = "Davidanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Yakov", SurName = "Yakovanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Vova", SurName = "Vovanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Egor", SurName = "Egoranrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Artem", SurName = "Artemanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Vanya", SurName = "Vanyanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Sergey", SurName = "Sergeyanrovish", Phone = "0987654321" },
                        new JobPerson() { Name = "Andrey", SurName = "Andreynrovish", Phone = "0987654321" }
                    );

                db.SaveChanges();
            };
        }
        public void AddMAterials()
        {
            using (AppDBContent db = new AppDBContent())
            {
                db.Materials.AddRange(
                        new Material() { Name = "Цемент ПЦ II", MesurableValue = "bag", Price = 160, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { Name = "Цемент ПЦ II/A", MesurableValue = "bag", Price = 85, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { Name = "Цемент ПЦ І-500Р", MesurableValue = "bag", Price = 175, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { Name = "Цемент ПЦ ІІ/Б", MesurableValue = "bag", Price = 135, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { Name = "Цемент ПЦ ІІ/Б-400", MesurableValue = "bag", Price = 75, CategoryId = ((int)CategoryEnum.Cement) },

                        new Material() { Name = "Керамогранит Geotiles Aura", MesurableValue = "square meter", Price = 959, CategoryId = ((int)CategoryEnum.Tile) }, 
                        new Material() { Name = "ABK Ceramica Blend", MesurableValue = "square meter", Price = 2150, CategoryId = ((int)CategoryEnum.Tile) },
                        new Material() { Name = "ABK Ceramica Eco", MesurableValue = "square meter", Price = 1700, CategoryId = ((int)CategoryEnum.Tile) },

                        new Material() { Name = "КИРПИЧ КЕРАМИЧЕСКИЙ PROKERAM", MesurableValue = "one thing", Price = 7, CategoryId = ((int)CategoryEnum.Brick) },
                        new Material() { Name = "Кирпич пенодиатомитовый теплоизоляционный", MesurableValue = "one thing", Price = 31, CategoryId = ((int)CategoryEnum.Brick) },
                        new Material() { Name = "Кирпич красный рядовой", MesurableValue = "one thing", Price = 6, CategoryId = ((int)CategoryEnum.Brick) },

                        new Material() { Name = "Газобетонный блок SLS", MesurableValue = "one thing", Price = 79, CategoryId = ((int)CategoryEnum.GasBlock) },
                        new Material() { Name = "Блок газобетонный AЕROC D300", MesurableValue = "one thing", Price = 30, CategoryId = ((int)CategoryEnum.GasBlock) },
                        new Material() { Name = "Газоблок Перегородковий", MesurableValue = "one thing", Price = 24, CategoryId = ((int)CategoryEnum.GasBlock) },

                        new Material() { Name = "Шифер 8-волновой", MesurableValue = "bone thingag", Price = 19, CategoryId = ((int)CategoryEnum.Slate) },
                        new Material() { Name = "Асбостальной лист", MesurableValue = "one thing", Price = 15, CategoryId = ((int)CategoryEnum.Slate) },
                        new Material() { Name = "Металлочерепица", MesurableValue = "square meter", Price = 1885, CategoryId = ((int)CategoryEnum.Slate) },
                        new Material() { Name = "Лист волна", MesurableValue = "one thing", Price = 10, CategoryId = ((int)CategoryEnum.Slate) },

                        new Material() { Name = "Плиты пенополистирольные Anserglob", MesurableValue = "one box", Price = 295, CategoryId = ((int)CategoryEnum.Styrofoam) },
                        new Material() { Name = "Пенополистирол Penoboard", MesurableValue = "one box", Price = 1113, CategoryId = ((int)CategoryEnum.Styrofoam) },
                        new Material() { Name = "Пенопласт EPS 50", MesurableValue = "square meter", Price = 1326, CategoryId = ((int)CategoryEnum.Styrofoam) },
                        new Material() { Name = "Плиты пенополистирольные ", MesurableValue = "one box", Price = 400, CategoryId = ((int)CategoryEnum.Styrofoam) },

                        new Material() { Name = "Кресло геймерское Cougar", MesurableValue = "one thing", Price = 8000, CategoryId = ((int)CategoryEnum.Furniture) },
                        new Material() { Name = "Комплект садовой мебели Home Garden", MesurableValue = "one thing", Price = 44000, CategoryId = ((int)CategoryEnum.Furniture) },
                        new Material() { Name = "Кровать Соня", MesurableValue = "one thing", Price = 2000, CategoryId = ((int)CategoryEnum.Furniture) },
                        new Material() { Name = "Комплект садовой мебели з полиротанга ", MesurableValue = "one thing", Price = 30000, CategoryId = ((int)CategoryEnum.Furniture) }
                    );

                db.SaveChanges();
            };
        }

        public DataForDatabase()
        {
            //Materials = new List<Material>()
            //{


            //    new Material(){Name = "Цемент ПЦ II",MesurableValue="bag",Price = 160,CategoryId = 1},
            //    new Material(){Name = "Цемент ПЦ II/A",MesurableValue="bag",Price = 85,CategoryId = 1},
            //    new Material(){Name = "Цемент ПЦ І-500Р",MesurableValue="bag",Price = 175,CategoryId = 1},
            //    new Material(){Name = "Цемент ПЦ ІІ/Б",MesurableValue="bag",Price = 135,CategoryId = 1},
            //    new Material(){Name = "Цемент ПЦ ІІ/Б-400",MesurableValue="bag",Price = 75,CategoryId = 1},

            //    new Material(){Name = "Керамогранит Geotiles Aura",MesurableValue="square meter",Price = 959,CategoryId = 2},
            //    new Material(){Name = "ABK Ceramica Blend",MesurableValue="square meter",Price = 2150,CategoryId = 2},
            //    new Material(){Name = "ABK Ceramica Eco",MesurableValue="square meter",Price = 1700,CategoryId = 2},

            //    new Material(){Name = "КИРПИЧ КЕРАМИЧЕСКИЙ PROKERAM",MesurableValue="one thing",Price = 7,CategoryId = 2},
            //    new Material(){Name = "Кирпич пенодиатомитовый теплоизоляционный",MesurableValue="one thing",Price = 31,CategoryId = 2},
            //    new Material(){Name = "Кирпич красный рядовой",MesurableValue="one thing",Price = 6,CategoryId = 3},
                
            //    new Material(){Name = "Газобетонный блок SLS",MesurableValue="one thing",Price = 79,CategoryId = 4},
            //    new Material(){Name = "Блок газобетонный AЕROC D300",MesurableValue="one thing",Price = 30,CategoryId = 4},
            //    new Material(){Name = "Газоблок Перегородковий",MesurableValue="one thing",Price = 24,CategoryId = 4},

            //    new Material(){Name = "Шифер 8-волновой",MesurableValue="bone thingag",Price = 19,CategoryId = 5},
            //    new Material(){Name = "Асбостальной лист",MesurableValue="one thing",Price = 15,CategoryId = 5},
            //    new Material(){Name = "Металлочерепица",MesurableValue="square meter",Price = 1885,CategoryId = 5},
            //    new Material(){Name = "Лист волна",MesurableValue="one thing",Price = 10,CategoryId = 5},

            //    new Material(){Name = "Плиты пенополистирольные Anserglob",MesurableValue="one box",Price = 295,CategoryId = 6},
            //    new Material(){Name = "Пенополистирол Penoboard",MesurableValue="one box",Price = 1113,CategoryId = 6},
            //    new Material(){Name = "Пенопласт EPS 50",MesurableValue="square meter",Price = 1326,CategoryId = 6},
            //    new Material(){Name = "Плиты пенополистирольные ",MesurableValue="one box",Price = 400,CategoryId = 6},

            //    new Material(){Name = "Кресло геймерское Cougar",MesurableValue="one thing",Price = 8000,CategoryId = 7},
            //    new Material(){Name = "Комплект садовой мебели Home Garden",MesurableValue="one thing",Price = 44000,CategoryId = 7},
            //    new Material(){Name = "Кровать Соня",MesurableValue="one thing",Price = 2000,CategoryId = 7},
            //    new Material(){Name = "Комплект садовой мебели з полиротанга ",MesurableValue="one thing",Price = 30000,CategoryId = 7}
            //};
            //Categories = new List<Category>()
            //{
            //    new Category(){Name = "Cement"},
            //    new Category(){Name = "Tile"},
            //    new Category(){Name = "Brick"},
            //    new Category(){Name = "Gas Block"},
            //    new Category(){Name = "Slate"},
            //    new Category(){Name = "Styrofoam"},
            //    new Category(){Name = "Furniture"}
            //};
            //JobPersons = new List<JobPerson>()
            //{
            //    new JobPerson(){Name = "Alex",SurName = "Alexanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Dima",SurName = "Dimanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "David",SurName = "Davidanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Yakov",SurName = "Yakovanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Vova",SurName = "Vovanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Egor",SurName = "Egoranrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Artem",SurName = "Artemanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Vanya",SurName = "Vanyanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Sergey",SurName = "Sergeyanrovish" , Phone="0987654321"},
            //    new JobPerson(){Name = "Andrey",SurName = "Andreynrovish" , Phone="0987654321"}
            //};
        }
    }
}
