using System.Text.Json;

namespace modul6_kelompok_CodeBreaker
{
	public class DataMahasiswa1302204047
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string gender { get; set; }
		public string age { get; set; }
		public string address { get; set; }
		public string courses { get; set; }


		public void ReadJSON()
		{
			string fileName = "jurnal6_1_1302204047.json";

			string jsonString = File.ReadAllText(fileName);
			DataMahasiswa1302204047 jsonData = JsonSerializer.Deserialize<DataMahasiswa1302204047>(jsonString);

			this.firstname = jsonData.firstname;
			this.lastname = jsonData.lastname;
			this.gender = jsonData.gender;
			this.age = jsonData.age;
			this.address = jsonData.address;
			this.courses = jsonData.courses;

			Console.WriteLine($"Nama {this.firstname} {this.lastname} jenis kelamin {this.age} dengan umur {this.age} alamat {this.address} {this.courses}");
		}
	}
}