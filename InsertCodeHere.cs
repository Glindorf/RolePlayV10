using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar");
            Warrior warriorB = new Warrior("Lagertha");

            System.Console.WriteLine($"Warrior A is at level {warriorA.Level}");
            System.Console.WriteLine($"Warrior B is at level {warriorB.Level}");

            warriorA.increaseLevel();
            warriorB.increaseLevel();


            Console.WriteLine($"Warrior A is called {warriorA.Name} and is now at level {warriorA.Level}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} and is now at level {warriorB.Level}");

            // The LAST line of code should be ABOVE this line
        }
    }
}