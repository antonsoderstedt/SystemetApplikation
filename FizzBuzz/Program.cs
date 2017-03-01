using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unirest_net;
using unirest_net.http;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace SystemetSida
{
    class Program
    {
        static void Main(string[] args)
        {
            var getStr = "https://karlroos-systemet.p.mashape.com/product?&order=ASC&order_by=price";
            HttpResponse<string> response = Unirest.get(getStr)
            .header("X-Mashape-Key", "KlCvBh2xRUmshTOZHDrBJFDe410Pp1b8YU8jsnscTwJ8nGcDqL")
            .header("Accept", "application/json")
            .asJson<string>();
            var json = response.Body;
            var serializer = new JavaScriptSerializer();
            var drinks = serializer.Deserialize<RootObject[]>(json);



            Console.ReadLine();

        }

        public class Country
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Origin
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class RootObject
        {
            public string id { get; set; }
            public string article_id { get; set; }
            public string product_number { get; set; }
            public string name { get; set; }
            public string name_2 { get; set; }
            public string start_date { get; set; }
            public string country_id { get; set; }
            public string origin_id { get; set; }
            public double volume { get; set; }
            public double price { get; set; }
            public double price_per_liter { get; set; }
            public double alcohol { get; set; }
            public double apk { get; set; }
            public string year { get; set; }
            public bool ecological { get; set; }
            public bool koscher { get; set; }
            public object deleted_at { get; set; }
            public List<object> tags { get; set; }
            public Country country { get; set; }
            public Origin origin { get; set; }
        }

    }
}

