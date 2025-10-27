namespace FantasyBattle
{
    public class BasicBuff : IBuff
    {
        public BasicBuff(float soakModifier, float damageModifier)
        {
            SoakModifier = soakModifier;
            DamageModifier = damageModifier;
        }

        public float SoakModifier { get; }
        public float DamageModifier { get; }
    }
}