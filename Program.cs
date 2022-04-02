using System;

namespace modul6_kelompok_CodeBreaker
{
    public class main
    {
        public static void Main()
        {
            DataMahasiswa1302204047 mhs1 = new DataMahasiswa1302204047();
            mhs1.ReadJSON();

            TeamMembers1302204047 member1 = new TeamMembers1302204047();
            member1.ReadJSON();
        }
    }
}