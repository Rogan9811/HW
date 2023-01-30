void fill2Array(int[,] array)
{
    Console.WriteLine("Вот ваш случайно-заполеннй массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "       ");
        }
        Console.WriteLine(string.Empty);
    }
}

void Print2x2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "       ");
        }
        Console.WriteLine(string.Empty);
    }
}

Console.Clear();
Console.Write("This is 7 home work. Choose the task's number(54, 56, 58, 60, 62): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch(tasks)
{
    case 54:
        Console.Write("Enter n: ");
        int row54 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter m: ");
        int column54 = Convert.ToInt32(Console.ReadLine());
        int[,] array54 = new int[row54, column54];

        fill2Array(array54);

        for (int i = 0; i < array54.GetLength(0); i++)
        {
            for (int j = 0; j < array54.GetLength(1); j++)
            {
                int sorted = j - 1;
                while (sorted > -1 && array54[i, sorted] < array54[i, sorted + 1])
                {
                    int temp = array54[i, sorted];
                    array54[i, sorted] = array54[i, sorted + 1];
                    array54[i, sorted + 1] = temp;
                    sorted--;
                }
            }
        }

        Console.WriteLine("Вот ваш отсортированный массив: ");
        Print2x2Array(array54);
    break;

    case 56:
        void minSumOfRowArray(int[,] array)
        {
            int MidSum = 0;
            int[] min = new int[array.GetLength(0) + array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    MidSum += array[i, j];
                    min[i] = MidSum; 
                }
                Console.WriteLine($"For {i+1} row's sum is {MidSum}.");
                MidSum = 0;
            }

            int count = 0;
            int minTi = min[0];
            Console.WriteLine(string.Join(',', min));

            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                if(minTi > min[i]) 
                {
                    minTi = min[i];
                    count = i;
                }
            }
            Console.WriteLine($"Наименьшую сумму имеет {count + 1} строка.");
        }


        Console.Write("Enter n: ");
        int row56 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter m: ");
        int column56 = Convert.ToInt32(Console.ReadLine());
        int[,] array56 = new int[row56,column56];

        fill2Array(array56);
        minSumOfRowArray(array56);
    break;

    case 58:
        int[,] matrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix2.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum += matrix1[i,k] * matrix2[k,j];
                    }
                    result[i,j] = sum;
                }
            }
            return result;
        }

        Console.Write("Введите количесво строк первой матрицы: ");
        int rowsFirst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количесво столбцов первой матрицы: ");
        int columnFirst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количесво строк второй матрицы: ");
        int rowsSecond = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количесво столбцов второй матрицы: ");
        int columnSecond = Convert.ToInt32(Console.ReadLine());

        if(rowsFirst != columnSecond) Console.WriteLine("Такие матрицы нельзя перемножить.");

        int[,] matrix1 = new int[rowsFirst, columnFirst];
        int[,] matrix2 = new int[rowsSecond, columnSecond];

        fill2Array(matrix1);
        Console.WriteLine();
        fill2Array(matrix2);
        Console.WriteLine();

        int[,] newMatrix = matrixMultiplication(matrix1, matrix2);
        Console.WriteLine();
        Print2x2Array(newMatrix);
    break;

    case 60:
        bool vertificationNumber(int[] savedNumbers, int check)
        {
            int count = 0;
            for (int i = 0; i < savedNumbers.Length; i++)
            {
                if(savedNumbers[i] == check)
                {
                    count ++;
                }
            }
            if(count > 1) return false;
            else return true;
        }

        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter z: ");
        int z = Convert.ToInt32(Console.ReadLine());
        int[,,] array60 = new int[x, y, z];
        int[] savedNums = new int[x*y*z];

        for (int i = 0; i < array60.GetLength(0); i++)
        {
            for (int j = 0; j < array60.GetLength(1); j++)
            {
                for (int k = 0; k < array60.GetLength(2); k++)
                {
                    array60[i, j, k] = new Random().Next(10, 100);

                    int num = array60[i, j, k];

                    for (int m = 0; m < savedNums.Length; m++)
                    {
                        if(savedNums[m] != num && savedNums[m] == 0) 
                        {
                            savedNums[m] = num;
                            break;
                        }
                    }
                    
                    bool isOk = vertificationNumber(savedNums, num);

                    if(isOk == false)
                    {
                        while(isOk == false)
                        {
                            isOk = true;
                            array60[i, j, k] = new Random().Next(10, 100);
                            num = array60[i, j, k];
                            for (int m = 0; m < savedNums.Length; m++)
                            {
                                if(savedNums[m] != num && savedNums[m] == 0)
                                {
                                        savedNums[m] = num;
                                        break;
                                }
                                else
                                {
                                    isOk = false;
                                    break;
                                }
                            }
                            if(isOk == true) vertificationNumber(savedNums, num);
                        }
                    }

                    Console.Write(array60[i, j, k] + $"({i}, {j}, {k}) ");
                }
            Console.WriteLine();
            }
        }
    break;

    case 62:
        Console.Write("Enter n: ");
        int row62 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter m: ");
        int column62 = Convert.ToInt32(Console.ReadLine());
        int[,] array62 = new int[row62, column62];

        int templ = 0;
        int row = 0;
        int column = 0;
        array62[row,column] = templ;

        while(templ <= array62.GetLength(0) * array62.GetLength(1) - 1)
        {
            templ ++;
            array62[row,column] = templ;

            if( column + 1 >= row && row + column < array62.GetLength(1) - 1) column ++;

            else if( row < column && row + column >= array62.GetLength(0) - 1) row++;

            else if(column <= row && row + column > array62.GetLength(1) - 1) column--;

            else row--;

        }

        Console.WriteLine();
        Print2x2Array(array62);
    break;
}