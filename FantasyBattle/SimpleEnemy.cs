using System;
using System.Collections.Generic;
using System.Linq;

namespace FantasyBattle
{
    public class SimpleEnemy : Target
    {
        public virtual IArmor Armor { get; }
        public virtual List<IBuff> Buffs { get; }

        public SimpleEnemy()
        {

        }

        public SimpleEnemy(IArmor armor, List<IBuff> buffs)
        {
            Armor = armor;
            Buffs = buffs;
        }

        public override int GetSoak()
        {
            return (int)Math.Round(
                Armor.DamageSoak *
                (
                    Buffs.Select(x => x.SoakModifier).Sum() + 1
                ), 0
            );
        }
    }

    public interface IBuff
    {
        float SoakModifier { get; }
        float DamageModifier { get; }
    }

    public interface IArmor
    {
        int DamageSoak { get; }
    }
}