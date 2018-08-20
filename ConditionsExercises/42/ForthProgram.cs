/*4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
*/

using System;

namespace ForthProgram{
  //Speed Camera
  class FirstProgram{

    public int extraSpeed;

    public static void Main(String[] args){

      FirstProgram fProgram = new FirstProgram();
      fProgram.SpeedLimit();

    }

    public void SpeedLimit(){
      Console.Write("Enter the Speed Limit : ");
      int speedLimit = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the Speed of a Car : ");
      int speedOfCar = Convert.ToInt32(Console.ReadLine());

      if(speedOfCar >= speedLimit){
        //Calculate Demerit Points
        extraSpeed = speedOfCar - speedLimit;
        CalculateDemeritPoint(extraSpeed);
      }
      else{
        Console.WriteLine("OK");
      }
    }

    public void CalculateDemeritPoint(int NextraSpeed){
      Console.WriteLine("Not OK");

      int demeritPoints = (int)NextraSpeed/5;
      Console.WriteLine("Demerit Points : {0}", demeritPoints);

      if(demeritPoints <= 12){
        Console.WriteLine("");
      }
      else{
        Console.WriteLine("You are Running too fast. Your License is Suspended.");
      }
    }

  }
}
