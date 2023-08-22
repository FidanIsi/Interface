namespace ConsoleApp1
{
    interface IPerson
    {
        void Speak();
    }

    public class RussianPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Privet");
        }
    }

    public class FrenchPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Bonjour");
        }
    }

    public class SpanishPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Hola");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var RussianPerson = new RussianPerson();
            var FrenchPerson = new FrenchPerson();
            var SpanishPerson = new SpanishPerson();
            RussianPerson.Speak();
            FrenchPerson.Speak();
            SpanishPerson.Speak();
        }
        
    }
}