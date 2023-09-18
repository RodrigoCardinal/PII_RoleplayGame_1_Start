using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfEquipmentTest
    {
        [Test]
        public void InvalidWeaponEquip()
        {

            Dwarf enano = new Dwarf("enano");
            Axe hacha = new Axe();

            bool firstEquipResult = enano.AddAxe(hacha);
            bool secondEquipResult = enano.AddAxe(hacha);
            bool expectedSecondEquipResult = false;
            Assert.AreEqual(expectedSecondEquipResult, secondEquipResult);
        }
    }
}
