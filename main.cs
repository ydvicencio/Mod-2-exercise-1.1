using System;

class Program {
  public static void Main (string[] args) 
  {
    //declare number of cm to in
    const double CentimetersInInch = 2.54;

    //declare variables
    double inches1 = 5.0;
    double inches2 = 50.0;
    double inches3 = -15.0;
    double inches4 = 15994.0;

    //calculate inches to cm
    double cm1 = inches1 * CentimetersInInch;
    double cm2 = inches2 * CentimetersInInch;
    double cm3 = inches3 * CentimetersInInch;
    double cm4 = inches4 * CentimetersInInch;

    //print results
    Console.WriteLine(inches1 + " inches is " + cm1 + " centimeters.");
    Console.WriteLine(inches2 + " inches is " + cm2 + " centimeters.");
    Console.WriteLine(inches3 + " inches is " + cm3 + " centimeters.");
    Console.WriteLine(inches4 + " inches is " + cm4 + " centimeters.");
    
    
    
  }
}