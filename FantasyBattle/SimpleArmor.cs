namespace FantasyBattle
{
    public class SimpleArmor : IArmor
    {
        public SimpleArmor(int damageSoak)
        {
            DamageSoak = damageSoak;
        }

        public int DamageSoak { get; }
    }
}