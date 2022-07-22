
// Задайте двухмерный массив размером m x n,
// заполненный случайными целыми числами... 

// int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = new Random().Next(min, max+1);
//       }
//     }
//     return array;
// }
// void ShowArray(int[,]array)
// {
//  for(int i=0; i< array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i ,j]+" ");
//     }
//     Console.WriteLine();
//  }

// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите min число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите max число: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,]myArray = CreateRandomArray(rows,colums,min,max);
// ShowArray(myArray);

// решена !!!

// Задайте двухмерный массив размером m x n,
// заполненный  целыми числами от 0 до N

// int [,] CreateArray (int m, int n)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = i+j;
//       }
//     }
//     return array;
// }
// void ShowArray(int[,]array)
// {
//  for(int i=0; i< array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i ,j]+" ");
//     }
//     Console.WriteLine();
//  }

// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,]myArray = CreateArray(rows,colums);
// ShowArray(myArray);

// решена !!!

// Задача 49 : Задайте двухмерный массив найдите элементы
// у которых оба индекса четные 
// и замените 
// эти  элементы на их квадраты 
// int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = new Random().Next(min, max+1);
//       }
//     }
//     return array;
// }
// void ShowArray(int[,]array)
// {
//   Console.WriteLine();  
//  for(int i=0; i< array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i ,j]+" ");
//     }
//     Console.WriteLine();
//  }
//   Console.WriteLine();
// }
// void ЕvenArray(int[,]array)
// {
//  for(int i=2; i< array.GetLength(0); i++)
//  {
//     for (int j = 2; j < array.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         array[i,j] *= array[i,j];

//     }
//  }
//  }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите min число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите max число: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,]myArray = CreateRandomArray(rows,colums,min,max);
// ShowArray(myArray);
// ЕvenArray(myArray);
// ShowArray(myArray);
// //  решена !!!

//  Найти сумму индексов по диагонали
// int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = new Random().Next(min, max+1);
//       }
//     }
//     return array;
// }
// void ShowArray(int[,]array)
// {
//  for(int i=0; i< array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i ,j]+" ");
//     }
//     Console.WriteLine();
//  }

// }
// int SumNumber(int [,]array)
// {
//     int sum = 0 ;  
//     for(int i=0; i <array.GetLength(0); i++)
//     {
//         for (int j =0; j <array.GetLength(1); j++)
//         { 
//           if (i==j)  
//            {
//              sum += array[i, j];
//            } 
//         }
//     }
//     return sum;
// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите min число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите max число: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,]myArray = CreateRandomArray(rows,colums,min,max);
// ShowArray(myArray);
// Console.WriteLine(SumNumber(myArray));
// SumNumber(myArray);

// решена !!!

// ПРАКТИЧЕСКОЕ ЗАДАНИЕ №7
// Задача 47: Задайте двухмерный массив размером m x n,
// заполненный случайными вещественными числами... 

// double [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      double [,] array = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = Convert.ToDouble(new Random().Next(-10,10))/10;
//       }
//     }
//     return array;
// }
// void ShowArray(double[,]array)
// {
//  for(int i=0; i< array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i ,j]+" ");
//     }
//     Console.WriteLine();
//  }

// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите min число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите max число: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,]myArray = CreateRandomArray(rows,colums,min,max);
// ShowArray(myArray);

// решена !!!

// Задача 50:Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int rows = int.Parse (Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = int.Parse (Console.ReadLine());

int [,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine("введите значение элемента : "); 
int element = int.Parse(Console.ReadLine());
if (FindElement (array, element))
{
  Console.WriteLine("Элемент найден : "); 
}
 else
 {
  Console.WriteLine("Элемент  не найден : "); 
 }
 
     int [,] GetArray (int m, int n, int min, int max)
  {
     int[,] result = new int[m,n];
     for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result [i, j] = new Random().Next(min,max+1);
      }
    }
    return result;
}  
  void PrintArray (int[,] inArray)
{
 for (int i = 0; i < inArray.GetLength(0); i++)
 {
    for (int j = 0; j < inArray.GetLength(1); j++)
  
  {
    Console.Write($"{inArray [i ,j]} ");
  }
   Console.WriteLine();
 }
}     
     bool FindElement(int[,] array, int el)
   {
      for (int i = 0; i < array.GetLength(0); i++)
     {
     for (int j = 0; j < array.GetLength(0); j++)
      {
         if (array[i,j] == el) return true;
      }  
     }
     return false;
   }


// решена  

// Задача 52: Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:8
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество cтолбцов: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = GetArray (rows, columns, 0, 10);
// PrintArray(array);

//  double[]averageColumns = GetResultArray(array);
//  Console.WriteLine($"среднее арифметическое каждого столбца = {String.Join (":", averageColumns)}");
   
// int[,] GetArray(int m, int n, int min, int max)
// {
//      int [,] result =  new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         result [i, j] = new Random().Next(min,max+1);
//       }
//     }
//     return result;
// }  
// void PrintArray(int[,] inArray)
// {
//  for (int i = 0; i < inArray.GetLength(0); i++)
//  {
//     for (int j = 0; j < inArray.GetLength(1); j++)
  
//   {
//     Console.Write($"{inArray [i ,j]} ");
//   }
//    Console.WriteLine();
//  }
// }
//    double[] GetResultArray(int[,] array)
// {
//      double[]result = new double[array.GetLength(1)];
//     for (int column = 0; columns < array.GetLength(1); column++)
//     {
//     double sum = 0;
//     for (int row = 0; row < array.GetLength(0); row++)
//       {
//       sum += array[row,column];
//       }
      
//       result[column] = Math.Round(sum / array.GetLength(0), 2);
//     }

//     return result;
// }

//  Опять Задача 47: Задайте двухмерный массив размером m x n,
// заполненный случайными вещественными числами... 
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
//      double [,] array = GetArray (rows, columns, 0 ,10);
//      PrintArray(array);

// double[,] GetArray(int m, int n, int min, int max)
// {
//      double [,] result =  new double [m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         result [i, j] = new Random().NextDouble()*(max-min);
//       }
//     }
//     return result;
// }  
// void PrintArray(double[,] inArray)
// {
//  for (int i=0; i< inArray.GetLength(0); i++)
//  {
//     for (int j = 0; j < inArray.GetLength(1); j++)
//     {
//     Console.Write($"{inArray[i,j]:f1} ");
//     }
//     Console.WriteLine();
//  }
// }
