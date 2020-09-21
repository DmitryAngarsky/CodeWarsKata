using System;

namespace PatternCraftDecorator
{
    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarinreDecorator : IMarine
    {
        IMarine marine;

        public MarinreDecorator(IMarine marine)
        {
            this.marine = marine;
        }

        public virtual int Damage { get => marine.Damage; set => marine.Damage = value; }
        public virtual int Armor { get => marine.Armor; set => marine.Armor = value; }
    }

    public class MarineWeaponUpgrade : MarinreDecorator
    {
        private IMarine marine;

        public MarineWeaponUpgrade(IMarine marine) : base(marine)
        {
            this.marine = marine;
        }

        public override int Damage => marine.Damage + 1;
    }

    public class MarineArmorUpgrade : MarinreDecorator 
    {
        private IMarine marine;

        public MarineArmorUpgrade(IMarine marine) : base(marine)
        {
            this.marine = marine;
        }

        public override int Armor => marine.Armor + 1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMarine marine = new Marine(10, 1);

            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            marine = new MarineArmorUpgrade(marine);
            marine = new MarineArmorUpgrade(marine);

            Console.WriteLine(marine.Damage);
            Console.WriteLine(marine.Armor);
            Console.ReadKey();
        }
    }
}
