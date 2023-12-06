//Realizati un program care va calcula distanta in timpi de la pamant la luna.
//tema=> de adaugat ca si functionalitate si posibilitatea de a calcula instanta in timp de la pamant la marte si de la pamant la soare 
// 384.400 km 

using System;
using System.Net.WebSockets;

using CalculatorTimpStiintific;

class Program
{
    static void Main(string[] args)
    {

        CalculareaClaseiInTimp anLumina = new CalculareaClaseiInTimp();

        Console.WriteLine($"ORELE SUNT = {anLumina.ObtinereOraConcreta()} H");

        Console.WriteLine($"MINUTELE SUNT = {anLumina.CalculareInTimpMinute()} MIN ");

    }
}