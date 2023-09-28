using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Classes4
{
  public class Vehicle
  {
    private int Wheels { get; set; }
    private int Doors { get; set; }

    public Vehicle()
    {
      Wheels = 4;
      Doors = 5;
    }

       public Vehicle(int doors)
    {
      Wheels = 4;
      Doors = doors;
    }

       public Vehicle(int wheels, int doors)
    {
      Wheels = wheels;
      Doors = doors;
    }
  }
}
