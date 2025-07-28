using System.Drawing;

namespace Assesment
{
    internal class Program
    {



        static void Main(string[] args)
        {

            #region Q1 

            //int.TryParse(Console.ReadLine(),out int Q1Number);
            //if (Q1Number % 2 == 0) 
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //    Console.WriteLine("Odd");

            #endregion

            #region Q2

            //char.TryParse(Console.ReadLine(), out char Q16Char);

            //if ("aeiouAEIOU".Contains(Q16Char))
            //    Console.WriteLine("Vowel");

            //else
            //    Console.WriteLine("Constant");




            #endregion

            #region Q3

            //int.TryParse(Console.ReadLine(), out int Q3MonthNumber);

            //Console.WriteLine(DateTime.DaysInMonth(2025, Q3MonthNumber));


            #endregion

            #region Q4

            //int.TryParse(Console.ReadLine() , out int Q4Number);
            //if (Q4Number >= 3) 
            //{
            //    for (int i = 2; i < Q4Number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q5

            //int.TryParse(Console.ReadLine() , out int Base);
            //int.TryParse(Console.ReadLine() , out int Power);
            //int Res;
            //if (Power > 0)
            //{
            //    Res = 1;
            //    for (int i = 0; i < Power; i++)
            //    {
            //        Res *= Base;
            //    }
            //}
            //else
            //    Res = 0;


            #endregion

            #region Q6

            //string Q6String = Console.ReadLine();
            //if (Q6String != null) 
            //{
            //    for (int i = Q6String.Length -1; i >= 0; i--)
            //    {
            //        Console.Write(Q6String[i]);
            //    }

            //}

            #endregion

            #region Q7


            //int.TryParse(Console.ReadLine() , out int MetrixSize);
            //int[,] Metrix = new int[MetrixSize, MetrixSize];

            //for (int i = 0; i < Metrix.Rank; i++)
            //{
            //        Metrix[i, i] = 1;
            //}
            //for (int i = 0; i < Metrix.Rank; i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < Metrix.Length; j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.Write("[");  
            //        }
            //        Console.Write($"[{Metrix[i, j]}]");
            //        if (j == Metrix.Length-1) 
            //        {
            //            Console.Write("]");
            //        }
            //    }
            //    Console.Write("|");
            //}
            #endregion

            #region Q8

            //int[] Arr = { 2, 4, 3, 65, 3, 56, 7, 8, 4, 2, 35, 6, 234, 5 };

            //for (int i = 0; i < Arr.Length -1; i++)
            //{
            //    for (int j = 0; j < Arr.Length - i - 1; j++)
            //    {
            //        if (Arr[j] > Arr[j+1])
            //        {
            //            var Temp = Arr[j];
            //            Arr[j] = Arr[j+1];
            //            Arr[j+1] = Temp;

            //        }
            //    }
            //}
            //Console.WriteLine($"Max = {Arr[Arr.Length-1]}");
            //Console.WriteLine($"Min = {Arr[0]}");

            #endregion

            #region Q9
            // Here I Was Trying TO Use Dinamic Window
            //int[] Arr2 = { 1, 2, 3, 54, 23, 5, 2, 3, 3, 2, 4, 5, 7, 0, 0, 0, 7 };
            //int MaxDistance = 0,TempMaxDistance = 0 , Distance =0;
            //bool isFound = false;

            //for (int i = 0; i < Arr2.Length; i++)
            //{
            //    for ( int j = i +1; j < Arr2.Length; j++)
            //    {
            //        Distance++;
            //        if (Arr2[i] == Arr2[j])
            //        {
            //            isFound = true;
            //            TempMaxDistance += Distance;
            //        }
            //    }
            //    if (TempMaxDistance > MaxDistance) 
            //    {
            //        MaxDistance = TempMaxDistance;
            //    }
            //    Distance = 0;
            //    TempMaxDistance = 0;
            //}
            //Console.WriteLine($"Longest Distance = {MaxDistance}");
            #endregion

            #region Q10 - Enum Permissions

            //Permissions p = new Permissions();
            //p = (Permissions)13;
            //Console.WriteLine(p);
            //p |= (Permissions)2;
            //Console.WriteLine(p);
            //p |= (Permissions)2;
            //Console.WriteLine(p);
            #endregion

            #region Q11 - Enum Colors 

            //string ColorName = Console.ReadLine();
            //if (Enum.TryParse<Colors>(ColorName, true, out Colors Result))
            //{
            //      Console.WriteLine($"{ColorName} Is A Primary Color");
            //}else
            //{
            //      Console.WriteLine("{ColorName} Is NOT A Primary Color");
            //}

            #endregion

            #region Q12

            //Person[] Q3Persons =
            //{
            //    new Person(30 , "Ahmed"),
            //    new Person(20 , "Ahmed"),
            //    new Person(10 , "Ahmed"),
            //};

            //int HighestAgeIndex = 0;

            //if (Q3Persons != null && Q3Persons.Length > 0)
            //{
            //    int? maxAge = Q3Persons[0].Age;
            //    for (int i = 1; i < Q3Persons.Length; i++)
            //    {
            //        if (Q3Persons[i].Age > maxAge)
            //        {
            //            maxAge = Q3Persons[i].Age;
            //            HighestAgeIndex = i;
            //        }
            //    }
            //}

            //Console.WriteLine(Q3Persons[HighestAgeIndex].ToString());


            #endregion

        }
    }
}
