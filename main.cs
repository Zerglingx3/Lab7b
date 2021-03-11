using System;

class MainClass {
  
  // base and exponenet calculation
  // "base" is a keyword so cannot use as a variable
  public static int IntegerPower(int based, int exponent){
    
    int total =  based;

    if (exponent == 0){
     
     return 1;
    }

    for (int i=1; i < exponent; i++){

      total = total * based;
    }
    return total;
  }
  
  
  
  public static void Main (string[] args){
    
    Console.WriteLine ("Enter the base: ");
    int based = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the exponent: ");
    int exponent = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("The total is " + IntegerPower(based, exponent) + ".");


  }







}