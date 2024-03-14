using modul4_1302223118;
using static modul4_1302223118.KodeBuah;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nomor C : \n");
        KodeBuah kodePos = new KodeBuah();
        Console.WriteLine("Kode buah Apel\t\t: " +
        kodePos.GetKodeBuah(NamaBuah.Apel));
        Console.WriteLine("Kode buah Pisang\t: " +
        kodePos.GetKodeBuah(NamaBuah.Pisang));
        Console.WriteLine("Kode buah Paprika\t: " +
        kodePos.GetKodeBuah(NamaBuah.Paprika));

        Console.WriteLine("\n\n\nNomor 5 A-E : \n");
        PosisiKarakterGame door = new PosisiKarakterGame();
        door.DoAction(Action.TombolW);
        door.DoAction(Action.TombolX);
    }
}


