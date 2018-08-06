using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DictionaryOverList
{
    class CountryDetailsUsingDictionary
    {
        public void GetCountryDetailsUsingDictionary()
        {
            Country country1 = new Country() { Name = "INDIA", Code = "IND", Capital = "New Delhi" };
            Country country2 = new Country() { Name = "United States of America", Code = "USA", Capital = "Washington D.C." };
            Country country3 = new Country() { Name = "AUSTRAILA", Code = "AUS", Capital = "Canberra" };
            Country country4 = new Country() { Name = "UNITED KINGDOM", Code = "UK", Capital = "London" };
            Country country5 = new Country() { Name = "CANADA", Code = "CAN", Capital = "Ottawa" };

            Dictionary<string, Country> dictCountry = new Dictionary<string, Country>();
            dictCountry.Add(country1.Code, country1);
            dictCountry.Add(country2.Code, country2);
            dictCountry.Add(country3.Code, country3);
            dictCountry.Add(country4.Code, country4);
            dictCountry.Add(country5.Code, country5);

            Console.WriteLine("Using Dictionaries Cheking the Countries");
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("Enter the Coutry Code: ");
                string CountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictCountry.ContainsKey(CountryCode) ? dictCountry[CountryCode] : null;
                if (resultCountry == null)
                {
                    Console.WriteLine("Enter valid country code..!");
                }
                else
                {
                    Console.WriteLine("Name: {0}, Capital: {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue YES/NO: ");
                    UserChoice = Console.ReadLine().ToUpper();
                }
                while (UserChoice != "NO" && UserChoice != "YES");
            }
            while (UserChoice == "YES");
        }
    }
}
