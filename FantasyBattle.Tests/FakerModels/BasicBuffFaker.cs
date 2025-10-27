using Bogus;

namespace FantasyBattle.Tests.FakerModels;

public sealed class BasicBuffFaker : Faker<BasicBuff>
{
    public BasicBuffFaker()
    {
        CustomInstantiator(f =>
            new BasicBuff(
                f.Random.Float(1f, 3f),
                f.Random.Float(1f, 3f)
                )
        );
    }
}