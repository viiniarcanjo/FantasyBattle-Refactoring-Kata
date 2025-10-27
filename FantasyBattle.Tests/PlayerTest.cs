using System.Collections.Generic;
using System.Text;
using FantasyBattle.Tests.FakerModels;
using Moq;
using Xunit;

namespace FantasyBattle.Tests
{
    public class PlayerTest
    {
        // choose this one if you are familiar with mocks
        [Fact]
        public void DamageCalculationsWithMocks()
        {
            // By applying the Law of Demeter, testing became a lot easier, cause now we only need
            // to mock the methods behavior, instead of the whole chain of properties.
            var inventory = new Mock<Inventory>();
            inventory.Setup(inv => inv.CalculateBaseDamage()).Returns(22);
            inventory.Setup(e => e.CalculateBaseDamageModifier()).Returns(0.4f);
            
            var stats = new Mock<Stats>();
            stats.Setup(s => s.Strength).Returns(1);
            
            var target = new Mock<SimpleEnemy>();
            target.Setup(x => x.GetSoak()).Returns(1);

            var damage = new Player(inventory.Object, stats.Object).CalculateDamage(target.Object);
            
            Assert.Equal(10, damage.Amount);
        }

        // choose this one if you are not familiar with mocks
        [Fact(Skip = "Test is not finished yet")]
        public void DamageCalculations() {
            Inventory inventory = new Inventory(null);
            Stats stats = new Stats(0);
            SimpleEnemy target = new SimpleEnemy(null, null);
            Damage damage = new Player(inventory, stats).CalculateDamage(target);
            Assert.Equal(10, damage.Amount);
        }
    }
}
