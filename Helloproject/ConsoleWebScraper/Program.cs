// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

class Program
{
    static async Task Main()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(
            HttpMethod.Get,
            "https://www.timeanddate.com/weather/?sort=1"
        );

        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        string html = await response.Content.ReadAsStringAsync();

        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        // Each city is in a table row
        var rows = doc.DocumentNode.SelectNodes("//table[contains(@class,'zebra')]//tr");

        if (rows == null)
        {
            Console.WriteLine("No data found.");
            return;
        }

        foreach (var row in rows)
        {
            // Capital name (link in first column)
            var cityNode = row.SelectSingleNode(".//td[1]//a");
            if (cityNode == null)
                continue;

            string capital = HtmlEntity.DeEntitize(cityNode.InnerText).Trim();

            // Temperature column (has class 'rbi')
            var tempNode = row.SelectSingleNode(".//td[contains(@class,'rbi')]");
            if (tempNode == null)
                continue;

            string temperature = HtmlEntity.DeEntitize(tempNode.InnerText).Trim();

            Console.WriteLine($"The temperature in {capital} is {temperature}");
        }
    }
}
