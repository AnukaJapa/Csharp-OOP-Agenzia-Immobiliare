// See https://aka.ms/new-console-template for more information
using Csharp_OOP_Agenzia_Immobiliare;
using System.Net.Http.Headers;

Immobile Immobile1 = new Immobile("Via Borso","20144","Milano",23);
Console.WriteLine("Qua c'è descrizione di un immobile");
Console.WriteLine(Immobile1);

Immobile immobile2 = new Box("Via Verdi", "20133", "Roma", 34, 2);
Console.WriteLine("Qua c'è descrizioe di box");
Console.WriteLine(immobile2);

Villa villa1 = new Villa("Via Colombo", "20120", "Verona", 34, 3, 4, 56);
Console.WriteLine("Qua c'è descrizioe di Villa");
Console.WriteLine(villa1.ToString());

Abitazione abitazione1 = new Abitazione("Via Monti", "20333", "Milano", 90, 5, 3);
Console.WriteLine("Qua c'è descrizione di abitazione");
Console.WriteLine(abitazione1.ToString());

