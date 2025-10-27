using System.Linq;
using Bogus;

namespace FantasyBattle.Tests.FakerModels;

public sealed class SimpleEnemyFaker : Faker<SimpleEnemy>
{
    public SimpleEnemyFaker()
    {
        CustomInstantiator(f =>
            new SimpleEnemy(
                new SimpleArmorFaker().Generate(),
                new BasicBuffFaker().Generate(2).ToList<Buff>()
            )
        );
    }
}