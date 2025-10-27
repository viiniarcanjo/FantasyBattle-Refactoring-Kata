using Bogus;

namespace FantasyBattle.Tests.FakerModels;

public sealed class BasicItemFaker : Faker<BasicItem>
{
    public BasicItemFaker()
    {
        CustomInstantiator(f =>
            new BasicItem(
                f.Random.AlphaNumeric(8),
                f.Random.Int(1, 20), 
                f.Random.Float(1.0f, 2.0f)
            )
        );
    }
}