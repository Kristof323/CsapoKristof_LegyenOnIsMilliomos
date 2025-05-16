public class Jatek
{
    private Kerdesek kerdesek;
    private int aktualisSzint = 1;
    private int nyertOsszeg = 0;
    private Dictionary<string, bool> segitsegek = new Dictionary<string, bool>
    {
        {"kozonseg", true},
        {"felezo", true},
        {"telefon", true}
    };


    public Jatek(Kerdesek kerdesek)
    {
        this.kerdesek = kerdesek;
    }

    public void Indit()
    {
        aktualisSzint = 1;
        nyertOsszeg = 0;
        hasznaltKerdesek.Clear();
        segitsegek["kozonseg"] = true;
        segitsegek["felezo"] = true;
        segitsegek["telefon"] = true;



    private void HasznalSegitseg(string tipus, Kerdes kerdes)
    {
        switch (tipus)
        {
            case "felezo":

                Console.WriteLine("Felező után ezek maradtak:");
                foreach (var betu in new[] { "A", "B", "C", "D" })
                {
                    if (!torlendo.Contains(betu))
                    {
                        int index = Array.IndexOf(new[] { "A", "B", "C", "D" }, betu);
                        Console.WriteLine($"{betu}: {kerdes.Valaszok[index]}");
                    }
                }
                break;

            case "kozonseg":
                Console.WriteLine($"A közönség szerint a helyes válasz: {kerdes.HelyesValasz} (80%)");
                break;

            case "telefon":
                Console.WriteLine($"A telefonos barát szerint a helyes válasz: {kerdes.HelyesValasz}");
                break;
        }

        segitsegek[tipus] = false;
    }
}
