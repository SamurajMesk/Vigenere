using System;

class Kodavimas
{
    //funkcija kuri sulygina norima teksta su raktiniu tekstu pagal raidziu kieki
    static string generuotiRakta(string tekstas, string raktas)
    {
        int x = tekstas.Length;
        for (int i = 0; ; i++)
        {
            if (x == i) i = 0;
            if (raktas.Length == tekstas.Length) break;
            raktas += (raktas[i]);
            //Console.WriteLine(raktas);
        }
        return raktas;
    }
    //funkcija sugeneruoja uzkoduota teksta rakto pagalba
    static string sifravimoTekstas(string tekstas, string raktas)
    {
        String uzsifruotas_tekstas = "";
        for (int i = 0; i < tekstas.Length; i++)
        {
            //konvertavimo diapazonas 32-126
            int x = (tekstas[i] + raktas[i]) % 126;
            //Console.WriteLine("Kodavimas");
            //Console.WriteLine("x "+x);
            //konvertavimas i ASCII
            uzsifruotas_tekstas += (char)(x);
            //Console.WriteLine(uzsifruotas_tekstas);
        }
        return uzsifruotas_tekstas;
    }
    //funkcija atkoduojanti uzkoduota teksta ir isveda originalu teksta
    static string originalusTekstas(string uzsifruotas_tekstas, string raktas)
    {
        string originalus_tekstas = "";
        for (int i = 0; i < uzsifruotas_tekstas.Length && i < raktas.Length; i++)
        {
            //konvertavimo diapazonas 0-25
            int x = (uzsifruotas_tekstas[i] - raktas[i] + 126) % 126;
            //Console.WriteLine("DeKodavimas");
            //Console.WriteLine(x);
            //konvertavimas i ASCII
            originalus_tekstas += (char)(x);
            //Console.WriteLine(originalus_tekstas);
        }
        return originalus_tekstas;
    }


    public static void Main(String[] args)
    {

        Console.WriteLine("Iveskite norima uzsifruoti teksta : ");
 
        string tekstas = Console.ReadLine();
        Console.WriteLine("Iveskite raktini zodi : ");
        string raktinis_zodis = Console.ReadLine();

        string raktas = generuotiRakta(tekstas, raktinis_zodis);
        string koduotas_tekstas = sifravimoTekstas(tekstas, raktas);

        Console.WriteLine("Raktas yra : " + raktinis_zodis + "\n");
        Console.WriteLine("Uzkoduotas tekstas yra : " + koduotas_tekstas + "\n");
        Console.WriteLine("Atkoduotas tekstas yra : " + originalusTekstas(koduotas_tekstas, raktas) + "\n");
        

    }
}

