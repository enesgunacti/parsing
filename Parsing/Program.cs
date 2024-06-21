using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Parsing
{
    public class Program
    {
        public static void Main()
        {          
            //JSON PARSING EXAMPLE WITH NEWTONSOFT.JSON

            string jsonString = "{\"Name\":\"John\", \"Age\":30, \"City\":\"New York\"}";          
            Person person = JsonConvert.DeserializeObject<Person>(jsonString);

            
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"City: {person.City}");
        
            //XML PARSING EXAMPLE WITH XMLDOCUMENT
            string xmlString = @"
            <Person>
                <Name>ENES</Name>
                <Age>25</Age>
                <City>TRABZON</City>
            </Person>";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);

            XmlNode nameNode = xmlDoc.SelectSingleNode("/Person/Name");
            XmlNode ageNode = xmlDoc.SelectSingleNode("/Person/Age");
            XmlNode cityNode = xmlDoc.SelectSingleNode("/Person/City");

            Console.WriteLine($"Name: {nameNode.InnerText}");
            Console.WriteLine($"Age: {ageNode.InnerText}");
            Console.WriteLine($"City: {cityNode.InnerText}");

            Console.ReadLine();
        }
    }
}
