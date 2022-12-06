// See https://aka.ms/new-console-template for more information
using Csharp_OOP_Agenzia_Immobiliare;
using System.Net.Http.Headers;


Immobile Immobile1 = new Immobile("Via Borso","20144","Milano",23);
Console.WriteLine("Qua c'è descrizione di un immobile");
Console.WriteLine(Immobile1);

Box box1 = new Box("Via Verdi", "20133", "Roma", 34, 2);
Console.WriteLine("Qua c'è descrizioe di box");
Console.WriteLine(box1);

Villa villa1 = new Villa("Via Colombo", "20120", "Verona", 34, 3, 4, 56);
Console.WriteLine("Qua c'è descrizioe di Villa");
Console.WriteLine(villa1.ToString());

Appartamento abitazione1 = new Appartamento("Via Monti", "20333", "Milano", 90, 5, 3);
Console.WriteLine("Qua c'è descrizione di abitazione");
Console.WriteLine(abitazione1.ToString());


List<Immobile> immobiliList = new List<Immobile>()
{
    abitazione1,
    villa1,
    box1,
    Immobile1
};

//void ricerca1(List<Immobile> immobileList, string codice);
//{

//    Immobile immobileTrovato = immobileList.Find(Immobile => Immobile.GetCodice() == codice);
//}