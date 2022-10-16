using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;

Console.WriteLine("Hello, World!");

Linq_Panasenko panasenkoTest = new Linq_Panasenko();
panasenkoTest.PrintAllProducts();
Console.WriteLine();

Console.WriteLine("Filtration by BRAND:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.FiltrByBrand("Romol");
Console.WriteLine();

Console.WriteLine("Filtration by NAME:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.FiltrByName("Milk");
Console.WriteLine();

Console.WriteLine("Sort by PRICE ascending:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.SortByPriceAsc();
Console.WriteLine();

Console.WriteLine("Sort by Name descending:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.SortByNameDesc();
Console.WriteLine();

Console.WriteLine("Projection 1\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.Projection();
Console.WriteLine();

Console.WriteLine("Projection 2\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.OtherProjection();



