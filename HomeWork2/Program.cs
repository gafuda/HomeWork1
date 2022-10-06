// Задача 1
// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// String[] na4 = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
// Console.WriteLine("Введите число ");
// int N1 = int.Parse(Console.ReadLine());
// if(na4[N1 - 1] == "Суббота" | na4[N1 - 1] == "Воскресенье") {
//     Console.WriteLine("Не выходные");
// }

// Задача 2
// По двум заданным числам проверять является ли одно квадратом другого
// Console.WriteLine("Введите число а");
// double a_sq = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b");
// double b_sq = double.Parse(Console.ReadLine());
// double b_sq2 = Math.Pow(b_sq, 2);
// if (b_sq2 == a_sq)
// {
//     Console.WriteLine(a_sq + " является квадратом числа " + b_sq);
// }

// Задача 3
// Задать номер четверти, показать диапазоны для возможных координат
// {
//     Console.WriteLine("Введите x: ");
//     double x = Convert.ToDouble(Console.ReadLine());
 
//     Console.WriteLine("Введите y: ");
//     double y = Convert.ToDouble(Console.ReadLine());
 
//         if (x > 0)
//         {
//             if (y > 0)
//                 Console.WriteLine("I четверть");
//             else if (y < 0)
//                  Console.WriteLine("IV четверть");
//         }
//         else if (x < 0)
//         {
//             if (y > 0)
//                 Console.WriteLine("II четверть");
//             else if (y < 0)
//                 Console.WriteLine("III четверть");
       
//         }}
    

// // Задача 4
// // Программа проверяет пятизначное число на палиндромом.
// Console.WriteLine("Введите число ");
// int N1 = int.Parse(Console.ReadLine());
// if (
//     (N1 % 10) == (N1 % 100000 / 10000) &
//     (N1 % 100 / 10) == (N1 % 10000 / 1000)
// ) {
//     Console.WriteLine("Число является палиндромом");
// }


// // Задача 5
// Найти расстояние между точками в пространстве 2D/3D

// Console.WriteLine("Введите точку а: ");
// double a = Convert.ToDouble(Console.ReadLine());
 
// Console.WriteLine("Введите точку b: ");
// double b = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите точку c: ");
// double c = Convert.ToDouble(Console.ReadLine());

// double d = a*a + b*b + c*c;
// d = Math.Sqrt(d);

// Console.WriteLine("Расстояние между точками равно " + d);
