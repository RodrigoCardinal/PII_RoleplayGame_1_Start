using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ElfArmorTest
    {
        [Test]
        public void InvalidWeaponEquip()
        {

            Elf elfo = new Elf("elfo");
            LightArmor armaduraliviana = new LightArmor();

            bool firstEquipResult = elfo.AddLightArmor(armaduraliviana);
            bool secondEquipResult = elfo.AddLightArmor(armaduraliviana);
            bool expectedSecondEquipResult = false;
            Assert.AreEqual(expectedSecondEquipResult, secondEquipResult);
        }
    }
}
