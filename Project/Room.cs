using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public List<Player> Monsters { get; set; }
        public bool Locked {get; set;}

        public void UseItem(Item item)
        {

        }

        public Room(string name, string description, List<Item> items, List<Player> monsters, bool locked)
        {
            Name = name;
            Description = description;
            Items = items;
            Monsters = monsters;
            Locked = locked;
        }
    }
}