using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;
using BussinesLogic.Enums;
using System.Runtime.CompilerServices;
using BussinesLogic.Models.Shipments;
using System.Net.Http.Headers;

Console.WriteLine("Test Program:\n ");


ICategory milkProducts = new Category("Milk Products");
ICategory headSets = new Category("Head sets");

List<ICategory> listOfCategories = new List<ICategory>();
listOfCategories.Add(milkProducts);
listOfCategories.Add(headSets);

Product milk = new("Milk", "Romol", "15% Milk", null, 40, milkProducts, true);
Product sourCream = new("Sour cream", "Zakarpatiia", "25% Sour Cream", null, 80, milkProducts, true);
Product butter = new Product("Butter", "Romol", "85% Butter", null, 120, milkProducts, true);
Product hollandCheese = new("Holland Cheese", "Zakarpatia", "Perfect cheese from cow milk", null, 350, milkProducts, true);
Product serum = new("Serum", "Zakarpatia", "good serum", null, 30, milkProducts, true);

Product sonyHeadSet = new Product("S128", "Philips", "Very expensive and good head set", null, 1500, headSets, true);
Product samsungHeadSet = new("Buds Pro 2", "Samsung", "New model with cool ANC", null, 8000, headSets, true);
Product appleHeadSet = new("Air Pods Pro 3", "Apple", "Our coolest model ever", null, 13000, headSets, true);
Product marshallHeadSet = new("Minor 6", "Marshall", "Old is best", null, 5000, headSets, true);
Product xiaomiHeadSet = new("Galaxy s355 Air Buds Pro Minor 3000", "Xiaomi", "Supoer Chinese model better than apple...", null, 3, headSets, true);


List<Product> listOfMilkProducts = new List<Product>();
listOfMilkProducts.Add(milk);
listOfMilkProducts.Add(sourCream);
listOfMilkProducts.Add(butter);
listOfMilkProducts.Add(hollandCheese);
listOfMilkProducts.Add(serum);

List<Product> listOfHeadSets = new List<Product>();
listOfHeadSets.Add(sonyHeadSet);
listOfHeadSets.Add(samsungHeadSet);
listOfHeadSets.Add(appleHeadSet);
listOfHeadSets.Add(marshallHeadSet);
listOfHeadSets.Add(xiaomiHeadSet);






