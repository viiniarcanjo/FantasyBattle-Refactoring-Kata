namespace FantasyBattle
{
    public class Equipment
    {
        // TODO add a ring item that may be equipped
        //  that may also add damage modifier
        public IItem LeftHand { get; }
        public IItem RightHand { get; }
        public IItem Head { get; }
        public IItem Feet { get; }
        public IItem Chest { get; }

        public Equipment(IItem leftHand, IItem rightHand, IItem head, IItem feet, IItem chest)
        {
            LeftHand = leftHand;
            RightHand = rightHand;
            Head = head;
            Feet = feet;
            Chest = chest;
        }

        public int CalculateBaseDamage()
        {
            return
                LeftHand.BaseDamage +
                RightHand.BaseDamage +
                Head.BaseDamage +
                Feet.BaseDamage +
                Chest.BaseDamage;
        }
        
        public float CalculateBaseDamageModifier()
        {
            return
                LeftHand.DamageModifier +
                RightHand.DamageModifier +
                Head.DamageModifier +
                Feet.DamageModifier +
                Chest.DamageModifier;
        }
    }
}