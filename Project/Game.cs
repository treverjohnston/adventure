using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        int AtRoom;
        int Index;
        int TempIndex;
        string Answer;
        bool Key;
        bool TakeKey = false;
        bool S8 = false;
        bool S10 = false;
        bool S11 = false;
        bool S13 = false;


        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        List<Room> Rooms;
        List<Item> Inventory;
        List<Item> ZeroItems;
        List<Player> OneMonsters;
        public void Reset()
        {
            TakeKey = false;
            S8 = false;
            S10 = false;
            S11 = false;
            S13 = false;
        }

        public void Setup(string Name)
        {
            // ADDING LISTS
            List<Room> Rooms = new List<Room>();
            List<Item> Inventory = new List<Item>();
            // ITEMS SPECIFIC TO ROOMS
            List<Item> ZeroItems = new List<Item>();
            List<Item> TwoItems = new List<Item>();
            List<Item> FourItems = new List<Item>();
            List<Item> FiveItems = new List<Item>();
            List<Item> SixItems = new List<Item>();
            List<Item> SevenItems = new List<Item>();
            List<Item> TenItems = new List<Item>();
            List<Item> ElevenItems = new List<Item>();
            List<Item> TwelveItems = new List<Item>();
            List<Item> FifteenItems = new List<Item>();
            List<Item> SixteenItems = new List<Item>();
            List<Item> SeventeenItems = new List<Item>();


            // MONSTERS SPECIFIC TO ROOMS
            List<Player> OneMonsters = new List<Player>();
            List<Player> TwoMonsters = new List<Player>();
            List<Player> ThreeMonsters = new List<Player>();
            List<Player> FourMonsters = new List<Player>();
            List<Player> FiveMonsters = new List<Player>();
            List<Player> SixMonsters = new List<Player>();
            List<Player> SevenMonsters = new List<Player>();
            List<Player> ElevenMonsters = new List<Player>();
            List<Player> TwelveMonsters = new List<Player>();
            List<Player> FourteenMonsters = new List<Player>();
            List<Player> FifteenMonsters = new List<Player>();
            List<Player> SixteenMonsters = new List<Player>();
            List<Player> SeventeenMonsters = new List<Player>();

            // Empty Lists
            List<Player> EmptyMonsters = new List<Player>();
            List<Item> Empty = new List<Item>();

            // CREATING ROOMS
            Room Zero = new Room("0", "You are in the room you woke up in.", ZeroItems, EmptyMonsters, false);
            Room One = new Room("1", "You are in a large cavern.\nIt looks like there are doors to the east and west.", Empty, OneMonsters, false);
            Room Two = new Room("2", "You are in a small room that is faintly illuminated. There don't appear to be any exits. Behind you is the cavern you just came in through.", TwoItems, TwoMonsters, false);
            Room Three = new Room("3", "This appears to be an almost completely empty room.. ah wait, what's that over there..", Empty, ThreeMonsters, false);
            Room Four = new Room("4", "You are in a narrow hallway.", FourItems, FourMonsters, true);
            Room Five = new Room("5", "You are now in a large hall, this one extends far to the West", FiveItems, FiveMonsters, false);
            Room Six = new Room("6", "Another dead end room.", SixItems, SixMonsters, false);
            Room Seven = new Room("7", "This appears to be a sort of storage closet with another door on the South side.. But it's locked..", SevenItems, SevenMonsters, false);
            Room Eight = new Room("8", "You stand in the middle of a hallway, with exits to the East and West..", Empty, EmptyMonsters, true);
            Room Nine = new Room("9", "WOAH THERE'S A SORCERER IN HERE STANDING BETWEEN PILLARS OF FIRE", Empty, EmptyMonsters, false);
            Room Ten = new Room("10", "You are in a small room, with a smallish door along the South wall", TenItems, EmptyMonsters, false);
            Room Eleven = new Room("11", "You are now in another small room, nearly identical to the one you just exited, it looks like there is only an exit to the South again", ElevenItems, ElevenMonsters, false);
            Room Twelve = new Room("12", "You are now in an oddly round room. And I mean perfectly round. This is weird. It makes me wanna go hide in a corner.. There looks to be an exit over there, on the West side I think?", TwelveItems, TwelveMonsters, true);
            Room Thirteen = new Room("13", "This room looks nearly exactly the same as the room you woke up in, save that the only exit appears to be to the East, where you entered.", Empty, EmptyMonsters, true);
            Room Fourteen = new Room("14", "This has got to be the most boring looking room ever, and that's saying quite a bit.. I mean there is a door to the East, but that's pretty much all", Empty, FourteenMonsters, true);
            Room Fifteen = new Room("15", "You are now in another cavern, this one has pillars lining the whole thing, it looks pretty cool.  I think there is an exit along the South wall", FifteenItems, FifteenMonsters, false);
            Room Sixteen = new Room("16", "Woah guess what we found!! TREASURE ROOM! Wait.. what was that noise..", SixteenItems, SixteenMonsters, false);
            Room Seventeen = new Room("17", "This is just a cramped little room, hardly any space to move at all, and no exit.", SeventeenItems, SeventeenMonsters, false);


            //ADDING ROOMS TO ROOMS
            Rooms.Add(Zero);
            Rooms.Add(One);
            Rooms.Add(Two);
            Rooms.Add(Three);
            Rooms.Add(Four);
            Rooms.Add(Five);
            Rooms.Add(Six);
            Rooms.Add(Seven);
            Rooms.Add(Eight);
            Rooms.Add(Nine);
            Rooms.Add(Ten);
            Rooms.Add(Eleven);
            Rooms.Add(Twelve);
            Rooms.Add(Thirteen);
            Rooms.Add(Fourteen);
            Rooms.Add(Fifteen);
            Rooms.Add(Sixteen);
            Rooms.Add(Seventeen);


            // CREATING ITEMS
            Item Sword = new Item("Sword", "On the ground lies a Basic Sword...\nIt's actually a pretty lame sword all around");
            Item Key = new Item("Key", "On the ground lies an old key...\nIt doesn't look all that special.. but who knows");
            Item GoodSword = new Item("Shiny Sword", "On the ground lies a Super shiny sword...\nOoohhh Shiny");
            Item Bomb = new Item("Bomb", "On the ground lies a large round black object...\nOh wait that's a bomb.");
            Item Bow = new Item("Bow", "On  the ground lies a bow...\nOh hey and some arrows too!");
            Item Heart = new Item("Heart", "On the ground lies a heart...\nThat's pretty gross.");
            Item Force = new Item("Force", "On the ground lies a super shiny triangle shaped object...\nI got not clue what this thing is");

            // ADDING ITEMS TO ROOMS
            ZeroItems.Add(Sword);
            TwoItems.Add(Key);
            FourItems.Add(GoodSword);
            FiveItems.Add(Key);
            SixItems.Add(Key);
            TenItems.Add(Bow);
            ElevenItems.Add(Key);
            TwelveItems.Add(Key);
            FifteenItems.Add(Key);
            SixteenItems.Add(Heart);
            SeventeenItems.Add(Force);

            // CREATING MONSTERS
            Player LitDrag = new Player("Suddenly a pack of miniature dragons begins to rush at you from a distance", 100, Empty);
            Player Bat = new Player("There appears to be a large number of bats hanging from the ceiling. That's kinda scary actually.", 50, Empty);
            Player Dwarf = new Player("There is a dwarf sitting in the middle of the room, taking a nap", 250, Empty);
            Player Skeleton = new Player("There is a skeleton just standing there.. it appears to be looking at something on the floor..", 75, Empty);
            Player Bears = new Player("Bears! Lots of bears!!", 400, Empty);
            Player Suckers = new Player("Leeches, a whole pool of them!", 700, Empty);
            Player Dragon = new Player("Dragon. That is a dragon. Like, on of them that can breathe fire. Big, scary, ferocious looking dragon.", 5000, Empty);

            // ADDING MONSTERS TO ROOMS
            OneMonsters.Add(LitDrag);
            TwoMonsters.Add(Bat);
            ThreeMonsters.Add(Dwarf);
            FourMonsters.Add(Skeleton);
            FiveMonsters.Add(Skeleton);
            SixMonsters.Add(Bat);
            SevenMonsters.Add(Bat);
            ElevenMonsters.Add(Skeleton);
            TwelveMonsters.Add(Bears);
            FourteenMonsters.Add(Bears);
            FifteenMonsters.Add(Suckers);
            SixteenMonsters.Add(Dragon);
            SixteenMonsters.Add(LitDrag);


            //CREATING PLAYERS
            Player CurrentPlayer = new Player(Name, 0, Inventory);

            Play(CurrentPlayer, Rooms, Inventory);


        }

        public void Play(Player currentplayer, List<Room> rooms, List<Item> inventory)
        {
            CurrentPlayer = currentplayer;
            Rooms = rooms;
            Inventory = inventory;
            AtRoom = 0;
            bool Running = true;
            bool Rooming = true;
            // bool Attacking = true;
            while (Running)
            {
                Console.Clear();
                System.Console.WriteLine($"Onward we go then, {CurrentPlayer.Name} \n");
                System.Console.WriteLine("Well you've managed to make it inside, so that's a good start. As far as I can tell, there is no exit besides the way we just came in, which we can't exit out of for reasons I don't wish to explain right now. However, if we want to go deeper into the cave, there is a doorway along the South wall");
                while (Rooming)
                {

                    if (Rooms[AtRoom].Name == "0")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?\n");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            AtRoom = 1;
                            System.Console.WriteLine("\nWent south\n");
                        }
                        else if (Answer == "PICK UP SWORD" || Answer == "GRAB SWORD")
                        {
                            GrabBasic();
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                    }
                    else if (Rooms[AtRoom].Name == "1")
                    {
                        Intro();
                        // DETERMINES IF MONSTERS ARE ALIVE AND IF DOOR IS LOCKED
                        if (!Rooms[4].Locked)
                        {
                            System.Console.WriteLine("There is also that door to the south now");
                        }
                        foreach (var item in CurrentPlayer.Inventory)
                        {
                            if (item.Name == "Key")
                            {
                                System.Console.WriteLine("\nYou now notice that there is a door to the South, I wonder how you missed that before?\n");
                            }
                        }

                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            // System.Console.WriteLine("\nChicken.");
                            AtRoom = 0;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            AtRoom = 2;
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            AtRoom = 3;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            if (Rooms[4].Locked)
                            {
                                LockedFour();
                            }
                            else
                            {
                                System.Console.WriteLine("You go south");
                                AtRoom = 4;
                            }
                        }
                        else if (Answer == "ATTACK" || Answer == "ATTACK DRAGONS" || Answer == "ATTACK MINIATURE DRAGONS" || Answer == "KILL MINIATURE DRAGONS")
                        {
                            AttackMiniSword();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK DRAGONS WITH SWORD")
                        {
                            foreach (var item in CurrentPlayer.Inventory)
                            {
                                if (item.Name == "Sword")
                                {
                                    AttackMiniSword();
                                }
                                else if (item.Name == "Shiny Sword")
                                {
                                    AttackMiniSword();
                                }
                                else if (CurrentPlayer.Inventory.Count <= 1)
                                {
                                    System.Console.WriteLine("You're definitely gonna need a sword for that..");
                                }
                            }
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                    }
                    else if (Rooms[AtRoom].Name == "2")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East.\n");
                            AtRoom = 1;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "ATTACK" || Answer == "ATTACK BATS" || Answer == "ATTACK BAT" || Answer == "KILL BAT" || Answer == "KILL BATS")
                        {
                            AttackBatSword();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK BAT WITH SWORD")
                        {
                            AttackBatSword();
                        }
                        else if (Answer == "PICK UP KEY" || Answer == "GRAB KEY")
                        {
                            if (Rooms[AtRoom].Monsters.Count == 0)
                            {

                                GrabKey();
                            }
                            else
                            {
                                System.Console.WriteLine("You make a mad dash for the key on the ground, but as you get nearly within grabbing distance, the bats begin to swoop down attack you, you are forced to retreat back towards the entrance, away from the key.");
                            }
                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //

                    }
                    else if (Rooms[AtRoom].Name == "3")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 1;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "ATTACK" || Answer == "ATTACK DWARF" || Answer == "ATTACK DWARF" || Answer == "KILL DWARF")
                        {
                            AttackDwarf();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK DWARF WITH SWORD")
                        {
                            AttackDwarf();

                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "4")
                    {
                        RemoveKey();

                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North.\n");
                            AtRoom = 1;
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");

                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            CheckMonsters();
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "PICK UP SWORD" || Answer == "GRAB SWORD" || Answer == "TAKE SWORD" || Answer == "PICK UP SHINY SWORD" || Answer == "GRAB SHINY SWORD" || Answer == "TAKE SHINY SWORD")
                        {
                            if (Rooms[AtRoom].Monsters.Count == 0)
                            {
                                GrabShiny();
                            }
                            else
                            {
                                System.Console.WriteLine("You attempt to grab the shiny sword, but the skeleton notices you so you have to back away.");
                            }
                        }
                        else if (Answer == "ATTACK" || Answer == "ATTACK SKELETON" || Answer == "KILL SKELETON")
                        {

                            AttackSkeletonSword();

                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK SKELETON WITH SWORD")
                        {

                            AttackSkeletonSword();

                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "5")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North.\n");
                            AtRoom = 4;
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");
                            // System.Console.WriteLine("You go East.\n");
                            // AtRoom = 6;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 7;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "ATTACK" || Answer == "ATTACK SKELETON" || Answer == "KILL SKELETON")
                        {
                            AttackSkeletonSword();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK SKELETON WITH SWORD")
                        {
                            foreach (var item in CurrentPlayer.Inventory)
                            {
                                if (item.Name == "Shiny Sword")
                                {
                                    AttackSkeletonSword();
                                }
                            }

                        }
                        else if (Answer == "PICK UP KEY" || Answer == "GRAB KEY")
                        {
                            if (Rooms[AtRoom].Monsters.Count == 0)
                            {

                                GrabKey();
                            }
                            else
                            {
                                System.Console.WriteLine("You begin to slowly walk towards the key, hoping the skeleton won't notice you if you move slowly enough, but before you move two paces, the skeletons gives you an icy glare.. so you move away from the key.");
                            }
                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "6")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");

                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 5;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "ATTACK" || Answer == "ATTACK BATS" || Answer == "ATTACK BAT" || Answer == "KILL BAT" || Answer == "KILL BATS")
                        {
                            AttackBatSword();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK BAT WITH SWORD")
                        {
                            AttackBatSword();
                        }
                        else if (Answer == "PICK UP KEY" || Answer == "GRAB KEY")
                        {
                            if (Rooms[AtRoom].Monsters.Count == 0)
                            {
                                GrabKey();
                            }
                            else
                            {
                                System.Console.WriteLine("You make a mad dash for the key on the ground, but as you get nearly within grabbing distance, the bats begin to swoop down attack you, you are forced to retreat back towards the entrance, away from the key.");
                            }
                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "7")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("Well shoot that door disappeared. That's really odd.\n");
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            if (Rooms[8].Locked)
                            {
                                LockedEight();
                            }
                            else
                            {
                                System.Console.WriteLine("You go South.\n");
                                AtRoom = 8;
                            }
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO

                        else if (Answer == "ATTACK" || Answer == "ATTACK BATS" || Answer == "ATTACK BAT" || Answer == "KILL BAT" || Answer == "KILL BATS")
                        {
                            AttackBatSwordGood();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK BAT WITH SWORD")
                        {
                            AttackBatSwordGood();
                        }
                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "8")
                    {
                        RemoveKey();
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            if (S8)
                            {

                                System.Console.WriteLine("You go East.\n");
                                AtRoom = 10;
                            }
                            else
                            {

                                System.Console.WriteLine("You walk towards the Eastern door, but the more you walk that direction, the farther away the door becomes..\n");

                            }
                        }
                        else if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North.\n");
                            AtRoom = 7;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 9;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO


                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "9")
                    {
                        Intro();
                        if (!S8)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            System.Console.WriteLine("The Sorcerer speaks, saying 'Ahead lie rooms filled with riddles. If you ever hope to escape, you must answer the riddles correctly.'\nThe Sorcerer stares at you for a few more moments, and then poofs away in a cloud of smoke.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            S8 = true;
                        }
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East.\n");
                            AtRoom = 8;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO


                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "10")
                    {
                        Intro();
                        if (!S10)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            System.Console.WriteLine("\nSuddenly, the Sorcerer reappears in a poof of smoke.\n");
                            System.Console.WriteLine("  What has roots as nobody sees,\n    Is taller than trees,\n     Up, up it goes,\n       And yet never grows?");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");

                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 8;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            if (S10)
                            {
                                System.Console.WriteLine("You go South.\n");
                                AtRoom = 11;
                            }
                            else
                            {
                                System.Console.WriteLine("You begin to walk towards the Southern door, but the Sorcerers eyes start to glow red so you go back into your corner and ponder the riddle a little longer.");
                            }
                        }
                        else if (Answer == "MOUNTAINS" || Answer == "MOUNTAIN")
                        {
                            if (!S10)
                            {
                                S10 = true;
                                System.Console.WriteLine("The Sorcerer gives a satisfied nod and poofs away again.");
                            }
                            else
                            {
                                System.Console.WriteLine("The riddle has already been solved");
                            }
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "PICK UP BOW" || Answer == "GRAB BOW")
                        {
                            if (S10)
                            {
                                GrabBow();
                            }
                            else
                            {
                                System.Console.WriteLine("As you begin to move towards the bow, the Sorcerer raises a hand and a ball of fire leaps from it towards your feet, you quickly back away into the doorway you came from and ponder your life decisions.");
                            }
                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "11")
                    {
                        Intro();
                        if (!S11)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            System.Console.WriteLine("\nSuddenly, the Sorcerer reappears in a poof of smoke.\n");
                            System.Console.WriteLine("  This thing all things devours:\n    Birds, beasts, trees, flowers;\n    Gnaws iron, bites steel;\n  Grinds hard stones to meal;\n   Slays king, ruins town,\n   And beats high mountain down.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North.\n");
                            AtRoom = 10;
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            if (S11)
                            {
                                if (Rooms[12].Locked)
                                {
                                    LockedTwelve();
                                }
                                else
                                {
                                    System.Console.WriteLine("You go South.\n");
                                    AtRoom = 12;
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("As you begin to try and sneak past the sorcerer, he nods toward the skeleton which then throws a knife just past your ear. You then move back to the doorway from whence you came.");
                            }
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO

                        else if (Answer == "ATTACK" || Answer == "ATTACK SKELETON" || Answer == "KILL SKELETON")
                        {
                            if (S11)
                            {
                                AttackSkeletonSword();
                            }
                            else
                            {
                                System.Console.WriteLine("You make a move toward the skeleton, but as you get close to striking distance, the Sorcerer raises his hand and you suddenly feel yourself being pushed back towards the entrance.");
                            }
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK SKELETON WITH SWORD")
                        {
                            if (S11)
                            {
                                foreach (var item in CurrentPlayer.Inventory)
                                {
                                    if (item.Name == "Shiny Sword")
                                    {
                                        AttackSkeletonSword();
                                    }
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("You make a move toward the skeleton, but as you get close to striking distance, the Sorcerer raises his hand and you suddenly feel yourself being pushed back towards the entrance.");
                            }

                        }
                        else if (Answer == "PICK UP KEY" || Answer == "GRAB KEY")
                        {
                            if (Rooms[AtRoom].Monsters.Count == 0)
                            {

                                GrabKey();
                            }
                            else
                            {
                                System.Console.WriteLine("You begin to slowly walk towards the key, hoping the skeleton won't notice you if you move slowly enough, but before you move two paces, the skeletons gives you an icy glare.. so you move away from the key.");
                            }
                        }
                        else if (Answer == "TIME")
                        {
                            if (!S11)
                            {
                                S11 = true;
                                System.Console.WriteLine("The Sorcerer gives a satisfied nod and poofs away again.");
                            }
                            else
                            {
                                System.Console.WriteLine("The riddle has already been solved");
                            }
                        }
                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "12")
                    {
                        RemoveKey();
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North.\n");
                            AtRoom = 11;
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            if (Rooms[13].Locked)
                            {
                                LockedThirteen();
                            }
                            else
                            {
                                System.Console.WriteLine("You go West.\n");
                                AtRoom = 13;
                            }
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "ATTACK" || Answer == "ATTACK BEARS" || Answer == "ATTACK BEAR" || Answer == "KILL BEAR" || Answer == "KILL BEARS")
                        {
                            UseBowBears();
                        }
                        else if (Answer == "USE SWORD" || Answer == "ATTACK WITH SWORD" || Answer == "ATTACK SWORD" || Answer == "ATTACK BEARS WITH SWORD")
                        {
                            UseSwordOther();
                        }
                        else if (Answer == "USE BOW" || Answer == "ATTACK WITH BOW" || Answer == "ATTACK BOW" || Answer == "ATTACK BEARS WITH BOW")
                        {
                            UseBowBears();
                        }
                        else if (Answer == "PICK UP KEY" || Answer == "GRAB KEY")
                        {
                            if (Rooms[AtRoom].Monsters.Count == 0)
                            {

                                GrabKey();
                            }
                            else
                            {
                                System.Console.WriteLine("Nope. I'm not even gonna let you think about it with the bears still there to guard the key");
                            }
                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "13")
                    {
                        RemoveKey();
                        Intro();
                        if (!S13)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            System.Console.WriteLine("\nThe Scorcerer poofs into the room once more. You can tell that this riddle will by far be the hardest. The Sorcerer suddenly speaks,");
                            System.Console.WriteLine("\nWhat is the answer to life, the universe, and everything?");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?\n");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East.\n");
                            AtRoom = 12;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO
                        else if (Answer == "42" || Answer == "FOURTY TWO" || Answer == "FOURTY-TWO" || Answer == "FOURTYTWO")
                        {
                            if (!S13)
                            {
                                S13 = true;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                System.Console.WriteLine("The Sorcerer gives a satisfied nod and poofs away again.");
                                Rooming = false;
                            }
                            else
                            {
                                System.Console.WriteLine("The riddle has already been solved");
                            }
                        }

                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "14")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East.\n");
                            AtRoom = 15;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 10;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO


                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "15")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 14;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South.\n");
                            AtRoom = 16;
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO


                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "16")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North.\n");
                            AtRoom = 15;
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East.\n");
                            AtRoom = 17;
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO


                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    else if (Rooms[AtRoom].Name == "17")
                    {
                        Intro();
                        System.Console.WriteLine($"\nSo, what do you think, {CurrentPlayer.Name}?");
                        Answer = Console.ReadLine().ToUpper();
                        Console.Clear();
                        // // // // // // // // // // // // // //
                        // // // // // // // // // // // // // //
                        if (Answer == "GO NORTH" || Answer == "NORTH" || Answer == "N")
                        {
                            System.Console.WriteLine("You go North, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO EAST" || Answer == "EAST" || Answer == "E")
                        {
                            System.Console.WriteLine("You go East, and promptly run into a wall\n");
                        }
                        else if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                        {
                            System.Console.WriteLine("You go West.\n");
                            AtRoom = 16;
                        }
                        else if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                        {
                            System.Console.WriteLine("You go South, and promptly run into a wall\n");
                        }
                        else if (Answer == "HELP")
                        {
                            System.Console.WriteLine("This game isn't all knowing, you can't be too vague or it won't know what you want to do. For example if you wanted to use your sword to attack a monster, you can't just say 'fight' and expect it to work.\nOn the other hand, you can't be overly specific.  For example you can't expect to say 'hey go attack that monster over there with a sword' and have that work.\nSome basic commands are directional, such as 'go north', or 'south', or 'w'.  Another basic command is 'grab', which allows you to pick up an object in a room.  If you want to use this object, simply say 'use 'object''\nIf at any point you wish to quit, just enter 'quit', however, don't expect your progress to be saved.\n");
                        }
                        else if (Answer == "QUIT")
                        {
                            System.Environment.Exit(0);
                        }
                        else if (Answer == "INVENTORY")
                        {
                            SeeInventory();
                        }
                        // // // // // // // // // // // // // //
                        // THIS IS WHERE ROOM SPECIFIC COMMANDS GO


                        // // // // // // // // // // // // // //
                        else
                        {
                            System.Console.WriteLine("That doesn't work here\nType 'Help' for a list of commands");
                        }
                        // // // // // // // // // // // // // //
                    }
                    //  // // // // / / / // / / / Finishing statements and yes or no stuff
                    // 
                    // 
                    // 
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"\nWow {CurrentPlayer.Name}, you have completed the game with a score of {CurrentPlayer.Score}/115!");
                Console.ForegroundColor = ConsoleColor.Gray;
                System.Console.WriteLine("\nPlay again? (Y/N)");
                string Continue = Console.ReadLine();
                if (Continue.ToUpper() == "N" || Continue.ToUpper() == "NO")
                {
                    Running = false;
                }
                else
                {
                    CurrentPlayer.Score = 0;
                    Rooming = true;
                    AtRoom = 0;
                    CurrentPlayer.Inventory.Clear();
                    Setup(CurrentPlayer.Name);
                    Reset();
                    TakeKey = false;
                    S8 = false;
                    S10 = false;
                    S11 = false;
                    S13 = false;
                    Console.Clear();
                }
                // 
                // 
                // 
                //  // // // // // // // // // // // // //
            }
        }
        // // // // // // // // // // // // // // //
        public void SeeInventory()
        {
            System.Console.WriteLine("Inventory!");
            foreach (var item in CurrentPlayer.Inventory)
            {
                System.Console.WriteLine(item.Name);
            }
        }
        // // // // // // // // // // // // // //
        public void AttackMiniSword()
        {
            if (CurrentPlayer.Inventory.Count >= 1)
            {
                foreach (var item in CurrentPlayer.Inventory)
                {
                    if (item.Name == "Sword")
                    {
                        foreach (var monster in Rooms[AtRoom].Monsters)
                        {
                            if (monster.Name == "Suddenly a pack of miniature dragons begins to rush at you from a distance")
                            {
                                Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                            }
                        }
                        Rooms[AtRoom].Monsters.RemoveAt(Index);
                        System.Console.WriteLine("\nYou have valiantly fought off the miniature dragons using your ugly sword, the few left ran off into hiding\n");
                        CurrentPlayer.Score += 25;
                    }
                    if (item.Name == "Shiny Sword")
                    {
                        foreach (var monster in Rooms[AtRoom].Monsters)
                        {
                            if (monster.Name == "Suddenly a pack of miniature dragons begins to rush at you from a distance")
                            {
                                Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                            }
                        }
                        Rooms[AtRoom].Monsters.RemoveAt(Index);
                        System.Console.WriteLine("\nYou have valiantly fought off the miniature dragons using your super shiny new sword, the few left ran off into hiding\n");
                        CurrentPlayer.Score += 25;
                    }
                }
            }
            else
            {
                System.Console.WriteLine("You're definitely gonna need a sword for that..\n");
            }
        }

        public void AttackBatSword()
        {
            if (CurrentPlayer.Inventory.Count >= 1)
            {
                foreach (var item in CurrentPlayer.Inventory)
                {
                    if (item.Name == "Sword")
                    {
                        foreach (var monster in Rooms[AtRoom].Monsters)
                        {
                            if (monster.Name == "There appears to be a large number of bats hanging from the ceiling. That's kinda scary actually.")
                            {

                                Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                            }
                        }
                        Rooms[AtRoom].Monsters.RemoveAt(Index);
                        System.Console.WriteLine("Woot woot! You killed the bats with your sword!\n");
                        CurrentPlayer.Score += 5;
                    }
                }
            }
            else
            {
                System.Console.WriteLine("You're definitely gonna need a sword for that..\n");
            }
        }
        public void AttackBatSwordGood()
        {
            if (CurrentPlayer.Inventory.Count >= 1)
            {
                foreach (var item in CurrentPlayer.Inventory)
                {
                    if (item.Name == "Shiny Sword")
                    {
                        foreach (var monster in Rooms[AtRoom].Monsters)
                        {
                            if (monster.Name == "There appears to be a large number of bats hanging from the ceiling. That's kinda scary actually.")
                            {

                                Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                            }
                        }
                        Rooms[AtRoom].Monsters.RemoveAt(Index);
                        System.Console.WriteLine("Woot woot! You killed the bats with your sword!\n");
                        CurrentPlayer.Score += 5;
                    }
                }
            }
            else
            {
                System.Console.WriteLine("You're definitely gonna need a sword for that..\n");
            }
        }
        public void AttackBear()
        {
            foreach (var monster in Rooms[AtRoom].Monsters)
            {
                if (monster.Name == "Bears! Lots of bears!!")
                {
                    Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                }
            }
            Rooms[AtRoom].Monsters.RemoveAt(Index);
            System.Console.WriteLine("\nWelp, you managed to kill the bears using your barehands, good job I suppose.. Although this really would be easier if you used a sword.\n\n");
            CurrentPlayer.Score += 50;
        }
        public void AttackBearSword()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Shiny Sword")
                {
                    foreach (var monster in Rooms[AtRoom].Monsters)
                    {
                        if (monster.Name == "Bears! Lots of bears!!")
                        {

                            Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                        }
                    }
                    Rooms[AtRoom].Monsters.RemoveAt(Index);
                    System.Console.WriteLine("Woot woot! You killed the bears with your sword!\n");
                    CurrentPlayer.Score += 50;
                }
            }
        }
        public void AttackDwarf()
        {
            foreach (var monster in Rooms[AtRoom].Monsters)
            {
                if (monster.Name == "There is a dwarf sitting in the middle of the room, taking a nap")
                {
                    Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                }
            }
            Rooms[AtRoom].Monsters.RemoveAt(Index);
            System.Console.WriteLine("\nIT WAS JUST A DWARF YOU DIDN'T HAVE TO KILL HIM, AND WITH YOU BARE HANDS NO LESS.\nYou should be ashamed.\nIt's not like it was going to throw an axe at you or anything.\nI'm taking away point for that.\n\n");
            CurrentPlayer.Score -= 10;
        }

        public void AttackSkeletonSword()
        {
            if (CurrentPlayer.Inventory.Count >= 1)
            {
                foreach (var monster in Rooms[AtRoom].Monsters)
                {
                    if (monster.Name == "There is a skeleton just standing there.. it appears to be looking at something on the floor..")
                    {
                        Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                    }
                }
                Rooms[AtRoom].Monsters.RemoveAt(Index);
                if (AtRoom == 4)
                {
                    foreach (var item in CurrentPlayer.Inventory)
                    {
                        if (item.Name == "Sword")
                        {
                            TempIndex = CurrentPlayer.Inventory.IndexOf(item);
                        }
                    }
                    CurrentPlayer.Inventory.RemoveAt(TempIndex);
                    System.Console.WriteLine("\nNice. Skelly is dead. Unfortunately, with your last killing jab your sword managed to break...");
                    CurrentPlayer.Score += 10;
                }
                else
                {
                    System.Console.WriteLine("Nice, the Skeleton is a gone for good. This new sword is a lot nicer");
                    CurrentPlayer.Score += 10;
                }
            }
            else
            {
                System.Console.WriteLine("You're definitely gonna need a sword for that..\n");
            }
        }
        public void UseBowOther()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Bow")
                {
                    System.Console.WriteLine("yeahhhhh that's not gonna work here..");
                }
            }
        }

        public void UseSwordOther()
        {
            System.Console.WriteLine("yeahhhhh that's not gonna work here..");
        }
        public void UseBowBears()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Bow")
                {
                    foreach (var monster in Rooms[AtRoom].Monsters)
                    {
                        if (monster.Name == "Bears! Lots of bears!!")
                        {

                            Index = Rooms[AtRoom].Monsters.IndexOf(monster);
                        }
                    }
                    Rooms[AtRoom].Monsters.RemoveAt(Index);
                    System.Console.WriteLine("Woot woot! You killed the bears with your Bow!\n");
                }
            }
            CurrentPlayer.Score += 50;
        }
        // // // // // // // // // // // // // //
        public void GrabBasic()
        {
            foreach (var item in Rooms[AtRoom].Items)
            {
                if (item.Name == "Sword")
                {
                    Index = Rooms[AtRoom].Items.IndexOf(item);
                }
            }
            CurrentPlayer.AddItem(Rooms[AtRoom].Items[Index]);
            Rooms[AtRoom].Items.RemoveAt(Index);
            System.Console.WriteLine("\nPicked up sword");
        }
        public void GrabKey()
        {
            foreach (var item in Rooms[AtRoom].Items)
            {
                if (item.Name == "Key")
                {
                    if (AtRoom != 12)
                    {
                        TakeKey = true;
                    }
                    if (AtRoom == 13)
                    {
                        TakeKey = true;
                    }
                    Key = true;
                    Index = Rooms[AtRoom].Items.IndexOf(item);
                }
            }
            if (Key)
            {
                CurrentPlayer.AddItem(Rooms[AtRoom].Items[Index]);
                Rooms[AtRoom].Items.RemoveAt(Index);
                System.Console.WriteLine("\nPicked up key\n");
                Key = false;
            }
            else
            {
                System.Console.WriteLine("No key here");
            }
        }
        public void GrabShiny()
        {
            foreach (var item in Rooms[AtRoom].Items)
            {
                if (item.Name == "Sword")
                {
                    Index = Rooms[AtRoom].Items.IndexOf(item);
                }
            }
            CurrentPlayer.AddItem(Rooms[AtRoom].Items[Index]);
            Rooms[AtRoom].Items.RemoveAt(Index);
            System.Console.WriteLine("\nPicked up uber shiny sword\n");

        }
        public void GrabBow()
        {
            foreach (var item in Rooms[AtRoom].Items)
            {
                if (item.Name == "Bow")
                {
                    Index = Rooms[AtRoom].Items.IndexOf(item);
                }
            }
            CurrentPlayer.AddItem(Rooms[AtRoom].Items[Index]);
            Rooms[AtRoom].Items.RemoveAt(Index);
            System.Console.WriteLine("Picked up cool Bow and some Arrows\n");

        }
        // // // // // // // // // // // // // //
        public void LockedFour()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Key")
                {
                    if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                    {
                        foreach (var room in Rooms)
                        {
                            if (room.Name == "4")
                            {
                                room.Locked = false;
                            }
                        }
                        System.Console.WriteLine("You unlock the newly found door and walk through\n");
                        AtRoom = 4;
                    }
                }
                else if (CurrentPlayer.Inventory.Count == 1)
                {
                    System.Console.WriteLine("That's locked.. You're gonna need a key");
                }
            }
        }
        public void LockedEight()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Key")
                {
                    if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                    {
                        foreach (var room in Rooms)
                        {
                            if (room.Name == "8")
                            {
                                if (room.Locked)
                                {

                                    room.Locked = false;
                                }
                            }
                        }
                        System.Console.WriteLine("You unlock the door and walk through\n");
                        AtRoom = 8;
                    }
                }
                else if (CurrentPlayer.Inventory.Count == 1)
                {
                    System.Console.WriteLine("That's locked.. You're gonna need a key");
                }
            }
        }
        public void LockedTwelve()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Key")
                {
                    if (Answer == "GO SOUTH" || Answer == "SOUTH" || Answer == "S")
                    {
                        foreach (var room in Rooms)
                        {
                            if (room.Name == "12")
                            {
                                if (room.Locked)
                                {

                                    room.Locked = false;
                                }
                            }
                        }
                        System.Console.WriteLine("You unlock the door and walk through\n");
                        AtRoom = 12;
                    }
                    Key = true;
                }
            }
            if (!Key)
            {
                System.Console.WriteLine("That's locked.. You're gonna need a key");
            }
            else
            {
                Key = false;
            }
        }
        public void LockedThirteen()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Key")
                {
                    if (Answer == "GO WEST" || Answer == "WEST" || Answer == "W")
                    {
                        foreach (var room in Rooms)
                        {
                            if (room.Name == "13")
                            {
                                if (room.Locked)
                                {

                                    room.Locked = false;
                                }
                            }
                        }
                        System.Console.WriteLine("You unlock the door and walk through\n");
                        AtRoom = 13;
                    }
                    Key = true;
                }
            }
            if (!Key)
            {
                System.Console.WriteLine("That's locked.. You're gonna need a key");
            }
            else
            {
                Key = false;
            }
        }
        public void RemoveKey()
        {
            foreach (var item in CurrentPlayer.Inventory)
            {
                if (item.Name == "Key" && TakeKey)
                {
                    Index = CurrentPlayer.Inventory.IndexOf(item);
                    Key = true;
                }
                if (item.Name == "Key" && AtRoom == 13)
                {
                    Index = CurrentPlayer.Inventory.IndexOf(item);
                    Key = true;
                }
            }
            if (Key)
            {
                CurrentPlayer.Inventory.RemoveAt(Index);
                Key = false;
                TakeKey = false;
            }
        }
        public void CheckMonsters()
        {
            if (Rooms[AtRoom].Monsters.Count > 0)
            {
                System.Console.WriteLine("Nah there is a skeleton in the way. You can't just walk past.");
            }
            else if (AtRoom == 4)
            {
                System.Console.WriteLine("You go South.\n");
                AtRoom = 5;
            }
        }
        // // // // // // // // // // // // // //
        public void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"\nTrever's Score: {CurrentPlayer.Score}\n");
            foreach (var item in CurrentPlayer.Inventory)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                System.Console.WriteLine($"You have a(n) {item.Name}");
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine($"\n{Rooms[AtRoom].Description} \n");

            foreach (var monster in Rooms[AtRoom].Monsters)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{monster.Name}\n");
            }
            foreach (var item in Rooms[AtRoom].Items)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{item.Description}");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        // // // // // // // // // // // // // //
        public void UseItem(string itemName)
        {

        }
    }
}