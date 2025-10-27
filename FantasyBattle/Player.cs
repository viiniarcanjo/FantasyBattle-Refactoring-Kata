using System;
using System.Linq;

namespace FantasyBattle
{
    public class Player(Inventory inventory, Stats stats) : Target
    {
        private Inventory Inventory { get; } = inventory;
        private Stats Stats { get; } = stats;

        public Damage CalculateDamage(Target other)
        {
            int totalDamage = CalculateTotalDamage();
            int soak = CalculateSoak(other, totalDamage);
            return new Damage(Math.Max(0, totalDamage - soak));
        }
        
        // TODO: Implement the GetSoak method for friendly fire.

        private int CalculateTotalDamage()
        {
            int baseDamage = Inventory.CalculateBaseDamage();
            float damageModifier = Stats.Strength * 0.1f + Inventory.CalculateBaseDamageModifier();
            return (int)Math.Round(baseDamage * damageModifier, 0);
        }

        private static int CalculateSoak(Target other, int totalDamage)
        {
            return other.GetSoak();
        }
    }
}