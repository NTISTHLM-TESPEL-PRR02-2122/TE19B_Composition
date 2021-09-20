using System;

namespace TE19B_Composition
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero mario = new Hero();
      Hero luigi = new Hero();

      mario.target = luigi;
      luigi.target = mario;

      Console.WriteLine(mario.target.target.target.target.hp);


      // bengt.headwear.weapon.damage

      // Potion healthPotion = new Potion();

      // bengt.Drink(healthPotion);

      // bengt.Drink(new Potion());

      // Hero albert = bengt;
      // int test = 100;

      // int i = 100;
      // int k = i;

      // EnvironmentDamage(bengt);
      // Reduce(test);

      // Console.WriteLine(bengt.hp);
      // Console.WriteLine(test);
      Console.ReadLine();
    }

    static void EnvironmentDamage(Hero target)
    {
      target.hp -= 50;
    }

    static void Reduce(int original)
    {
      original -= 50;
    }
  }
}
