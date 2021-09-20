using System;

namespace TE19B_Composition
{
  public class Hero
  {

    public Hero target;

    public int hp = 100;

    public Hat headwear = new Hat();

    public void Kiss (Hero target)
    {

    }

    public void Drink(Potion p)
    {
      // hp += p.healAmount;

      p.Affect(this);

    }

  }
}