using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Products.Interface;

namespace TariffComparison.Products.Implementation 
{
    public class PackagedElectricityTariff : IProduct
    {
        // 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh.
        public double CalculationModel(int Consumption)
        {
            double AdditionalCosts = 0;
            int AdditionalConsumption = Consumption - 4000;
            if (AdditionalConsumption > 0)
                AdditionalCosts = AdditionalConsumption * 0.3;
            return 800 + AdditionalCosts;
        }

        public string Name()
        {
            return "Packaged Electricity Tariff";
        }
    }
}
