using System;

namespace PatternCraftState
{
    public interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }

    public interface IUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }

    public class SiegeState : IUnitState
    {
        public SiegeState()
        {
            CanMove = false;
            Damage = 20;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class TankState : IUnitState
    {
        public TankState()
        {
            CanMove = true;
            Damage = 5;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class Tank : IUnit
    {
        public Tank()
        {
            State = new TankState();
        }

        public IUnitState State { get; set; }

        public bool CanMove { get => State.CanMove; }
        public int Damage { get => State.Damage; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUnit tank = new Tank();
            tank.State = new SiegeState();

            Console.WriteLine($"Tank damage: {tank.Damage}, can move: {tank.CanMove}");
            Console.ReadKey();
        }
    }
}
