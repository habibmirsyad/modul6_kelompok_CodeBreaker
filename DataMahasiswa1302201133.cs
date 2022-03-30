using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_CodeBreaker
{
    public class DataMahasiswa1302201133
    {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

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



        public static DataMahasiswa1302201133 fromJson(FileStream json)
        {
            var student = JsonSerializer.Deserialize<DataMahasiswa1302201133>(json);
            return student;

        }
    }
}
