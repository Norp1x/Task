using LibraryApp;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Metadata;

using (var db = new LibraryContext())
{
    if (db.GetService<IDatabaseCreator>().CanConnect())
    {
        Console.WriteLine("Baza danych już istnieje");
    }
    else 
    {
        Console.WriteLine("Baza danych nie istnieje");
    }
    db.GetService<IDatabaseCreator>().EnsureCreated();
    if (db.GetService<IDatabaseCreator>().CanConnect())
    {
        Console.WriteLine("Baza danych już istnieje");
    }
    else
    {
        Console.WriteLine("Baza danych nie istnieje");
    }
}