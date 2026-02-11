// See https://aka.ms/new-console-template for more information
using InterfacesAndLists.Investment;
using System.Collections;

Console.WriteLine("My investments: ");

House h1 = new House("Beddingen 9", 30, 50, "yes", "small house");
House h2 = new House("Granbakken 7", 100, 100, "yes", "Old");

Boat b1 = new Boat(20, 60, "yes", "new", 2010);
Boat b2 = new Boat(40, 80, "yes", "brand new", 2021);

ArrayList investItems = new ArrayList() { h1, h2, b1, b2};


foreach (Object investItem in investItems)
{
    if(investItem is House)
    {
        Console.WriteLine(((House)investItem).InvestSummary());

    }else if(investItem is Boat aBoat)
    {
        Console.WriteLine(aBoat.InvestSummary());
    }
}
