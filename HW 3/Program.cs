Console.WriteLine("Введите номер дзхи задачки там плз оч нада(19, 21, 23): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch (tasks)
{
    case 19:
        Console.WriteLine("проверка на полидромность(так можно?), введите 5-тизначное число: ");
        string numb = Convert.ToString(Console.ReadLine());

        void vertification(string numb)
        {
            if (numb[0] == numb[4] || numb[1] == numb[3])
            {
                Console.WriteLine($"Ето число {numb} палиндрум-друм");
            }
            else
            {
                Console.WriteLine("nooooo");
            }
        }

        if (numb.Length != 5)
        {
            Console.WriteLine("Введи норм число пжлста");
        }
        else
        {
            vertification(numb);
        }

        break;
    case 21:
        //Для первой точки
        Console.WriteLine("введите Х-координату 1 пточки: ");
        double X1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите Y-координату 1 точки: ");
        double Y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите Z-координату 1 точки: ");
        double Z1 = Convert.ToInt32(Console.ReadLine());

        //Для второй точки
        Console.WriteLine("введите Х-координату 2 пточки: ");
        double X2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите Y-координату 2 точки: ");
        double Y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите Z-координату 2 точки: ");
        double Z2 = Convert.ToInt32(Console.ReadLine());

        // Расстояние
        double rast = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));

        Console.WriteLine("вот расстояние между точками: " + rast);

        break;

    case 23:
        
                Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        void PositivePrintCube(int cube)
        {
            for (double i = 1; i <= cube; i++)
            {
                double ii = i;
                ii = Math.Pow(ii, 3);
                Console.Write(ii + " ");
            }
        }   

        void NegativePrintCube(int cube)
        {
            for (double i = 1; i <= cube; i++)
            {
                double ii = i;
                ii = Math.Pow(ii, 3);
                Console.Write(-ii + " ");
            }
        }

        if(number>=0)
        {
            PositivePrintCube(number);
        }
        else
        {
            number = number * -1;
            NegativePrintCube(number);
        }

        break;
}