using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ElfTest
    {
        [Test]
        public void ElfAttackCharacter_ReduceCharacterHealth()
        {
            Elf elfo = new Elf("elfo");
            Elf targetElf = new Elf("targetElf");

            elfo.AttackCharacter(targetElf);

            Assert.AreEqual(90, targetElf.Health);
        }

        [Test]
        public void ElfAddAttackItem_IncreaseElfAttack()
        {
            Elf elfo = new Elf("elfo");
            Sword sword = new Sword();

            // Act
            elfo.AddAttackItem(sword);

            Assert.AreEqual(20, elfo.Attack);
        }

        [Test]
        public void ElfRemoveAttackItem_DecreaseElfAttack()
        {
            Elf elfo = new Elf("elfo");
            Sword sword = new Sword();
            elfo.AddAttackItem(sword);

            elfo.RemoveAttackItem(sword);

            Assert.AreEqual(10, elfo.Attack);
        }

        [Test]
        public void ElfAddDefensiveItem_IncreaseElfHealth()
        {
            Elf elfo = new Elf("elfo");
            LightArmor armor = new LightArmor();

            elfo.AddDefensiveItem(armor);

            Assert.AreEqual(110, elfo.Health);
        }

        [Test]
        public void ElfRemoveDefensiveItem_DecreaseElfHealth()
        {
            Elf elfo = new Elf("elfo");
            LightArmor armor = new LightArmor();
            elfo.AddDefensiveItem(armor);

            elfo.RemoveDefensiveItem(armor);

            Assert.AreEqual(100, elfo.Health);
        }

        [Test]
        public void ElfHeal_IncreaseElfHealth()
        {
            Elf elfo = new Elf("elfo");
            Elf injuredElf = new Elf("injuredElf");
            injuredElf.Health = 90;

            elfo.Heal(injuredElf);

            Assert.AreEqual(100, injuredElf.Health);
        }
    }
}
