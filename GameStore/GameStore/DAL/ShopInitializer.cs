using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GameStore.Models;

namespace GameStore.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander"},
            new User{FirstName="Carsoasdfn",LastName="Alexasdfander"},
            new User{FirstName="Carsoasdfnasdfasfasd",LastName="Alexasdfander"},
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var games = new List<Game>
            {
            new Game{Title="Fifa",Price=33}
           
            };

            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();

        }
    }
}