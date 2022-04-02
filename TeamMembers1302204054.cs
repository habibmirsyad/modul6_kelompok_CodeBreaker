using System.Text.Json;

namespace com.kpl.modul6.adit
{
    class TeamMembers1302204054
    {
        public TeamMember[] members { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal6_2_1302204054.json";

            string jsonString = File.ReadAllText(fileName);
            TeamMembers1302204054 jsonData = JsonSerializer.Deserialize<TeamMembers1302204054>(jsonString);

            this.members = jsonData.members;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("Team member list:");
            foreach (var team in members)
            {
                team.info();
            }
        }
    }

    class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public void info()
        {
            Console.WriteLine(this.nim + " " + this.firstName + " " +this.lastName +" ("
                + this.age + " " + this.gender + ")");
        }
    }
}

