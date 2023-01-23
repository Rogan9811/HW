Console.Write("This is 7 home work. Choose the task's number(47, 50, 52): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch(tasks)
{
    case 47:
        void FillDoubleArray(double[,] array, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-100, 100), 2);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        Console.Write("Enter n: ");
        int n47 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter m: ");
        int m47 = Convert.ToInt32(Console.ReadLine());
        double[,] array47 = new double[n47,m47];

        FillDoubleArray(array47, n47, m47);
    break;

    case 50:
        void fill2Array(int[,] array, int m, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i,j] = new Random().Next(-10, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        bool findTheNumber(int[,] array, int found, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(array[i, j] == found)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        Console.Write("Enter n: ");
        int n50 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter m: ");
        int m50 = Convert.ToInt32(Console.ReadLine());
        int[,] array50 = new int[n50,m50];

        fill2Array(array50, n50, m50);

        Console.Write("What's number you want to find?: ");
        int found = Convert.ToInt32(Console.ReadLine());
        bool isOk = false;

        isOk = findTheNumber(array50, found, n50, m50);
        if(isOk == true) Console.WriteLine("yeeeees.");
        else Console.WriteLine("Noooo.");
    break;

    case 52:
        void fill22Array(int[,] array, int m, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i,j] = new Random().Next(-10, 10);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        void middleArifmethic(int[,] array, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += array[i,j];
                }
                Console.WriteLine($"For {i+1} line middle arifmethic sum is {sum}.");
                sum = 0;
            }
        }


        Console.Write("Enter n: ");
        int n52 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter m: ");
        int m52 = Convert.ToInt32(Console.ReadLine());
        int[,] array52 = new int[n52,m52];

        fill22Array(array52, n52, m52);
        middleArifmethic(array52, n52, m52);
    break;
}