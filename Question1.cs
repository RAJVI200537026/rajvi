using System;

class Question1
{
    static void Main()
    {
        Console.WriteLine("\n --- Data Types: ---");

    
        int num1 = 5;
        Console.WriteLine("\n 5  : " + num1.GetType());


        double num2 = 5.0;
        Console.WriteLine("\n 5.0 : " + num2.GetType());

     
        bool result1 = 5 > 1;
        Console.WriteLine("\n 5>1: " + result1.GetType());


        char char1 = '5';
        Console.WriteLine("\n '5': " + char1.GetType());

   
        int num3 = 5 * 2;
        Console.WriteLine("\n 5*2 : " + num3.GetType());

        int num4 = ('5' - '0') * 2; 
        Console.WriteLine("\n '5' * 2 : " + num4.GetType());

      
        string str1 = '5' + "2";
        Console.WriteLine("\n '5' + '2' : " + str1.GetType());


        double num5 = 5 / 2.0; 
        Console.WriteLine("\n 5 / 2: " + num5.GetType());

       
        int num6 = 5 % 2;
        Console.WriteLine("\n 5 % 2: " + num6.GetType());


        int[] arr = { 5, 2, 1 };
        Console.WriteLine("\n {5,2,1}: " + arr.GetType());

   
        bool result2 = 5 == 3;
        Console.WriteLine("\n 5 == 3: " + result2.GetType());

       
        double pi = Math.PI;
        Console.WriteLine("\n PI: " + pi.GetType());
    }
}
