using System;

namespace finalProject
{
    class Program
    {
        static void printMenu()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!\n");
            Console.WriteLine("1. Start New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Quit\n");
            Console.WriteLine("Enter choice:");
        }

        static void printStats(Player player)
        {
            Console.WriteLine($"{player.name}, here are your game play statistics...");
            Console.WriteLine($"Wins: {player.win}");
            Console.WriteLine($"Losses: {player.loss}");
            Console.WriteLine($"Ties: {player.tie}");
            double winloss = player.win/player.loss;
            Console.WriteLine($"Win/Loss Ratio: {winloss}");
        }

        static void playGame(Player one, int round)
        {
            Console.WriteLine($"Round {round}");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");

            int player = Console.ReadLine();
            Random rnd = new Random();
            int cpu = rnd.Next(1,3);

            if (player == cpu)
            {
                one.tie++;
                Console.WriteLine("You tie!");
            }
            if (player == 1 && cpu == 2)
            {
                one.loss++;
                Console.WriteLine("You lose!");
            }
            if (player == 1 && cpu == 3)
            {
                one.win++;
                Console.WriteLine("You win!");
            }
            if (player == 2 && cpu == 1)
            {
                one.win++;
                Console.WriteLine("You win!");
            }
            if (player == 2 && cpu == 3)
            {
                one.loss++;
                Console.WriteLine("You lose!");
            }
            if (player == 3 && cpu == 1)
            {
                one.loss++;
                Console.WriteLine("You lose!");
            }
            if (player == 3 && cpu == 2)
            {
                one.win++;
                Console.WriteLine("You win!");
            }
        }

        static void writeGame(Player player)
        {
            using (var stream = File.Open("player_log.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(player);
            }
        }

        static void printGlobalStats()
        {
            string filePath = "player_log.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<Player> list = new List<Player>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                }
            }
            else 
            {
                Console.WriteLine("File does not exist.");
            }

        }

        static void quitGame()
        {
            Application.Exit();
        }


        static void Main(string[] args)
        {
            printMenu();
            int choice = Console.ReadLine();
            Player one = new Player();

            if(choice == 1)
            {
                int round = 1;
                int game = 1;

                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                one.name = name;
                Console.WriteLine($"Hello {one.name}. Let's play!");

                if (game == 1)
                {
                    playGame(one, round);

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Play again");
                    Console.WriteLine("2. View Player Statistics");
                    Console.WriteLine("3. View Leaderboard");
                    Console.WriteLine("4. Quit");

                    game = Console.ReadLine();

                }

                if (game == 2)
                {
                    printStats(one);

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Play again");
                    Console.WriteLine("2. View Player Statistics");
                    Console.WriteLine("3. View Leaderboard");
                    Console.WriteLine("4. Quit");

                    game = Console.ReadLine();
                }
                else if (game == 3)
                {
                    printGlobalStats();
                }
                else if (game == 4)
                {
                    writeGame(one);
                    quitGame();
                }        
            }
            else if (choice == 2)
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                //if found
                Console.WriteLine($"Welcome back {name}. Let's play!");
                //if not
                Console.WriteLine($"{name}, your game could not be found.")

            }
            else if (choice == 3)
            {
                writeGame(one);
                quitGame();
            }
            else
            {
                Console.WriteLine("Please enter 1, 2 or 3");
                choice = Console.ReadLine();
            }
        }
    }
}
