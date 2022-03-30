using System;

namespace modul6_kelompok_CodeBreaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\pc\source\repos\tpmodul7_1302201133\modul6_kelompok_CodeBreaker\bin\Debug\net6.0\jurnal6_1_1302201133.json";
            using FileStream json = File.OpenRead(path);
            var student = DataMahasiswa1302201133.fromJson(json);

            Console.WriteLine(student.firstName);
            Console.WriteLine(student.lastName);
            Console.WriteLine(student.gender);
            Console.WriteLine(student.age);
            
        }
    }
}