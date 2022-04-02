using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_1302201138
{
    internal class GlossaryItem
    {

        public class Gloss
        {
            public Glossary glossary { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public Glossdiv GlossDiv { get; set; }
        }

        public class Glossdiv
        {
            public string title { get; set; }
            public Glosslist GlossList { get; set; }
        }

        public class Glosslist
        {
            public Glossentry GlossEntry { get; set; }
        }

        public class Glossentry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public Glossdef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class Glossdef
        {
            public string para { get; set; }
            public string[] GlossSeeAlso { get; set; }
        }

        public void ReadJSON()
        {
            string file = "jurnal6_3_1302201138.json";
            string strFile = File.ReadAllText(file);
            Gloss rootobject = JsonSerializer.Deserialize<Gloss>(strFile);
            Glossentry glossentry = JsonSerializer.Deserialize<Glossentry>(strFile);

            Console.WriteLine($"ID        : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.ID}");
            Console.WriteLine($"SortAs    : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.SortAs}");
            Console.WriteLine($"GlossTerm : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm}");
            Console.WriteLine($"Acronym   : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.Acronym}");
            Console.WriteLine($"Abbrev    : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.Abbrev}");
            Console.WriteLine($"GlossDef  :");
            for (int i = 1;i <= rootobject.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso.Length; i++)
            {
                Console.WriteLine(i + $". para : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para}\n" +
                $"   GlossSeeAlso : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[i-1]}");
            }
            Console.WriteLine($"GlossSee  : {rootobject.glossary.GlossDiv.GlossList.GlossEntry.GlossSee}");
        }
    }
}
