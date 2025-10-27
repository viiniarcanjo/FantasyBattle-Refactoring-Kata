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
        public void DamageCalculationsWithMocks() {
            var leftHand = new Mock<Item>();
            leftHand.Setup(i => i.BaseDamage).Returns(5);
            leftHand.Setup(i => i.DamageModifier).Returns(0.08f);

            var rightHand = new Mock<Item>();
            rightHand.Setup(i => i.BaseDamage).Returns(5);
            rightHand.Setup(i => i.DamageModifier).Returns(0.08f);

            var head = new Mock<Item>();
            head.Setup(i => i.BaseDamage).Returns(4);
            head.Setup(i => i.DamageModifier).Returns(0.08f);

            var feet = new Mock<Item>();
            feet.Setup(i => i.BaseDamage).Returns(4);
            feet.Setup(i => i.DamageModifier).Returns(0.08f);

            var chest = new Mock<Item>();
            chest.Setup(i => i.BaseDamage).Returns(4);
            chest.Setup(i => i.DamageModifier).Returns(0.08f);

            var equipment = new Equipment(
                leftHand.Object,
                rightHand.Object,
                head.Object,
                feet.Object,
                chest.Object);

            var inventory = new Mock<Inventory>();
            inventory.Setup(inv => inv.Equipment).Returns(equipment);

            var stats = new Mock<Stats>();
            stats.Setup(s => s.Strength).Returns(1);

            var armor = new Mock<Armor>();
            armor.Setup(a => a.DamageSoak).Returns(1);
            
            var target = new Mock<SimpleEnemy>();
            target.Setup(x => x.Armor).Returns(armor.Object);
            target.Setup(x => x.Buffs).Returns(new List<Buff>());

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
