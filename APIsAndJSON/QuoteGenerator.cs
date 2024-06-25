using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
         public static void KanyeQuote()
         {

            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"---------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------------");
            
            Console.WriteLine($"---------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------------");
            
            Console.WriteLine($"---------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------------");
            
            Console.WriteLine($"---------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------------");
            
            Console.WriteLine($"---------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------------");
         }

        public static void RonQuote() 
        {
            var client = new HttpClient();

            var RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var RonResponse = client.GetStringAsync(RonURL).Result;

            var RonQuote = JArray.Parse(RonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"-----------------");
            Console.WriteLine($"Ron: '{RonQuote}'");
            Console.WriteLine($"-----------------");

            Console.WriteLine($"-----------------");
            Console.WriteLine($"Ron: '{RonQuote}'");
            Console.WriteLine($"-----------------");
            
            Console.WriteLine($"-----------------");
            Console.WriteLine($"Ron: '{RonQuote}'");
            Console.WriteLine($"-----------------"); 
            
            Console.WriteLine($"-----------------");
            Console.WriteLine($"Ron: '{RonQuote}'");
            Console.WriteLine($"-----------------");
            
            Console.WriteLine($"-----------------");
            Console.WriteLine($"Ron: '{RonQuote}'");
            Console.WriteLine($"-----------------");
        }
    }
}
