using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;
using BussinesLogic.Enums;
using System.Runtime.CompilerServices;
using BussinesLogic.Models.Shipments;
using System.Net.Http.Headers;
using System.Collections.ObjectModel;

Console.WriteLine("      Test program for Linq HW:\n ");


ICategory milkProducts = new Category("Milk Products");
ICategory headSets = new Category("Head sets");

List<ICategory> listOfCategories = new List<ICategory>();
listOfCategories.Add(milkProducts);
listOfCategories.Add(headSets);

Product milk = new("Milk", "Romol", "15% Milk", null, 40, milkProducts, false);
Product sourCream = new("Sour cream", "Zakarpatiia", "25% Sour Cream", null, 80, milkProducts, true);
Product butter = new("Butter", "Romol", "85% Butter", null, 120, milkProducts, true);

Product marshallHeadSet = new("Minor 6", "Marshall", "Old is best", null, 5000, headSets, true);
Product xiaomiHeadSet = new("Galaxy s355 Air Buds Pro Minor 3000", "Xiaomi", "Supoer Chinese model better than apple...", null, 3, headSets, false);


ObservableCollection<Product> listOfProducts = new ObservableCollection<Product>();

listOfProducts.Add(milk);
listOfProducts.Add(sourCream);
listOfProducts.Add(butter);
listOfProducts.Add(marshallHeadSet);
listOfProducts.Add(xiaomiHeadSet);

Basket testBasket = new(listOfProducts);

Console.WriteLine("  Test projection method:\n ");

IEnumerable<string> projection = testBasket.ProjectionBasket();
foreach(var item in projection)
{
    Console.WriteLine($"{item}\n");
}

Console.WriteLine("  Test filter (GetAvilableProducts) method:\n ");

IEnumerable<Product> filtProd = testBasket.GetAvilableProducts();
foreach(var item in filtProd)
{
    Console.WriteLine($"{item}\n");
}

Console.WriteLine("    Test sort methods:\n ");
Console.WriteLine("  Test ascending sort method:\n ");

IEnumerable<Product> ascSort = testBasket.OrderByAsc();
foreach (var item in ascSort)
{
    Console.WriteLine($"{item}\n");
}

Console.WriteLine("  Test descending sort method:\n ");

IEnumerable<Product> descSort = testBasket.OrderByDesc();
foreach (var item in descSort)
{
    Console.WriteLine($"{item}\n");
}


