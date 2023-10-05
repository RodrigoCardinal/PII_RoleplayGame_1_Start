using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTest
    {
        [Test]
        public void DwarfAttackCharacter_ReduceCharacterHealth()
        {
            Dwarf dwarf = new Dwarf("enano");
            Dwarf targetDwarf = new Dwarf("targetDwarf");

            dwarf.AttackCharacter(targetDwarf);

            Assert.AreEqual(150, targetDwarf.Health);
        }

        [Test]
        public void DwarfAddAttackItem_IncreaseDwarfAttack()
        {
            Dwarf dwarf = new Dwarf("enano");
            Sword sword = new Sword();

            // Act
            dwarf.AddAttackItem(sword);

            Assert.AreEqual(35, dwarf.Attack);
        }

        [Test]
        public void DwarfRemoveAttackItem_DecreaseDwarfAttack()
        {
            Dwarf dwarf = new Dwarf("enano");
            Sword sword = new Sword();
            dwarf.AddAttackItem(sword);

            dwarf.RemoveAttackItem(sword);

            Assert.AreEqual(25, dwarf.Attack);
        }

        [Test]
        public void DwarfAddDefensiveItem_IncreaseDwarfHealth()
        {
            Dwarf dwarf = new Dwarf("enano");
            LightArmor armor = new LightArmor();

            dwarf.AddDefensiveItem(armor);

            Assert.AreEqual(185, dwarf.Health);
        }

        [Test]
        public void DwarfRemoveDefensiveItem_DecreaseDwarfHealth()
        {
            Dwarf dwarf = new Dwarf("enano");
            LightArmor armor = new LightArmor();
            dwarf.AddDefensiveItem(armor);

            dwarf.RemoveDefensiveItem(armor);

            Assert.AreEqual(175, dwarf.Health);
        }

        [Test]
        public void DwarfHeal_IncreaseDwarfHealth()
        {
            Dwarf dwarf = new Dwarf("enano");
            Dwarf injuredDwarf = new Dwarf("injuredDwarf");
            injuredDwarf.Health = 160;

            dwarf.Heal(injuredDwarf);

            Assert.AreEqual(170, injuredDwarf.Health);
        }
    }
}
