using com.kpl.modul6.adit;

class main
{
    public static void Main()
    {
        DataMahasiswa1302204054 mhsA1 = new DataMahasiswa1302204054();
        mhsA1.ReadJSON();
        Console.WriteLine();

        TeamMembers1302204054 mhsA2 = new TeamMembers1302204054();
        mhsA2.ReadJSON();
        Console.WriteLine();

        GlossaryItem1302204054 mhsA3 = new GlossaryItem1302204054();
        mhsA3.ReadJSON();
    }
}