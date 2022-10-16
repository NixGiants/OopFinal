using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;

Console.WriteLine("Hello, World!");

Linq_Panasenko panasenkoTest = new Linq_Panasenko();
panasenkoTest.PrintAllProducts();
Console.WriteLine("Filtration byb brand:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.FiltrByBrand("Romol");




