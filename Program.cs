
/*
               ///// ЗАДАЧА 1(47)
/    Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



double[,] CreateRandom2DArray()
    {
        Console.Write("Input number of rows: ");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input number of colons: ");
        double n = Convert.ToDouble(Console.ReadLine());
        

        double[,] array = new double[3,4];

        for(int i= 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            { 
                array[i,j] =  new Random().NextDouble();
                array[i,j] = Math.Round(array[i,j], 1);

            }
        } 

        return array;
    }



void Show2DArray(double[,] array)
{
     for(int i = 0; i< array.GetLength(0); i++)
     {
            for(int j =0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

             Console.WriteLine();   
     }
}

///   double [,] myArray = CreateRandom2DArray();
///   Show2DArray(myArray);

*/



                                 ///ЗАДАЧА 2 (50)
///  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.




///Запрос данных пользователя:

Console.Write("Введите координату строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

/// Генерируем целочисленный неотрицательный массив

int[,] IndexArray()
{       

        int[,] array = new int[5, 6];

        for(int i= 0; i < 5; i++)
        {
            for(int j = 0; j < 6; j++)
            { 
                array[i,j] =  new Random().Next(10, 99);

            }
        }

        return array;
    }

/// Печатаем массив в консоль

void Show2DArray(int[,] array)
{
     for(int i = 0; i< array.GetLength(0); i++)
     {
            for(int j =0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

             Console.WriteLine();   
     }
}

/// Метод нахождения элемента: 


int[,] ArrayIndex = IndexArray();
Show2DArray(ArrayIndex);

if(m>5 && n>6)
Console.WriteLine("Такого элемента нет");
else
{
object Coordinate = ArrayIndex.GetValue(m,n);
Console.WriteLine($"Значение элемента с координатами {m} и {n} = " + Coordinate);
}



                                 ///// ЗАДАЧА 3(52)////


/// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

        Console.Write("Input number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of colons: ");
        int colons = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of min: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of  max: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray()

    {
        

        int[,] array = new int[rows, colons];

        for(int i= 0; i < rows; i++)
        {
            for(int j = 0; j < colons; j++)
            { 
                array[i,j] =  new Random().Next(minValue, maxValue+1);

            }
        }

        return array;
    }



void Show2DArray(int[,] array)
{
     for(int i = 0; i< array.GetLength(0); i++)
     {
            for(int j =0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

             Console.WriteLine();   
     }
}


int[,] Array1 = CreateRandom2dArray();
Show2DArray(Array1);



int sum =0;
int Arif = 0;
int i = 0;
    
    for(int j=0; j < colons && i < rows; j++, i++)
    {
            
        sum += Array1[i,j];
        Arif = sum / rows;
        Console.WriteLine("Среднее арифмеическое столбца " + Arif);
            
    }        
        Console.WriteLine();

    
   */

    
    
