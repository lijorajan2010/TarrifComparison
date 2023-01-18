using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Products.Interface;

namespace TariffComparison.Products.Implementation
{
    public class BasicElectricityTarrif : IProduct
    {
       // Base cost per year 60€ + Consumption costs 22 cent/kWh.
        public double CalculationModel(int Consumption)
        {
            int CostPerMonth = 5;
            Consumption = Consumption > 0 ? Consumption : 0;
            double BaseYearlyCost = CostPerMonth * 12;
            double ConsumptionCost = Consumption * 0.22;
            return BaseYearlyCost + ConsumptionCost;
        }

        public string Name()
        {
            return "Basic Electricity Tariff";
        }
    }
}
