Console.Write("Choose number of home work(10, 13, 15): ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 10:
    Console.WriteLine("введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int n1 = number % 100;
    int n2 = n1 / 10;
    

    Console.WriteLine(n2);
    break;
    case 13:
    Console.Write("введите ЛЮБОЕ число: ");
    int fNumber = Convert.ToInt32(Console.ReadLine());
    string secNumb = Convert.ToString(fNumber);

    if(secNumb.Length > 2)
        {
            Console.WriteLine("this is second numb of your numb: " + secNumb[1]);
        }
    else
        {
            Console.WriteLine("here is empty... Ohps..");
        }

    break;
    
    case 15:
    Console.WriteLine("Введите номер дня недели: ");
    int day = Convert.ToInt32(Console.ReadLine());

    if(day == 1 || day == 2 ||day == 3 ||day == 4 ||day == 5)
        {
            Console.WriteLine("этот день рабочий, дуй на завод.");
        }
    else if(day == 6 || day == 7)
        {
            Console.WriteLine("этот день выходной, но у тебя срочный вызов, так что всё равно дуй на работу)");
        }
    else
        {
            Console.WriteLine("таких дней не существует, следовательно рабочие часы не будут считаться, бугаагага. Дуй на завод))");
        }

    break;
}