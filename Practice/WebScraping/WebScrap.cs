using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.WebScraping {
  class WebScrap {
    public static void GetWebData() {
      HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
      HtmlAgilityPack.HtmlDocument doc = web.Load( "https://www.yellowpages.com/search?search_terms=software&geo_location_terms=chennai" );

      var HeaderNames = doc.DocumentNode.SelectNodes( "//a[@class='business-name']" ).ToList();
      foreach ( var item in HeaderNames ) {
        Console.WriteLine(item.InnerText);
      }

      Console.WriteLine("-------------------------------------");
      var services = doc.DocumentNode.SelectNodes( "//p[@class='adr']" ).ToList();
      foreach(var service in services ) {
        Console.WriteLine(service.InnerText);
      }

      Console.WriteLine( "-------------------------------------" );
      var cities = doc.DocumentNode.SelectNodes( "//ul[@class='to-columns'] && a[@href]" ).ToList();
      foreach ( var city in cities ) {
        Console.WriteLine( city.InnerText );
      }
    }
    
  }
}
