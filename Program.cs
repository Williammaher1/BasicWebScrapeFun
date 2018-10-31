
using System;
using System.Linq;


namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=software&geo_location_terms=Sydney%2C+Nd");
            var ArticleTitles = doc.DocumentNode
                .SelectNodes("//a[@class='business-name']").ToList();

            foreach (var items in ArticleTitles)
            {
                Console.WriteLine(items.InnerText);
                Console.ReadLine();
                
            }
            
        }
    }
}
