// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите целое число. ");
// int x = Convert.ToInt32(Console.ReadLine()  )  ;
// if (x==0)
// {
//     Console.WriteLine ("ноль и в Африке ноль , даже в квадрате!");
// }
// else 
// {
//  x=x*x;
//     Console.WriteLine ("Квадрат этого числа будет "+ x );
// }


// Console.WriteLine("Введите два числа. Я сравню какое из них больше!");
// int a = 
// Convert.ToInt32(Console.ReadLine());
// int b = 
// Convert.ToInt32(Console.ReadLine());
// if (a>b) Console.WriteLine("Первое число больше");
// else Console.WriteLine("Второе число больше");


// Console.WriteLine("Введите три целых числа");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if ( max<b )
// {
//     max = b;
// }
// if ( max<c )
// { 
//     max = c;
// }
// Console.Write("Максимальное число" + max );


// {
// int num1=1;
// int num2=8;
// // for (int i=num1;i<num2+1;i++) Console.Write($"{i}, ");
// for (int i=num1;i<num2+1;i++) Console.Write(i+", ");
// Console.WriteLine();
// }

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// {
// int x = new Random().Next(100,1000);
// Console.WriteLine($"Generated numbers {x}");
// int x1 = x / 100;
// int x2 = x % 10;
// Console.WriteLine(x1 +" "+x2);
// }



// Дз 2 Семинар.  
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Задача 10");
// Console.Write("Введи трехзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5// 78 -> третьей цифры нет
// 32679 -> 6 

// Console.WriteLine("Задача 13 "); 
// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){ Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
//    else { 
//     Console.WriteLine("-> третьей цифры нет");
//     }

//     Console.WriteLine("Задача 15 "); 
//     Console.Write("Введи цифру, обозначающую день недели: ");
//     int dayNumber = Convert.ToInt32(Console.ReadLine());
//     void CheckingTheDayOfTheWeek (int dayNumber) {
//       if (dayNumber == 6 || dayNumber == 7) {
//       Console.WriteLine("(этот день выходной) -> да");
//       } 
//      else if (dayNumber < 1 || dayNumber > 7) {
//         Console.WriteLine("это вообще не день недели");
//      } 
//      else Console.WriteLine("(этот день не выходной) -> нет");
//    }  
//    CheckingTheDayOfTheWeek(dayNumber);



    
    