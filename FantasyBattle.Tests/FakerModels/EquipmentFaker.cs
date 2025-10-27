using Bogus;

namespace FantasyBattle.Tests.FakerModels;

public sealed class EquipmentFaker : Faker<Equipment>
{
    public EquipmentFaker()
    {
        CustomInstantiator(f =>
            new Equipment(
                new BasicItemFaker().Generate(),
                new BasicItemFaker().Generate(),
                new BasicItemFaker().Generate(),
                new BasicItemFaker().Generate(),
                new BasicItemFaker().Generate()
            )
        );
    }
}