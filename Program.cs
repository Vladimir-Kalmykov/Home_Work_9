// // Задача №1.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Console.Write("Введи число N: "); 
// int N  = int.Parse(Console.ReadLine()!); 

// Console.WriteLine(PrintNumbers(N,1)); 

// // Метод
// string PrintNumbers(int start, int end) 
// { 
//     if(start == end) return start.ToString(); 
//     return (start + " " + PrintNumbers(start - 1, end)); 
// } 


// Задача №2.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите число  N"); 
// int N = int.Parse(Console.ReadLine()!); 

// Console.WriteLine("Введите число  M"); 
// int M = int.Parse(Console.ReadLine()!); 

// ///Метод 
// void NumberSum (int N, int M, int sum)
// {
//     if (N > M) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (N++);
//     NumberSum(N, M, sum);
// }
// NumberSum(N, M, 0);


// // Задача №3.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.WriteLine("Введите число  N"); 
// int N = int.Parse(Console.ReadLine()!); 

// Console.WriteLine("Введите число  M"); 
// int M = int.Parse(Console.ReadLine()!); 

// AkkermanFunction(N,M);

// void AkkermanFunction(int N, int M)
// {
//     Console.Write(Akkerman(N, M)); 
// }

// // Метод
// int Akkerman(int N, int M)
// {
//     if (N == 0)
//     {
//         return M + 1;
//     }
//     else if (M == 0 && N > 0)
//     {
//         return Akkerman(N - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(N - 1, Akkerman(N, M - 1)));
//     }
// }