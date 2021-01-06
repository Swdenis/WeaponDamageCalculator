using System;
namespace WeaponDamageCalculator
{
    class WeaponDamage
    {
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

    
        public int Damage { get; protected set; }

        private bool magic;

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }


        private bool flaming;

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private int roll;

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        protected virtual void CalculateDamage()
        {
            /* the subclass overrides this*/
        }

    }
}
