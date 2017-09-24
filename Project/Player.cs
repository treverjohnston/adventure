using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {
        public string Name {get; set;}
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(string name, int score, List<Item> inventory)
        {
            Name = name;
            Score = score;
            Inventory = inventory;
        }

        public void AddItem(Item item){
            Inventory.Add(item);
        }
    }
}