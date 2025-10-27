using Bogus;

namespace FantasyBattle.Tests.FakerModels;

public sealed class SimpleArmorFaker : Faker<SimpleArmor>
{
    public SimpleArmorFaker()
    {
        CustomInstantiator(f => new SimpleArmor((int)f.Random.Float(1f, 3f)));
    }
}