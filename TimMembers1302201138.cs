using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_1302201138
{
    internal class TimMembers1302201138
    {

        public class Members
        {
            public Member[] members { get; set; }
        }

        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public void ReadJSON()
        {
            string file = "jurnal6_2_1302201138.json";
            string strFile = File.ReadAllText(file);
            Members member = JsonSerializer.Deserialize<Members>(strFile);

            Console.WriteLine("Team member list:");
            for (int i = 0; i < member.members.Length; i++)
            {
                Console.WriteLine($"{member.members[i].nim} {member.members[i].lastName} ({member.members[i].age} {member.members[i].gender})");
            }
        }
    }
}
