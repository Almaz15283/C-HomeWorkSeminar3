﻿// See https://aka.ms/new-console-template for more information
Console.Clear();
int n = new Random().Next(10,21);
int r = n+1;
int [] clas = new int[n];
int [] clas1 = new int[r];
Console.Write("Введите рост Пети: ");
int petia = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
    {
        clas[i] = new Random().Next(100,190);
        clas1[i] = clas[i];
        clas1[r-1] = petia;
       /* Console.Write($"{clas[i]}, ");
        Console.WriteLine($"{clas1[i]}, ");
        Console.Write(clas1[r-1]);*/
    }
for ( int i = 0; i < r; i++)
    {   
        for ( int j = 0; j < (n - i); j++)
        {
            if (clas1[j] < clas1[j+1]) 
            {
                int reserv = clas1[j];
                clas1[j+1] = clas1[j];
                clas1[j] = reserv;
            }

        }
    }
for (int i = 0; i < r; i++)
{
    if (clas1[i] == petia) 
    {
        Console.WriteLine($"петя будет {i+1} в строю");
    }
     Console.Write($"{clas1[i]}, ");
    
}
