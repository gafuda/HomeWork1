// задача 3
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());

if (a < b && b > c)
        {
            Console.WriteLine("макс = " + b);
        }

    else if (b < a && a > c)
        {
            Console.WriteLine("макс = " + a);
        }

    else if (a < c && c > b)
        {
            Console.WriteLine("макс = " + c);
        }

