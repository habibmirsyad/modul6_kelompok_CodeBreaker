using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_codebreaker
{
    public class DataMahasiswa_1302204050
    {
        public class Deserialization.cs
        {
            public string member { get; set; }

            public void ReadJSON()
            {

                string fileName = "Modul6_2_1302204050.json";

                string jsonString = File.ReadAllText(fileName);
                TeamMembers1302204050 jsonData = JsonSerializer.Deserialize<TeamMembers1302204050>(jsonString);

                this.member = jsonData.member;

                Console.WriteLine($"Nama + " + this.firstname this.lastname + "gender" + this.gender + "umur" + this.age + "nim" + this.age);
            }
        }

{
  "members" : [
   {
   "firstName": "Aniko",
   "lastName": "Rochman",
   "gender": "male",
   "age": 21,
   "nim": "1302204050"
   },
    {
      "firstName": "Habib",
      "lastName": "Muhammad Irsyad",
      "gender": "male",
      "age": 20,
      "nim": "1302201138"
    },
    {
       "firstName": "Muhammad Fiqril",
   "lastName": "Hakim",
   "gender": "male",
   "age": 19 ,
   {
   {
      "firstName": "Farhan Hisyam",
      "lastName": "karim",
      "gender": "male",
      "age": 19,
      "nim": "1302200067"
    }
    
      "firstName": "Anugrah Saputra",
      "lastName": "Aras",
      "gender": "male",
      "age": 20,
      "nim": "1302204047"
    },
   ]
}
