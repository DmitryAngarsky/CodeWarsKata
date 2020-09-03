using System;

namespace PatternCraftStrategy
{
    public interface IUnit
    {
        int Position { get; set; }
        void Move();
        IMoveBehavior MoveBehavior { get; set; }
    }

    public interface IMoveBehavior
    {
        void Move(IUnit unit);
    }

    public class Fly : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 10;
        }
    }

    public class Walk : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 1;
        }
    }

    public class Viking : IUnit
    {
        public Viking()
        {
            MoveBehavior = new Walk();
        }

        public IMoveBehavior MoveBehavior { get; set; }

        public int Position { get; set; }

        public void Move()
        {
            MoveBehavior.Move(this);
        }
    }

    public class Dragon : IUnit
    {
        public Dragon()
        {
            MoveBehavior = new Fly();
            Position = 15;
        }

        public IMoveBehavior MoveBehavior { get; set; }
        public int Position { get; set; }

        public void Move()
        {
            MoveBehavior.Move(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUnit viking = new Viking();

            viking.Move();
            viking.Move();

            viking.MoveBehavior = new Fly();
            viking.Move();

            IUnit dragon = new Dragon();
            dragon.Move();

            Console.WriteLine(viking.Position);
            Console.WriteLine(dragon.Position);
            Console.ReadKey();
        }
    }
}
