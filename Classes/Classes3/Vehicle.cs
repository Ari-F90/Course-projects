
namespace Classes3
{
  public class Vehicle
{
    public virtual bool IsCar (bool terrestrial)
    {
      return terrestrial;
    }

     public virtual bool IsPlane (bool aerial)
    {
      return aerial;
    }
     public virtual bool IsShip (bool navigate)
    {
      return navigate;
    }
}
}
