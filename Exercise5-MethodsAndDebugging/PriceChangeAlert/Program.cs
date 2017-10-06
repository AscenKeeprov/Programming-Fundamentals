using System;

namespace PriceChangeAlert
{
	class Program
	{
		private static double PriceDifference(double lastPrice, double currentPrice)
		{
			return (currentPrice - lastPrice) / lastPrice;
		}

		private static bool SignificanceCheck(double deltaPrice, double significanceThreshold)
		{
			if (Math.Abs(deltaPrice) >= significanceThreshold) return true;
			return false;
		}

		private static string PriceChangeSummary(double currentPrice, double lastPrice, double deltaPrice, bool isSignificantDelta)
		{
			string changeSummary = "";
			if (deltaPrice == 0) changeSummary = string.Format($"NO CHANGE: {currentPrice}");
			else if (!isSignificantDelta) changeSummary = string.Format($"MINOR CHANGE: {lastPrice} to {currentPrice} ({deltaPrice:P2})");
			else if (isSignificantDelta && (deltaPrice > 0)) changeSummary = string.Format($"PRICE UP: {lastPrice} to {currentPrice} ({deltaPrice:P2})");
			else if (isSignificantDelta && (deltaPrice < 0)) changeSummary = string.Format($"PRICE DOWN: {lastPrice} to {currentPrice} ({deltaPrice:P2})");
			return changeSummary;
		}

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double significanceThreshold = double.Parse(Console.ReadLine());
			double lastPrice = double.Parse(Console.ReadLine());
			for (int i = 2; i <= n; i++)
			{
				double currentPrice = double.Parse(Console.ReadLine());
				double priceDelta = PriceDifference(lastPrice, currentPrice);
				bool isSignificantDelta = SignificanceCheck(priceDelta, significanceThreshold);
				Console.WriteLine(PriceChangeSummary(currentPrice, lastPrice, priceDelta, isSignificantDelta));
				lastPrice = currentPrice;
			}
		}
	}
}