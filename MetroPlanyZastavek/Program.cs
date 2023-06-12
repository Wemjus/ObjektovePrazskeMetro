while (true)
{
    string[] linkaA =
    {"Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Bořislavka", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská", "Můstek", "Muzeum",
     "Náměstí Míru", "Jiřího z Poděbrad", "Flora", "Želivského", "Strašnická","Skalka","Depo Hostivař"};
    string[] linkaB =
        {"Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské Nádraží", "Anděl", "Karlovo náměstí",
     "Národní třída", "Můstek", "Náměstí Republiky", "FLorenc", "Křižíkova", "Invalidova", "Palmovka", "Českomoravská", "Vysočanská", "Kolbenova",
     "Hloubětín", "Rajská zahrada", "Černý Most"};
    string[] linkaC =
        {"Letňany", "Prosek", "Sřížkov", "Ládví", "Kobylisy", "nádraží Holešovice",
     "Vltavská", "Florenc", "hlavní nádraží"," muzeum", "I.P. Pavlova", "Vyšehrad",
     "Pražského povstání", "Pankrác", "Budějovická", "Kačerov – Depo", "Kačerov",
     "Roztyly", "Chodov", "Opatov", "Háje"};
    string[] linkaD =
        {"Námestí Míru", "Námestí Bří Synků", "Pankrác", "Olbrachtova",
     "Nádraží Krč", "Nemocnice Krč", "Nové Dvory", "Libuš", "Písnice", "Depo Písnice"};

    Console.WriteLine("Vyber si linku, kterou chceš zobrazit :)\n1. Linka A\n2. Linka B\n3. Linka C\n4. Linka D");
    string vyber = Console.ReadLine();
    if (vyber == "1")
    {
        foreach (var vybranaLinka in linkaA)
        {
            Console.WriteLine(vybranaLinka);
        }
    }
    if (vyber == "2")
    {
        foreach (var vybranaLinka in linkaB)
        {
            Console.WriteLine(vybranaLinka);
        }
    }
    if (vyber == "3")
    {
        foreach (var vybranaLinka in linkaC)
        {
            Console.WriteLine(vybranaLinka);
        }
    }
    if (vyber == "4")
    {
        foreach (var vybranaLinka in linkaD)
        {
            Console.WriteLine(vybranaLinka);
        }
    }
    Console.ReadKey();
    Console.Clear();
}