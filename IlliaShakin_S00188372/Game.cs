using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlliaShakin_S00188372
{
    //Class for setting up variables
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Metacritic { get; set; }

        public string Description { get; set; }

        public string Platform { get; set; }

        public decimal Price { get; set; }

        public string GameImage { get; set; }

        public Game()
        {

        }

        public Game(string name, int metacritic, string description, string platform, decimal price, string gameimage="")
        {
            Name = name;
            Metacritic = metacritic;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = gameimage;
        }

        //Method to Decrease Price - Nunit

        public void DescreasePrice(double descrease)
        {
            Price *= (decimal)(1 - descrease);
        }

        //Formatting
        public override string ToString()
        {
            return Name;
        }

    }

    //Setting up Code First DB
    public class GameData : DbContext
    {
        public GameData() : base("GameData") { }

        public DbSet<Game> Games { get; set; }
    }
}
