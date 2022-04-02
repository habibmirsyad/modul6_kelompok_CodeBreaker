using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302201138
{
    internal class DataMahasiswa1302201138
    {

        public class Personal
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public Address address { get; set; }
            public Cours[] courses { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Cours
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            string file = "jurnal6_1_1302201138.json";
            string strFile = File.ReadAllText(file);
            Personal personal = JsonSerializer.Deserialize<Personal>(strFile);

            Console.WriteLine($"==Personal Data==\n" +
                $"Name\t: {personal.firstName} {personal.lastName}\n" +
                $"Nick\t: {personal.firstName}\n" +
                $"Age\t: {personal.age}\n" +
                $"Gender\t: {personal.gender}");

            Console.WriteLine($"\n==Address==\n" +
                $"Street\t: {personal.address.streetAddress}\n" +
                $"City\t: {personal.address.city}\n" +
                $"State\t: {personal.address.state}");

            Console.WriteLine($"\n==Courses taken==");
            for (int i = 0; i < personal.courses.Length; i++)
            {
                Console.WriteLine($"{personal.courses[i].code} - {personal.courses[i].name}");
            }

        }
    }
}
