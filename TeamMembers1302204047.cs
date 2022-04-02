using System.Text.Json;

namespace modul6_kelompok_CodeBreaker
{
	public class TeamMembers1302204047
	{
		public string member { get; set; }



		public void ReadJSON()
		{
			
			string fileName = "jurnal6_2_1302204047.json";

			string jsonString = File.ReadAllText(fileName);
			TeamMembers1302204047 jsonData = JsonSerializer.Deserialize<TeamMembers1302204047>(jsonString);

			this.member = jsonData.member;
			
			Console.WriteLine($"Nama + " + this.firstname this.lastname + "gender" + this.gender + "umur" + this.age + "nim" + this.age);
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
