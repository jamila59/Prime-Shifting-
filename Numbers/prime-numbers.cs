using System;
using System.Collections.Generic;



namespace Prime.Numbers {

  public class Prime 
  {
    private int _number;

    public Prime(int number){
      this._number = number;
    }

    public void GetNumber(){
       return this._number;
     }
     
    public void SetNumber(int newNumber){
       this._number = newNumber;
     }

    public  List<int> FindPrimes() {

      List<int> primeList = new List <int>(){};

      for (int i = this._number; i >= 2; i--)
      {
        if ((i % 7 != 0 ) && (i % 5 != 0) && (i % 3 != 0) &&( i % 2 != 0))
        {
          primeList.Add(i);
        }
      }
      return primeList;
    }   
    
  }
}




/*---------------------------------------------------------------------------------------------------------- */

// Static Method && NO constructor used in the below



namespace Prime.Numbers {

  public class Prime 
  {

    public static List<int> FindPrimes(int maxNumber) {

      List<int> primeList = new List <int>(){};

      for (int i = 2; i <= maxNumber; i++)
      {
        if (i == 2 || i ==3 || i == 5 || i == 7)
        {
          primeList.Add(i);
        }
        if ((i % 7 != 0) && (i % 5 != 0) && (i % 3 != 0) &&( i % 2 != 0))
        {
          primeList.Add(i);
        }
      }    
      return primeList;
    } 
    
  }
}



