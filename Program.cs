/*
 * Author: Gabriela Benavides
 * Course: COMP-OO3A
 * Purpose: code for Lecture Activity 5
 * 
 */

using System.Numerics;

namespace COMP003A.LectureActivity5;
   { 
       internal class Program
       {
       
           static void Main(string[] args)
      
           { 
        
               Console.WriteLine("".PadRight(50,'*'));
               Console.WriteLine("Methods & XML Comments");
               Console.WriteLine("".PadRight(50,'*'));
               Console.WriteLine("/n");

               HelloWorld(); // call to HelloWorld()
               HelloWorld("Grace hopper"); // call to HelloWorld (string Name)
               HelloWorld("Donald Knuth"); // call to HelloWorld (string name) again with a differnt parameter value
               HelloWorld("Alan Turing", DateTime.Now.Year - 1912); // call to HelloWorld (string name, inputAge), which is an overload method
               HelloWorld("Ada Lovelace", DateTime.Now.Year - 1815); // call to HellWorld (string name, int inputAge) again
               HelloWorld("Charles Babbage", DateTime.Now.Year - 1791); // call to HelloWorld (string Name, int inputAge) again
               
               Console.WriteLine("/n");
               Console.Write("Enter value for inputNumber1: ");
               decimal inputNumber1 = Convert.ToDecimal(Console.ReadLine());
               Console.Write("Enter Value for inputNumber2: ");
               decimal inputNumber2 = Convert.ToDecimal(Console.ReadLine());
               
               // call to sum (decimal numl, decimal num2) and storing the return value in a variable
               decimal sum = Add(inputNumber1, inputNumber2);
               Console.WriteLine($"summation: {sum}"); // output the value of sum to console
               
               // if you don't plan on using a variable, you can simplify the method call like the line below
               Console.WriteLine($"Subtraction: {Subtract (inputNumber1, inputNumber2 )}");
               Console.WriteLine($"Multiplication: {Multiply (inputNumber1, inputNumber2) }");
               Console.WriteLine($"Division:  {Divide (inputNumber1, inputNumber2) }");
               Console.WriteLine($"Remainder: {Remainder (inputNumber1, inputNumber2) }");
               
               // methods can call other methods too
               // below is an example of a method calling itself, also known as recursion
               Console.WriteLine("/n");
               Inception("This is inception level ", 5);
           }  // Main() close
           
           /* XML comments can call other methods too
            * if you type '//' on top of a class or method,
            * visual studio will populate the structure for you
            * otherwise, you would have to use the following opening AND closing tags (similar to most html elements)
            * <summary></sammary> used to describe the return value
            *
            * there are other tages in https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recomm ended-tages
            */
           
           // NOTE: Method definitions are programmed inside the class { } code block, not inside Main () { }
           /// Method without parameters and return value
           /// </summary>
           static void HelloWorld()
           {
               Console.WriteLine("Hello World");
           }

           /// <summary>
           /// Method overloading with one parameter but return vale
           /// Method overloading => same method name but different signature (different parameters)
           /// </summary>
           /// <param name="inputName"> Integer input</param>
           static void HelloWorld(string inputName)
           {
               Console.WriteLine($"Hello, {inputName}");
           }

           /// <summary>
           /// Method overloading with multiple parameters but no return vale
           /// </summary>
           /// <param name="inputName">String input</param>
           /// <param name="inputName"Integer input</param>
           static void HelloWorld(string inputName, int inputAge)
           {
               Console.WriteLine($"Hello, {inputName}, age {inputAge}");
               // you can add more code here
           }

           /// <summary>
           /// Method for adding two numeric variables
           /// </summary>
           /// <param name="num1">Decimal input</param>
           /// <param name="num2">Decimal input</param>
           /// <returns>Sum of two decimal inputs>/returns>
           static decimal Add(decimal num1, decimal num2)
           {
               //you can add more code here before the return statement
               return num1 + num2;
           }

           /// <summary>
           /// Method for subtracting two numeric variables
           /// </summary>
           /// <Param name="num1">Decimal input>/param>
           /// <param name="num2">Decimal input>/param>
           /// <returns>Difference of two decimal inputs</returns>
           static decimal Subtract(decimal num1, decimal num2)
           {
               return num1 - num2;
           }

           /// <summary>
           /// Method for multiplying two numric variables
           /// </summary>
           /// <param name="num1">Decimal input</param>
           /// <param name="num2">Decimal input</param>
           /// <returns>Product of two decimal inputs</returns>
           static decimal Multiply(decimal num1, decimal num2)
           {
               return num1 - num2;
               
           }

           /// <summary>
           /// Method for dividing two numeric variables
           /// </summary>
           /// <param name="num1">Decimal input</param>
           /// <param name="num2">decimal input</param>
           /// <returns>Quotient of two decimal inputs</returns>
           static decimal Divide(decimal num1, decimal num2);
           {
               return num1 / num2;
           }

           /// <summary>
           /// Method for getting the reminder after dividing two numceric variables
           /// </summary>
           /// <param name="num1">Decimal input</param>
           /// <param name="num2">Decimal input</param>
           /// <returns>Remainder after dividing two decimal inputs</returns>
           static decimal Remainder(decimal num1, decimal num2)
           {
               return num1 % num2;
           }

           /// <summary>
           /// Recursive methos
           /// </summary>
           /// <param name="message">String input to print to console</param>
           /// param name="counter">Integer input used as a looping counter</param>
           static void Inception(string message, int counter)
           {
               Console.WriteLine($"{message} {counter}");
               counter--;
               if(counter >=0) Inception(message, counter--);
               
           }
       }
   }
