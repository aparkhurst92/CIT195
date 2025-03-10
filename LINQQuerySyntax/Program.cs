class FamousPeople
{
    public string Name { get; set; }
    public int? BirthYear { get; set; } = null;
    public int? DeathYear { get; set; } = null;
}

class Program
{
    static void Main()
    {
        IList<FamousPeople> stemPeople = new List<FamousPeople>()
        {
            new FamousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
            new FamousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
            new FamousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
            new FamousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
            new FamousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
            new FamousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
            new FamousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
            new FamousPeople() { Name = "Lydia Villa-Komaroff", BirthYear=1947 },
            new FamousPeople() { Name = "Mae C. Jemison", BirthYear=1956 },
            new FamousPeople() { Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
            new FamousPeople() { Name = "Tim Berners-Lee", BirthYear=1955 },
            new FamousPeople() { Name = "Terence Tao", BirthYear=1975 },
            new FamousPeople() { Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
            new FamousPeople() { Name = "George Washington Carver", DeathYear=1943 },
            new FamousPeople() { Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
            new FamousPeople() { Name = "Bill Gates", BirthYear=1955 }
        };

        var query1 = from p in stemPeople
                     where p.BirthYear > 1900
                     select p;
        Console.WriteLine("People born after 1900:");
        foreach (var person in query1) 
        Console.WriteLine(person.Name);
        Console.WriteLine();

        var query2 = from p in stemPeople
                     where p.Name.Count(c => c == 'l') >= 2
                     select p;
        Console.WriteLine("people who have two lowercase L's in their name:");
        foreach (var person in query2) 
        Console.WriteLine(person.Name);
        Console.WriteLine();

        var query3 = (from p in stemPeople
                      where p.BirthYear > 1950
                      select p).Count();
        Console.WriteLine($"number of people with birthdays after 1950: {query3}\n");

        var query4 = from p in stemPeople
                     where p.BirthYear >= 1920 && p.BirthYear <= 2000
                     select p;
        Console.WriteLine("people with birth years between 1920 and 2000:");
        foreach (var person in query4) 
        Console.WriteLine(person.Name);
        Console.WriteLine($"Total count: {query4.Count()}\n");

        var query5 = from p in stemPeople
                     orderby p.BirthYear
                     select p;
        Console.WriteLine("sort list by BirthYear:");
        foreach (var person in query5) 
        Console.WriteLine($"{person.Name} - {person.BirthYear}");
        Console.WriteLine();

        var query6 = from p in stemPeople
                     where p.DeathYear > 1960 && p.DeathYear < 2015
                     orderby p.Name
                     select p;
        Console.WriteLine("people with a death year after 1960 and before 2015:");
        foreach (var person in query6) 
        Console.WriteLine(person.Name);
        Console.WriteLine();
    }
}

