using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparison.Products.Interface
{
    public interface IProduct
    {
        string Name();
        double CalculationModel(int Consumption);
    }
}
