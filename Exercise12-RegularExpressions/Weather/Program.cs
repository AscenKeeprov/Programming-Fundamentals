using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, City> weatherForecast = new Dictionary<string, City>();
	    string pattern = @"([A-Z]{2})(\d{1,2}\.\d{1,2})([a-zA-z]+)(?=\|)";
	    string input = Console.ReadLine();
	    while (input.ToUpper() != "END")
	    {
		if (Regex.IsMatch(input, pattern))
		{
		    Match forecast = Regex.Match(input, pattern);
		    City city = new City()
		    {
			Code = forecast.Groups[1].Value,
			AverageTemperature = double.Parse(forecast.Groups[2].Value),
			Weather = forecast.Groups[3].Value
		    };
		    weatherForecast[city.Code] = city;
		}
		input = Console.ReadLine();
	    }
	    foreach (var city in weatherForecast.OrderBy(c => c.Value.AverageTemperature))
		Console.WriteLine($"{city.Key} => " +
		    $"{city.Value.AverageTemperature:F2} => {city.Value.Weather}");
	}
    }

    class City
    {
	public string Code { get; set; }
	public double AverageTemperature { get; set; }
	public string Weather { get; set; }
    }
}