using System.Text.Json;

namespace com.kpl.modul6.adit
{
    class DataMahasiswa1302204054
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public alamat address { get; set; }
        public matkul[] courses { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal6_1_1302204054.json";

            string jsonString = File.ReadAllText(fileName);
            DataMahasiswa1302204054 jsonData = JsonSerializer.Deserialize<DataMahasiswa1302204054>(jsonString);

            this.firstName = jsonData.firstName;
            this.lastName = jsonData.lastName;
            this.gender = jsonData.gender;
            this.age = jsonData.age;
            this.address = jsonData.address;
            this.courses = jsonData.courses;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("Nama\t\t: " + this.firstName + " " + this.lastName);
            Console.WriteLine("Gender\t\t: " + this.gender);
            Console.WriteLine("Umur\t\t: " + this.age);
            Console.WriteLine("Tinggal di\t: " + this.address.streetAddress + ", "
                + this.address.city + ", " + this.address.state);
            foreach (var item in this.courses)
            {
                Console.WriteLine("Mengikuti \t: " + item.code + "-" + item.name);
            }
        }


    }

    class alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    class matkul
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}