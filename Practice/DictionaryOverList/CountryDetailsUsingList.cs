using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DictionaryOverList
{
    class CountryDetailsUsingList
    {
        public void GetCountryDetailsUsingList()
        {
            Country country1 = new Country() { Name = "INDIA", Code = "IND", Capital = "New Delhi" };
            Country country2 = new Country() { Name = "United States of America", Code = "USA", Capital = "Washington D.C." };
            Country country3 = new Country() { Name = "AUSTRAILA", Code = "AUS", Capital = "Canberra" };
            Country country4 = new Country() { Name = "UNITED KINGDOM", Code = "UK", Capital = "London" };
            Country country5 = new Country() { Name = "CANADA", Code = "CAN", Capital = "Ottawa" };

            List<Country> CountryList = new List<Country>();
            CountryList.Add(country1);
            CountryList.Add(country2);
            CountryList.Add(country3);
            CountryList.Add(country4);
            CountryList.Add(country5);

            Console.WriteLine("Using List Cheking the Countries");
            string UserChoice = string.Empty;
            do
            {
                
                Console.WriteLine("Enter the Coutry Code: ");
                string CountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = CountryList.Find(country => country.Code == CountryCode);
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
