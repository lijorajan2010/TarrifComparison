
using System.Globalization;
using TariffComparison.Products.Implementation;
using TariffComparison.Products.Interface;
using TariffComparison.Tariff;


// The comparison should accept the parameter Consumption (kWh/year)
Console.WriteLine("Please enter the annual consumption (kWh/year) \r\n");
var input = Console.ReadLine();

if (int.TryParse(input, out int consumption))
{
    if(consumption > 0)
    {
        NumberFormatInfo? NumberFormatInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Where(x => x.TwoLetterISOLanguageName.Contains("de")).FirstOrDefault()?.NumberFormat;
        string currencySymbolEuro = NumberFormatInfo != null ? NumberFormatInfo.CurrencySymbol : "Euro";

        List <Tarrif> tarrifs = new List<Tarrif>();
        tarrifs.Add(new Tarrif(new BasicElectricityTarrif(), consumption));
        tarrifs.Add(new Tarrif(new PackagedElectricityTariff(), consumption));
        tarrifs = tarrifs.OrderBy(x => x.AnnualCosts).ToList();

        foreach (var item in tarrifs)
        {
            Console.WriteLine($"Tarrif name is {item.TarrifName} and the annual cost is {currencySymbolEuro} {item.AnnualCosts}");
        }
    }
    else
    {
         Console.WriteLine($"The entered number is {consumption} and it should be greater tha zero");
    }
}
else
{
    Console.WriteLine($"{input} is not a number. Please enter a number for comparison and try again");
}


