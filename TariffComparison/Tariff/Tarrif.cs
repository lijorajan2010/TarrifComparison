using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Products.Interface;

namespace TariffComparison.Tariff
{
    public class Tarrif
    {
        public string TarrifName { get; set; }
        public double AnnualCosts { get; set; }
        public Tarrif(IProduct product, int Consumption)
        {
            this.TarrifName = product.Name();
            this.AnnualCosts = product.CalculationModel(Consumption);
        }
    }
}
