using System;

class Program
{
    static void Main()
    {
        double[] sales = { 100, 120, 140, 150, 170 };

        
        int numMonthsToForecast = 3;

      
        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumX2 = 0;

        for (int i = 0; i < sales.Length; i++)
        {
            double x = i + 1; 
            double y = sales[i];
            sumX += x;
            sumY += y;
            sumXY += x * y;
            sumX2 += x * x;
        }

   
        double a = (sales.Length * sumXY - sumX * sumY) / (sales.Length * sumX2 - sumX * sumX);
        double b = (sumY - a * sumX) / sales.Length;

     
        Console.WriteLine("Прогноз объемов продаж на следующие 3 месяца:");
        for (int i = 1; i <= numMonthsToForecast; i++)
        {
            double forecastMonth = sales.Length + i;
            double forecastSales = a * forecastMonth + b;
            Console.WriteLine($"Месяц {forecastMonth}: {forecastSales:F2}");
        }
    }
}
