// // // задача 1
// Console.WriteLine("Введите число а");
// double a_sq = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите число b");
// double b_sq = double.Parse(Console.ReadLine());

// double b_sq2 = Math.Pow(b_sq, 2);

// if (b_sq2 == a_sq)
// {
//     Console.WriteLine(a_sq + " является квадратом числа " + b_sq);
// }

// else
// {
//     Console.WriteLine(a_sq + " не является квадратом числа " + b_sq);
// }

// задача 2
// Console.WriteLine("Введите номер ");
// int day_num = int.Parse(Console.ReadLine());

// if (day_num == 1)
// {
//     Console.WriteLine("понедельник");
// }
// else if (day_num == 2)
// {
//     Console.WriteLine("вторник");
// }
    
// else if (day_num == 3)
// {
//     Console.WriteLine("среда");
// }

// else if (day_num == 4)
// {
//     Console.WriteLine("четверг");
// }
// else if (day_num == 5)
// {
//     Console.WriteLine("пятница");
// }
// else if (day_num == 6)
// {
//     Console.WriteLine("суббота");
// }
// else if (day_num == 7)
// {
//     Console.WriteLine("воскресенье");
// }
// else if (day_num > 7)
// {
//     Console.WriteLine("такого дня не существует");
// }
            
// задача 3
// Console.WriteLine("Введите число а");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число b");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число c");
// int c = int.Parse(Console.ReadLine());

// if (a < b && b > c)
//         {
//             Console.WriteLine("макс = " + b);
//         }

//     else if (b < a && a > c)
//         {
//             Console.WriteLine("макс = " + a);
//         }

//     else if (a < c && c > b)
//         {
//             Console.WriteLine("макс = " + c);
//         }

// задача 4
// Console.WriteLine("Введите число ");
// int a_division  = int.Parse(Console.ReadLine()) % 2;
// if (a_division > 0)
// {
//     Console.WriteLine("Число нечетное");
// }
// else if (a_division == 0)
// {
//     Console.WriteLine("Число четное");
// }

// // задача 5
// Console.WriteLine("Введите число ");
// int N  = int.Parse(Console.ReadLine());
// int N_negative = N*(-1);

// while( N_negative <= N )
// {
//     Console.WriteLine(N_negative + " ");
//     N_negative++;
// }

//Задача 6
// Console.WriteLine("Введите число ");
// int N  = int.Parse(Console.ReadLine());
// int i = 1;
// while( i <= N )
// {
//     int z = i%2;
//     if (z == 0) {
//         Console.WriteLine(i);
//     }
//     i++;
// }

// //Задача 7
//  Console.WriteLine("Введите трехзначное число ");
//  float N  = int.Parse(Console.ReadLine()) % 10;
//  Console.WriteLine(N);

//Задача 8
//  Console.WriteLine("Введите трехзначное число ");
//  float N  = int.Parse(Console.ReadLine()) % 100 / 10;
//  Console.WriteLine(N);

// Задача 9
// Console.WriteLine("Введите число из отрезка:  ");
//  int N = int.Parse(Console.ReadLine());
//  int N1  = N % 100 / 10;
//  int N2  = N % 10;
//  if (N1 > N2) {
//     Console.WriteLine(N1);
//  } else {
//     Console.WriteLine(N2);
//  }

//Задача 10
// Console.WriteLine("Введите трехзначное число ");
// int N = int.Parse(Console.ReadLine());
// int N1  = N % 1000 / 100;
// int N2  = N % 10;
// Console.WriteLine(N1 + "" + N2);

//Задача 11
// Console.WriteLine("Введите первое число ");
// float N1 = float.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// float N2 = float.Parse(Console.ReadLine());

// Console.WriteLine(N2 % N1);

//Задача 12
// Console.WriteLine("Введите трехзначное число ");
// int N1 = int.Parse(Console.ReadLine());

// if (N1 >= 100) {
    // int N2  = N1 % 10;
    // Console.WriteLine(N2);
// } else {
    // Console.WriteLine("числа нет");
// }
