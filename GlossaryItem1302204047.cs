using System.Text.Json;

namespace com.kpl.tp.modul6.nim1302204047
{
	public class GlossaryItem1302204047
	{
		public string glosarry { get; set; }


		public void ReadJSON()
		{
			string fileName = "jurnal6_1_1302204047.json";

			string jsonString = File.ReadAllText(fileName);
			GlossaryItem1302204047 jsonData = JsonSerializer.Deserialize<GlossaryItem1302204047>(jsonString);

			this.glosarry = jsonData.glosarry;

			Console.WriteLine($"Data {this.glosarry}");
		}
	}
}