// See https://aka.ms/new-console-template for more information
namespace FriendFace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string username = logIn("Username:");
            string password = logIn("Password:");
            User userData = new User(username, password);
            string options = string.Empty;
            while (options != "0")
            {
                Friend friend = new("temp", "temp", 1);
                options = Menu(userData);
                switch(options)
                {
                    case "0":
                        break;

                    case "1":
                        addFriend(userData);
                        break;

                    case "2":
                        friendsList(userData);
                        break;
                }
                pause();
            }
            
        }

        public static void addFriend(User user)
        {
            Friend[] friendArray =
            {
                new("Frank", "Jeff", 21),
                new("Sarah", "Epsteen", 22),
                new("Greg", "Greg", 2),
                new("Lux", "Ezreal", 23),
                new("Sergi", "Ezquil", 24),
                new("Stalin", "The Man", 999)
            };

            if(user.Friends.Count != 5)
            {
                Console.Clear();
                int number = 0;
                Console.WriteLine("Friends you can add are:\n");
                foreach (var friend in friendArray)
                {
                    Console.WriteLine($"|-{number} {friend.FirstName}");
                    number++;
                }
                Console.WriteLine("Who will you be adding?");
                string choosen = Console.ReadLine();
                int numberchoosen = int.Parse(choosen);
                user.Friends.Add(friendArray[numberchoosen]);
            }
            else { Console.WriteLine("You've reached max friend capacity"); }

        }

        public static void friendsList(User user)
        {
            string options = string.Empty;
            while(options != "0")
            {
                options = friendMenu();
                switch(options)
                {
                    case "0":
                        break;

                    case "1":
                        listFriends(user);
                        break;

                    case "2":
                        removeFriend(user);
                        break;

                    case "3":
                        inspectFriend(user);
                        break;
                }
            }
        }

        public static void listFriends(User user)
        {
            Console.Clear();
            Console.WriteLine("Here is your friends List");
            foreach (var friend in user.Friends)
            {
                Console.WriteLine($"|- Name: {friend.FirstName}");
            }
            pause();
        }

        public static void removeFriend(User user)
        {
            Console.Clear();
            Console.WriteLine("Which friend do you want to remove?");
            int number = 0;
            foreach (var friend in user.Friends)
            {
                Console.WriteLine($"|- {number} Name: {friend.FirstName}");
                number++;
            }
            int choosen = int.Parse( Console.ReadLine() );
            Console.WriteLine($"First Name: {user.Friends[choosen].FirstName}");
            Console.WriteLine($"Last Name: {user.Friends[choosen].LastName}");
            Console.WriteLine("Do you wish to remove this friend?");
            Console.WriteLine("(Y/N)");
            char chara = Console.ReadKey().KeyChar;
            if (chara == 'Y' || chara == 'y')
            {
                user.Friends.RemoveAt(choosen);
                Console.WriteLine("\n\n The person has been removed");
            }
            pause();
        }

        public static void inspectFriend(User user)
        {
            Console.WriteLine("Here is your friends List");
            int number = 0;
            foreach (var friend in user.Friends)
            {
                Console.WriteLine($"|- {number} Name: {friend.FirstName}");
                number++;
            }
            Console.WriteLine("Which friend do you want to inspect?");
            int choosen = int.Parse(Console.ReadLine());
            Console.WriteLine($"First Name: {user.Friends[choosen].FirstName}");
            Console.WriteLine($"Last Name: {user.Friends[choosen].LastName}");
            Console.WriteLine($"ID: {user.Friends[choosen].Id}");

            pause();
        }

        public static void pause()
        {
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }

        public static string friendMenu()
        {
            Console.Clear();
            Console.WriteLine("|-1. List Friends");
            Console.WriteLine("|-2. Remove Friend(s)");
            Console.WriteLine("|-3. Inspect a Friend");    
            Console.WriteLine("|-0. Back \n");
            Console.WriteLine("- Choose");
            string menu_input = Console.ReadLine();
            return menu_input;
        }

        public static string logIn(string consoleQuestion)
        {
            Console.Clear();
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|-        Welcome         -|");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|- Log in");
            Console.WriteLine(consoleQuestion);
            return Console.ReadLine();
        }
        public static string Menu(User data)
        {
            Console.Clear();
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|-        FriendFace        -|");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine($"|- {data.UserName} Logged in");
            Console.WriteLine("|-1. Add Friend");
            Console.WriteLine("|-2. Friend List");
            Console.WriteLine("|-0. Log out \n");
            Console.WriteLine("- Choose");
            string menu_input = Console.ReadLine();
            return menu_input;
        }
    }
}
