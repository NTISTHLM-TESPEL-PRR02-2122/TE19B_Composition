using System;

namespace TE19B_Composition
{
  public class Potion
  {
    // public int healAmount = 30;

    public void Affect(Hero target)
    {
      target.hp += 30;
    }
  }
}