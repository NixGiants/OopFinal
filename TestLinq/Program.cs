﻿using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;

Console.WriteLine("Hello, World!");

Linq_Panasenko panasenkoTest = new Linq_Panasenko();
panasenkoTest.PrintAllProducts();
Console.WriteLine("Filtration by BRAND:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.FiltrByBrand("Romol");
Console.WriteLine("Filtration by NAME:\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
panasenkoTest.FiltrByName("Milk");




