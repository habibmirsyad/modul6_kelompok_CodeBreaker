using System.Text.Json;

namespace modul6_1302201138
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302201138 data = new DataMahasiswa1302201138();
            data.ReadJSON();

            Console.WriteLine("");

            TimMembers1302201138 tim = new TimMembers1302201138();
            tim.ReadJSON();

            Console.WriteLine("");

            GlossaryItem glossaryItem = new GlossaryItem();
            glossaryItem.ReadJSON();
        }
    }
}
