using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var apiKeyObject = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(apiKeyObject).GetValue("apiKey").ToString();
            var city = "Miami";

            //var weatherURL = $"https://api.openweathermap.org/data/2.5forecast?q={city}&appid={apiKey}&units=imperial";
            //var response = client.GetStringAsync(weatherURL).Result;



            //JObject formattedResponse = JObject.Parse(response);
            //var temp = formattedResponse["list"][0]["main"]["temp"];
            //Console.WriteLine(temp);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("enter city name: ");
                var city_name = Console.ReadLine();
                Console.WriteLine();

                var weatherURL = $"https://api.openweathermap.org/data/2.5forecast?q={city}&appid={apiKey}&units=imperial";
                var response = client.GetStringAsync(weatherURL).Result;
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                var temp = JObject.Parse(formattedResponse).GetValue("temp");
                Console.WriteLine($"The current tempatrue is {temp} degrees Fahrenheit");
                AddSpaces(2);
                Console.WriteLine("Would you like to exit?");
                var userInput = Console.ReadLine();
                AddSpaces(2);

                if (userInput.ToLower().Trim() == "yes") 
                { 
                   break;
                }
                

            }


        }

        private static void AddSpaces(int v)
        {
        }
    }
}