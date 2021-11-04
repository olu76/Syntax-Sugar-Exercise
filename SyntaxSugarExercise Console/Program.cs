using System;

namespace SyntaxSugarExercise_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var answer = 4;

            //var response = (answer < 9) ? $"{answer} is less than {9}" : $"{9} is greater than or equal to  {9}";

            //Console.WriteLine((answer < 9) ? $"{answer} is less than {9}" : $"{9} is greater than or equal to {9}");

            //if (answer < 9)
            //{
            //    response = $"{answer} is less than {9}";
            //}
            //else
            //{
            //    response = $" {answer} is greater than or equal {9}";


        var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
            

              
         }

    }
}
  
