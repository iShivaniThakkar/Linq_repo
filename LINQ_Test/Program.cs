using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<string> CountryListA = new List<string>()
        {

                "balochistan",

                "Cabo Verde",
                "Cambodia",
                "Cameroon",
                "Canada",
                "Chad",
                "Chile",
                "China",
                "Colombia",
                "Comoros",
                "Ghana",
                "Greece",
                "Grenada",
                "Guatemala",
                "Namibia",
                "Nauru",
                "Nepal",
                "Netherlands",
                "New Zealand",
                "Nicaragua",
        };

        IList<string> CountryListB = new List<string>()
        {
                "Afghanistan",
                "Albania",
                "Algeria",
                "Andorra",
                "Angola",
                "Bahrain",
                "Bangladesh",
                "Barbados",
                "Belarus",
                "Belgium",
                "Belize",
                "Benin",
                "Bhutan",
                "Uganda",
                "Ukraine",
                "United Arab Emirates",
                "United Kingdom",
                "United States",
                "Uruguay",
                "Uzbekistan",
                "Vanuatu",
                "Vatican City",
                "Venezuela",
                "Vietnam",
                "Taiwan",
                "Tajikistan",
                "Tanzania",
                "Thailand",
                "Togo",
                "Tonga",
                "Trinidad and Tobago",
                "Tunisia",
        };

        var r = CountryListA.Intersect(CountryListB);


        foreach (var i in r)
        {
            Console.WriteLine(i);
        }
    }
}