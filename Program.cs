using dio_dungeon.src.Entities;

namespace dotnet___poo {
    class Program {
        static void Main(string[] args) {

            Knight Arus = new Knight("Arus", 42, "Knight");
            Wizard Jennica = new Wizard("Jennica", 42, "White Wizard");

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jennica.Attack(2));
        }
    }
}
