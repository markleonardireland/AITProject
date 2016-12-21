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
            new User{UserName="alexc", FirstName="Carson",LastName="Alexander"},
            new User{UserName="markleo30", FirstName="Mark",LastName="Leonard"},
            new User{UserName="halpinj", FirstName="Jack",LastName="Halpin"},
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var games = new List<Game>
            {
            new Game{Title="FIFA 17", Price=34.99f, ImageURL="http://i1.walesonline.co.uk/incoming/article10695416.ece/ALTERNATES/s615b/Bale-FIFA-cover.jpg"},
            new Game{Title="Rocket League", Price=19.99f, ImageURL="https://d2y7xuvh99w6jl.cloudfront.net/wp-content/uploads/sites/3/2016/07/rocket-league-cover.jpg"},
            new Game{Title="Counter Strike: Global Offensive", Price=19.99f, ImageURL="https://key4co.in/wp-content/uploads/2016/07/Counter-Strike-Global-Offensive-cover-525x700.jpg"},
            new Game{Title="Battleifled 1", Price=69.99f, ImageURL="https://upload.wikimedia.org/wikipedia/en/f/fc/Battlefield_1_cover_art.jpg"},
            new Game{Title="Starcraft II", Price=29.99f, ImageURL="https://upload.wikimedia.org/wikipedia/en/2/20/StarCraft_II_-_Box_Art.jpg"},
            new Game{Title="Street Fighter V", Price=54.99f, ImageURL="http://images.pushsquare.com/games/ps4/street_fighter_v/cover_large.jpg"}
            };

            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();

            var reviews = new List<Review>
            {
            new Review{UserID=1, GameID=1, Caption="Great Gamplay!", Content="One of my favourite games of all time!"},
            };

            reviews.ForEach(s => context.Reviews.Add(s));
            context.SaveChanges();

        }
    }
}