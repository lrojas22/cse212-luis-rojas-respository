// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Text;
using Microsoft.VisualBasic;
using System.Collections;
/*
Console.WriteLine("What is your First name?");
string first_name = Console.ReadLine();
Console.WriteLine("What is your Last name?");
string last_name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");*/

/*
Console.Write("Enter your grade: ");
int grade = int.Parse(Console.ReadLine());
if (grade >= 90)
{
    Console.WriteLine("Your Grade is A");
}
else if (grade >= 80)
{
    Console.WriteLine("Your Grade is B"); 
}
else if (grade >= 70)
{
    Console.WriteLine("Your Grade is C"); 
}
else if (grade >= 60)
{
    Console.WriteLine("Your Grade is D"); 
}
else 
{
    Console.WriteLine("Your Grade is F"); 
}*/

/*string response = "yes";
while( response == "yes")
{
    Console.Write("Quieres continuar?");    
        response = Console.ReadLine();
}*/

/*string response;
do
{
    Console.WriteLine("desea continuar?");
    response = Console.ReadLine();
} while  (response == "yes");

Console.WriteLine("terminado");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Numero " + i);
}

Random randomGenerator = new Random();
int magic_number = randomGenerator.Next(1, 100);
int guess ;
int attempts = 0;
do
{
    Console.WriteLine("What is your guess?");
    guess = int.Parse(Console.ReadLine());
    attempts ++ ;

    if(guess < magic_number)
    {
        Console.WriteLine ("Higher");
    }else if (guess > magic_number)
    {
        Console.WriteLine ("Lower");    
    }

} while (guess != magic_number);

Console.WriteLine("You guessed it!!!");
Console.WriteLine($"You guessed it in {attempts} attempts¡¡¡ ");

int i = 1;
List<string> colors = new List<string>();
colors.Add("green");
colors.Add("red");
colors.Add("blue");
colors.Add("brown");
colors.Add("purple");
/*foreach (string color in colors)
{
    Console.WriteLine($"Color {i}: {color}");
    i++;
}

Console.WriteLine($"We have {colors.Count} colors");*/
/*
List<int> numbers = new List<int>();
int number;
int sum = 0;
Console.WriteLine("Enter a list of numbers, type 0 when finished.");

do
{
    Console.WriteLine("Enter a number: ");
    number = int.Parse(Console.ReadLine());
    if (number != 0)
    {
        numbers.Add(number);    
    }
    
    sum += number;
    
} while (number != 0);

Console.WriteLine($"Ingresaste {numbers.Count} numeros");
Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {(double)sum/numbers.Count:F2}");
Console.WriteLine($"largest is: {numbers.Max()}");
Console.WriteLine($"largest is: {numbers.Min()}");

    void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello {userName}");
    }

    DisplayPersonalMessage("Luis");



    int Suma(int a, int b)
    {   
        int sum ;
        sum = a + b;
        return sum;
        
    }
    int output = Suma(4,25);

    Console.WriteLine($"La suma es: {output}");

    //Console.WriteLine("Hola");*/


//LISTAS Y DINAMYC ARRAYS
/*
 List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);
    numbers.Add(5);


int value = numbers[3];



for (var i = 0; i < numbers.Count; ++i)
{
    Console.WriteLine($"number: {numbers[i]}");

}

for (var i = 0; i < numbers.Count; ++i)
{
  
    Console.WriteLine($"Position: {i}");
}
*/
//TABLA MATRIZ N*N
/*
void MultipleLoops(int n)
{
    int[,] matriz = new int[n, n];

    // llenar la matriz
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matriz[i, j] = (i + 1) * (j + 1);
        }
    }

    // imprimir la matriz
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}

MultipleLoops(4);
MultipleLoops(10);


void ShortMultiplicationTable(int n)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine((i+1) * (j+i));
    }
  }
}

ShortMultiplicationTable(5);*/


Queue<int> numeros = new Queue<int>();

numeros.Enqueue(100);
numeros.Enqueue(200);
numeros.Enqueue(300);
numeros.Enqueue(400);
numeros.Enqueue(500);
numeros.Enqueue(600);
numeros.Enqueue(700);
numeros.Enqueue(800);

foreach (int n in numeros)
{
    Console.WriteLine(n);
}

int sacado = numeros.Dequeue();
Console.WriteLine($"Acabamos de sacar:{sacado}");
foreach (int n in numeros)
{
    Console.WriteLine(n);
}