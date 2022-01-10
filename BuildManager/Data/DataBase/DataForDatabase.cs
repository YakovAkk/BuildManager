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
                        new JobPerson() { name = "Alex", Surname = "Alexanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Dima", Surname = "Dimanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "David", Surname = "Davidanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Yakov", Surname = "Yakovanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Vova", Surname = "Vovanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Egor", Surname = "Egoranrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Artem", Surname = "Artemanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Vanya", Surname = "Vanyanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Sergey", Surname = "Sergeyanrovish", Phone = "0987654321" },
                        new JobPerson() { name = "Andrey", Surname = "Andreynrovish", Phone = "0987654321" }
                    );

                db.SaveChanges();
            };
        }
        public void AddMAterials()
        {
            using (AppDBContent db = new AppDBContent())
            {
                db.Materials.AddRange(
                        new Material() { name = "Цемент ПЦ II", mesurableValue = "bag", price = 160, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { name = "Цемент ПЦ II/A", mesurableValue = "bag", price = 85, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { name = "Цемент ПЦ І-500Р", mesurableValue = "bag", price = 175, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { name = "Цемент ПЦ ІІ/Б", mesurableValue = "bag", price = 135, CategoryId = ((int)CategoryEnum.Cement) },
                        new Material() { name = "Цемент ПЦ ІІ/Б-400", mesurableValue = "bag", price = 75, CategoryId = ((int)CategoryEnum.Cement) },

                        new Material() { name = "Керамогранит Geotiles Aura", mesurableValue = "square meter", price = 959, CategoryId = ((int)CategoryEnum.Tile) }, 
                        new Material() { name = "ABK Ceramica Blend", mesurableValue = "square meter", price = 2150, CategoryId = ((int)CategoryEnum.Tile) },
                        new Material() { name = "ABK Ceramica Eco", mesurableValue = "square meter", price = 1700, CategoryId = ((int)CategoryEnum.Tile) },

                        new Material() { name = "КИРПИЧ КЕРАМИЧЕСКИЙ PROKERAM", mesurableValue = "one thing", price = 7, CategoryId = ((int)CategoryEnum.Brick) },
                        new Material() { name = "Кирпич пенодиатомитовый теплоизоляционный", mesurableValue = "one thing", price = 31, CategoryId = ((int)CategoryEnum.Brick) },
                        new Material() { name = "Кирпич красный рядовой", mesurableValue = "one thing", price = 6, CategoryId = ((int)CategoryEnum.Brick) },

                        new Material() { name = "Газобетонный блок SLS", mesurableValue = "one thing", price = 79, CategoryId = ((int)CategoryEnum.GasBlock) },
                        new Material() { name = "Блок газобетонный AЕROC D300", mesurableValue = "one thing", price = 30, CategoryId = ((int)CategoryEnum.GasBlock) },
                        new Material() { name = "Газоблок Перегородковий", mesurableValue = "one thing", price = 24, CategoryId = ((int)CategoryEnum.GasBlock) },

                        new Material() { name = "Шифер 8-волновой", mesurableValue = "bone thingag", price = 19, CategoryId = ((int)CategoryEnum.Slate) },
                        new Material() { name = "Асбостальной лист", mesurableValue = "one thing", price = 15, CategoryId = ((int)CategoryEnum.Slate) },
                        new Material() { name = "Металлочерепица", mesurableValue = "square meter", price = 1885, CategoryId = ((int)CategoryEnum.Slate) },
                        new Material() { name = "Лист волна", mesurableValue = "one thing", price = 10, CategoryId = ((int)CategoryEnum.Slate) },

                        new Material() { name = "Плиты пенополистирольные Anserglob", mesurableValue = "one box", price = 295, CategoryId = ((int)CategoryEnum.Styrofoam) },
                        new Material() { name = "Пенополистирол Penoboard", mesurableValue = "one box", price = 1113, CategoryId = ((int)CategoryEnum.Styrofoam) },
                        new Material() { name = "Пенопласт EPS 50", mesurableValue = "square meter", price = 1326, CategoryId = ((int)CategoryEnum.Styrofoam) },
                        new Material() { name = "Плиты пенополистирольные ", mesurableValue = "one box", price = 400, CategoryId = ((int)CategoryEnum.Styrofoam) },

                        new Material() { name = "Кресло геймерское Cougar", mesurableValue = "one thing", price = 8000, CategoryId = ((int)CategoryEnum.Furniture) },
                        new Material() { name = "Комплект садовой мебели Home Garden", mesurableValue = "one thing", price = 44000, CategoryId = ((int)CategoryEnum.Furniture) },
                        new Material() { name = "Кровать Соня", mesurableValue = "one thing", price = 2000, CategoryId = ((int)CategoryEnum.Furniture) },
                        new Material() { name = "Комплект садовой мебели з полиротанга ", mesurableValue = "one thing", price = 30000, CategoryId = ((int)CategoryEnum.Furniture) }
                    );

                db.SaveChanges();
            };
        }

        public DataForDatabase()
        {
            //Materials = new List<Material>()
            //{


            //    new Material(){name = "Цемент ПЦ II",mesurableValue="bag",price = 160,CategoryId = 1},
            //    new Material(){name = "Цемент ПЦ II/A",mesurableValue="bag",price = 85,CategoryId = 1},
            //    new Material(){name = "Цемент ПЦ І-500Р",mesurableValue="bag",price = 175,CategoryId = 1},
            //    new Material(){name = "Цемент ПЦ ІІ/Б",mesurableValue="bag",price = 135,CategoryId = 1},
            //    new Material(){name = "Цемент ПЦ ІІ/Б-400",mesurableValue="bag",price = 75,CategoryId = 1},

            //    new Material(){name = "Керамогранит Geotiles Aura",mesurableValue="square meter",price = 959,CategoryId = 2},
            //    new Material(){name = "ABK Ceramica Blend",mesurableValue="square meter",price = 2150,CategoryId = 2},
            //    new Material(){name = "ABK Ceramica Eco",mesurableValue="square meter",price = 1700,CategoryId = 2},

            //    new Material(){name = "КИРПИЧ КЕРАМИЧЕСКИЙ PROKERAM",mesurableValue="one thing",price = 7,CategoryId = 2},
            //    new Material(){name = "Кирпич пенодиатомитовый теплоизоляционный",mesurableValue="one thing",price = 31,CategoryId = 2},
            //    new Material(){name = "Кирпич красный рядовой",mesurableValue="one thing",price = 6,CategoryId = 3},
                
            //    new Material(){name = "Газобетонный блок SLS",mesurableValue="one thing",price = 79,CategoryId = 4},
            //    new Material(){name = "Блок газобетонный AЕROC D300",mesurableValue="one thing",price = 30,CategoryId = 4},
            //    new Material(){name = "Газоблок Перегородковий",mesurableValue="one thing",price = 24,CategoryId = 4},

            //    new Material(){name = "Шифер 8-волновой",mesurableValue="bone thingag",price = 19,CategoryId = 5},
            //    new Material(){name = "Асбостальной лист",mesurableValue="one thing",price = 15,CategoryId = 5},
            //    new Material(){name = "Металлочерепица",mesurableValue="square meter",price = 1885,CategoryId = 5},
            //    new Material(){name = "Лист волна",mesurableValue="one thing",price = 10,CategoryId = 5},

            //    new Material(){name = "Плиты пенополистирольные Anserglob",mesurableValue="one box",price = 295,CategoryId = 6},
            //    new Material(){name = "Пенополистирол Penoboard",mesurableValue="one box",price = 1113,CategoryId = 6},
            //    new Material(){name = "Пенопласт EPS 50",mesurableValue="square meter",price = 1326,CategoryId = 6},
            //    new Material(){name = "Плиты пенополистирольные ",mesurableValue="one box",price = 400,CategoryId = 6},

            //    new Material(){name = "Кресло геймерское Cougar",mesurableValue="one thing",price = 8000,CategoryId = 7},
            //    new Material(){name = "Комплект садовой мебели Home Garden",mesurableValue="one thing",price = 44000,CategoryId = 7},
            //    new Material(){name = "Кровать Соня",mesurableValue="one thing",price = 2000,CategoryId = 7},
            //    new Material(){name = "Комплект садовой мебели з полиротанга ",mesurableValue="one thing",price = 30000,CategoryId = 7}
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
            //    new JobPerson(){name = "Alex",Surname = "Alexanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Dima",Surname = "Dimanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "David",Surname = "Davidanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Yakov",Surname = "Yakovanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Vova",Surname = "Vovanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Egor",Surname = "Egoranrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Artem",Surname = "Artemanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Vanya",Surname = "Vanyanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Sergey",Surname = "Sergeyanrovish" , Phone="0987654321"},
            //    new JobPerson(){name = "Andrey",Surname = "Andreynrovish" , Phone="0987654321"}
            //};
        }
    }
}
