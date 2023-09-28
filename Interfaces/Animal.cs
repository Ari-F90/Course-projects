using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Interfaces
{
  public class Animal: IAnimal
  {
    public void Walk()
    {
      Console.WriteLine('It walks');
    }
    public bool IsDog()
    {
        return true;
    }
    public void Jump()
    {
       Console.WriteLine('It jumps');
    }
  }
}
