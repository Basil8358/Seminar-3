// Console.WriteLine("Hello, World!");
// Напишите программу, 

//  void GetDot( int x, int y){
//      if ( x == 0 || y == 0){
//          Console.WriteLine("Нет возможности определит четверть");
//      }else{
//          if(x > 0 && y > 0)
//              Console.WriteLine("1 четверть");
//        if(x > 0 && y < 0 )
//        Console.WriteLine("4 четверть");


//        if(x < 0 && y > 0)
//              Console.WriteLine("2 четверть");


//        if(x < 0 && y < 0 )
//        Console.WriteLine("4 четверть");

//      }
//      }
//  Console.WriteLine("введите две точки ");
//  int x1 = Convert.ToInt32(Console.ReadLine());
//  int y1 = Convert.ToInt32(Console.ReadLine());

//  GetDot(x1, y1);

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(x и y).

// void  getDot (int num)
// {
//  if (num == 1)
//     Console.WriteLine("x > 0, y > 0");
// else if (num == 2)
//     Console.WriteLine("x < 0, y > 0");
// else if (num == 3)
//     Console.WriteLine("x < 0, y < 0");
// else if (num == 4)
//     Console.WriteLine("x > 0, y < 0");
// else {
//             Console.WriteLine("введено некорретное число ");}
// } Console.WriteLine("введите номер четверти");
//  int a = Convert.ToInt32(Console.ReadLine());
//  getDot(a);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1)->5,09
// A(7,-5);B(1,-1)->7,21

// Console.Clear();
// double distaB(int x1, int x2, int y1, int y2){
//     return Math.Sqrt(Math.Pow(Math.Abs((x2-x1)),2)+ Math.Pow(Math.Abs((y2-y1)),2));
// }
// Console.WriteLine("Введите координаты x1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x2: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(distaB(y2:yB, x1:xA, y1:yA, x2:xB), 2);
// Console.WriteLine("длина отрезка: " + res);

// Напишите программу, которая принимает на вход число(N) и выдает таблицу квадратов чисел от 1 до N.
// 5-> 1,4,9,16,25.
// 2->1,2

// Console.Clear();
// void listSqrt(int n){
//     int count =1;

//     Console.Write(n + " -> ");

//     if (n > 0){

//     while(count <= n){
//         Console.Write(Math.Pow(count,2) + ", ");
//         count++;


//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);
// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

        // Console.Clear();

        // int x1 = 12321;
        // int a1 = x1 / 10;
        // int a2 = x1 / 10 / 10;
        // int a3 = x1 / 100 / 10;
        // int a4 = x1 / 1000;
        // x1 = a1 * 1000 + a2 * 100
        //  + a3 * 10 + a4;
        // Console.Write(0 < x1);

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// double distaB (int x1, int x2, int y1, int y2, int z1, int z2){
//      return Math.Sqrt(Math.Pow(Math.Abs((x2-x1)),3)+ Math.Pow(Math.Abs((y2-y1)),3)+ Math.Pow(Math.Abs((z2-z1)),3));
//  }
//  Console.WriteLine("Введите координаты x1: ");
//  int xA = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координаты y1: ");
//  int zA = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координаты z1: ");
//  int xB = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координаты z2: ");
//  int zB = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координаты x2: ");
//  int yA = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координаты y2: ");
//  int yB = Convert.ToInt32(Console.ReadLine()); 


//  double res = Math.Round(distaB(y2:yB, x1:xA,z1:zA, z2:zB, y1:yA, x2:xB));
//  Console.WriteLine("длина отрезка: " + res);

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Clear();
//  void tableofcubes(int n){
//     int count =1;
//     Console.Write(n + " -> ");
//     while(count <= n){
//         Console.Write(Math.Pow(count, 3) + ", ");
//         count++;
//      }
//       }
//   Console.WriteLine("Введите число: ");
//   int num = Convert.ToInt32(Console.ReadLine());

// tableofcubes(num);
