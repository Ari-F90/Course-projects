// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
  class Program
  {
    static void Main (string[] args)
    {
      Animal cat = new Animal{
        Type = 'cat',
        HairColor = 'brown',
        IsDomestic = true,
        Legs = 4,
      };

      Animal elephant = new Animal();
      elephant.Type = "elephant";
      elephant.HairColor = "grey";
      elephant.IsDomestic = false;
      elephant.Legs = 4;
    }
  }
}

