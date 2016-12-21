using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using gamestore.Models;

namespace gamestore.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var Users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander", UserName="AlexC"},
            new User{FirstName="Meredith",LastName="Alonso", UserName="MerAlo"},
            new User{FirstName="Arturo",LastName="Anand", UserName="ArturA"},
            new User{FirstName="Jack",LastName="Halpin", UserName="HalpinJ"},
            new User{FirstName="Mark",LastName="Leonard", UserName="markleo30"},
            };

            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var Games = new List<Game>
            {
            new Game{Title="FIFA 2017", Rating=5, Price=59.99F },
            new Game{Title="Counter Strike: Global Offensive", Rating=2, Price=19.99f },
            new Game{Title="Rocket League", Rating=5, Price=15.99f },
            };
            Games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();

            var reviews = new List<Review>
            {
            new Review{UserID=1,GameID=1050, Content="Great Game!" , ReviewDate=DateTime.Parse("2016-12-14")}
           
            };
            reviews.ForEach(s => context.Reviews.Add(s));
            context.SaveChanges();
        }
    }
}