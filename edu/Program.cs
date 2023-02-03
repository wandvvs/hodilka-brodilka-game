using System;


namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char[,] map =
            {
                {'@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@' },
                {'@','$',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$',' ',' ','@' },
                {'@',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ','$',' ',' ',' ',' ','@','@','@','@','@','@',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@' },
                {'@','$',' ',' ',' ',' ',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ','$',' ',' ','@' },
                {'@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@' }
            };
            Console.SetCursorPosition(0, 0);

            int userX = 7, userY = 15;
            int bagCount = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 14);
                Console.Write($"Собранные сокровища: {bagCount}");
                

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }


                Console.SetCursorPosition(userY, userX);
                Console.Write('#');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '@')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '@')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '@')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '@')
                        {
                            userY++;
                        }
                        break;
                }

                if (map[userX,userY] == '$')
                {
                    bagCount++;
                    map[userX, userY] = 'o';
                    

                }
                if (bagCount == 6)
                {
                    
                    Console.SetCursorPosition(25, 10);
                    
                    Console.WriteLine("Вы собрали все сокровища!");
                    Thread.Sleep(1000);
                    break;
                }
                Console.Clear();
            }



        }
    }
}
