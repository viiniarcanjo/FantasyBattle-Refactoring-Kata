using System;

namespace FantasyBattle
{
    public class Inventory
    {
        public virtual Equipment Equipment { get; }

        public Inventory()
        {

        }
        
        public Inventory(Equipment equipment)
        {
            Equipment = equipment;
        }
        
        public virtual int CalculateBaseDamage() => Equipment.CalculateBaseDamage();
        
        public virtual float CalculateBaseDamageModifier() => Equipment.CalculateBaseDamageModifier();
    }
}