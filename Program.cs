using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.DataModels;
using ArtifactManager.Forms;

namespace ArtifactManager
{
    internal class Program
    {

        public static CodeFirstContext context = new CodeFirstContext();

        public static void addCategories()
        {
            using (var db = new CodeFirstContext())
            {
                
                db.Categories.Add(new Category()
                {
                    Name = "Cave"
                });
                db.Categories.Add(new Category()
                {
                    Name = "Forest"
                });
                db.Categories.Add(new Category()
                {
                    Name = "Tower"
                });
                
                db.Caves.Add(new Cave()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 1),
                    User = db.Users.FirstOrDefault(c => c.Role == "admin"),
                    Name = "Dark Cave",
                    Area = 100
                });
                db.Forests.Add(new Forest()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 2),
                    User = db.Users.FirstOrDefault(c => c.Role == "admin"),
                    Name = "Rain Forest",
                    Area = 1000
                });
                db.Forests.Add(new Forest()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 2),
                    User = db.Users.FirstOrDefault(c => c.Role == "admin"),
                    Name = "Dead Forest"
                });
                db.Towers.Add(new Tower()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 3),
                    User = db.Users.FirstOrDefault(c => c.Role == "admin"),
                    Name = "Enchanted Tower",
                    Height = 50,
                    Age = 100
                });
                db.SaveChanges();
            }
        }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registration());
        }
    }
}
