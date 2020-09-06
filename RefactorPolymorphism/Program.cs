using System;

namespace RefactorPolymorphism
{
    public abstract class Status
    {
        public abstract string GetStatusDescription();
    }

    public class DefaultStatus : Status
    {
        public override string GetStatusDescription() => "I have never been set";
    }

    public class NewStatus : Status
    {
        public override string GetStatusDescription() => "I am new!";
    }

    public class ActiveStatus : Status
    {
        public override string GetStatusDescription() => "I am active";
    }

    public class DeactivatedStatus : Status
    {
        public override string GetStatusDescription() => "I have been deactivated";
    }

    public class Kata : Status
    {
        private readonly Status _status;

        public Kata() : this(new DefaultStatus())
        {
        }

        public Kata(Status status)
        {
            _status = status;
        }

        public override string GetStatusDescription()
        {
            return _status.GetStatusDescription();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var kata = new Kata();

            Console.WriteLine(kata.GetStatusDescription());
            Console.ReadKey();
        }
    }
}

