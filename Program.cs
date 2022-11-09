// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3

Console.Write($"Введите число М(количество чисел) через пробел: ");
string str = Console.ReadLine();
var arrString = str.Split(" ");

int[] arr = Array.ConvertAll(arrString, int.Parse);
int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0 ) 
    {
      count += 1;
    } 
  }
Console.WriteLine($"Чисел больше 0: {count} штук/и");


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

System.Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());                

double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;               

System.Console.WriteLine($"Точка пресечения двух прямых X:{x}; Y:{y}");
Console.ReadLine();


