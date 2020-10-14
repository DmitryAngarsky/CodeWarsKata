using System;
using System.Linq;
using System.Reflection;

namespace AdamEve
{
    public sealed class Adam : Male
    {
        public string Name = "Adam";
        private static Adam _instance;
        
        private Adam()
        {
            
        }

        public static Adam GetInstance()
        {
            return _instance ??= new Adam();
        }
    }

    public sealed class Eve : Female
    {
        public string Name = "Eve";
        private static Adam _adamInstance { get; set; }
        private static Eve _eveInstance;

        private Eve(Adam adam)
        {
            _adamInstance = adam;
        }

        public static Eve GetInstance(Adam adam)
        {
            _adamInstance = adam ?? throw new ArgumentNullException();
            
            return _eveInstance ??= new Eve(_adamInstance);
        }
    }

    public class Male : Human
    {
        public Male(string name, Female mother, Male father) : base(name, mother, father)
        {
            
        }

        protected Male()
        {
            
        }
    }

    public class Female : Human
    {
        public Female(string name, Female mother, Male father) : base(name, mother, father)
        {
            
        }

        protected Female()
        {
            
        }
    }

    public abstract class Human
    {
        protected Human(string name, Female mother, Male father)
        {
            Name = name ?? throw new ArgumentNullException();
            Mother = mother ?? throw new ArgumentNullException();
            Father = father ?? throw new ArgumentNullException();
        }

        protected Human()
        {
            
        }

        public string Name { get; }
        public Male Father { get; }
        public Female Mother { get; }
    }

    internal static class Program
    {
        private static void Main()
        {
            Adam adam = Adam.GetInstance();
            Eve eve = Eve.GetInstance(adam);
            Male seth = new Male("Seth", eve, adam);
            Female azura = new Female("Azura", eve, adam);
            Male enos = new Male("Enos", azura, seth); 
            
            Console.WriteLine(((Human)enos).Name);
            Console.ReadKey();
        }
    }
}