using TariffComparison.Products.Implementation;
using TariffComparison.Tariff;

namespace TariffComparison.Test
{
    [TestClass]
    public class UnitTestTarrif
    {
        
        [TestMethod]
        public void BasicElectricityTarrif1()
        {
            Tarrif tarrif = new Tarrif(new BasicElectricityTarrif(), 3500);
            Assert.AreEqual(830, tarrif.AnnualCosts);
        }
        [TestMethod]
        public void BasicElectricityTarrif2()
        {
            Tarrif tarrif = new Tarrif(new BasicElectricityTarrif(), 4500);
            Assert.AreEqual(1050, tarrif.AnnualCosts);
        }
        [TestMethod]
        public void BasicElectricityTarrif3()
        {
            Tarrif tarrif = new Tarrif(new BasicElectricityTarrif(), 6000);
            Assert.AreEqual(1380, tarrif.AnnualCosts);
        }
        [TestMethod]
        public void PackagedElectricityTarrif1()
        {
            Tarrif tarrif = new Tarrif(new PackagedElectricityTariff(), 3500);
            Assert.AreEqual(800, tarrif.AnnualCosts);
        }
        [TestMethod]
        public void PackagedElectricityTarrif2()
        {
            Tarrif tarrif = new Tarrif(new PackagedElectricityTariff(), 4500);
            Assert.AreEqual(950, tarrif.AnnualCosts);
        }
        [TestMethod]
        public void PackagedElectricityTarrif3()
        {
            Tarrif tarrif = new Tarrif(new PackagedElectricityTariff(), 6000);
            Assert.AreEqual(1400, tarrif.AnnualCosts);
        }

    }
}