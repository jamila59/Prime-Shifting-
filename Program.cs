using System;
using System.Collections.Generic;


namespace Prime.Numbers {

  class Program {
     
     public static void Main()
     {
        Console.WriteLine("Enter your number to check for prime numbers");
        int userInput = int.Parse(Console.ReadLine());

        Prime userNumberObject = new Prime(userInput);
        userNumberObject.SetNumber(50);

        List<int> ourList = refv.FindPrimes();

          foreach (int prime in ourList)
          {
            Console.WriteLine(prime);
          }

     }
  }
}






/* -------------------------------------------------------------------------------------------------------- */

// Static Method && NO constructor used in the solution below


namespace Prime.Numbers {

  class Program {
     
     public static void Main()
     {
        Console.WriteLine("Enter your number to check for prime numbers");
        int userInput = int.Parse(Console.ReadLine());

        List<int> ourList = Prime.FindPrimes(userInput);

        foreach (int eachPrime in ourList)
        {
          Console.WriteLine(eachPrime);
        }

     }

  }

}





