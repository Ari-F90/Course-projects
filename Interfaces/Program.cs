// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
  class Program
  {
    static void Main (string[] args)
    {
      Animal animal = new Animal();
      Console.WriteLine(animal.Walk());
    }

  }
}
