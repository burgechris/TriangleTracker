using System;
using System.Collections.Generic;

class Triangle
{
    public int sideA {get; set;}
    public int sideB {get; set;}
    public int sideC {get; set;}

public Triangle(int side1, int side2, int side3)
{
    sideA = side1;
    sideB = side2;
    sideC = side3;
}
public string triangleChecker()
{
    string outputString;
    if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
    {
        outputString = "Not a triangle";
    }
    else if(sideA == sideB && sideB == sideC)
    {
        outputString  = "Equilateral";
    }
    else if(sideA == sideB || sideB == sideC || sideA == sideC)
    {
        outputString = "Icosceles";
    }
    else 
    {
         outputString = "Scalene";
    }
    return outputString;
}
}
class Program 
{
    public static void Main()
    {
        Console.WriteLine("Please enter in 3 sides for the triangle checker");
        int side1 = int.Parse(Console.ReadLine());
        int side2 = int.Parse(Console.ReadLine());
        int side3 = int.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(side1, side2, side3);
        Console.WriteLine(triangle.triangleChecker());
    }
}