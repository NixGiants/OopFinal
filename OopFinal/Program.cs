﻿// See https://aka.ms/new-console-template for more information
using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;
using BussinesLogic.Enums;

Console.WriteLine("Test Program:\n ");


ICategory milkProducts = new Category("Milk Products");
ICategory headSets = new Category("Head sets");

Product milk = new("Milk", "Romol", "15% Milk", null, 40, milkProducts, true);
Product sourCream = new("Sour cream", "Zakarpatiia", "25% Sour Cream", null, 80,milkProducts,true);
Product butter = new Product("Butter", "Romol", "85% Butter", null, 120, milkProducts, true);
Product hollandCheese = new("Holland Cheese", "Zakarpatia", "Perfect cheese from cow milk", null, 350, milkProducts,true);
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


IPaymentMethod googlePay = new GooglePay();
IPaymentMethod privatBank = new PrivatBankPay();
List<IPaymentMethod> listOfPaymentMethods = new List<IPaymentMethod>();

Console.WriteLine("Hello! We are Happy to see you in E-Shop!\n\n");
int usingAccessChoice = -1;
do
{ 
    Console.WriteLine("If you want to enter as:\n1) User -- press 1\n2) Have an admin account -- press 2\n0) For Exit -- press 0");

    try
    {
        usingAccessChoice = Convert.ToInt32(Console.ReadLine());
        switch (usingAccessChoice)
        {
            case 1:
                Console.WriteLine("You are User");
                break;
            case 2:
                Console.WriteLine("You are Admin");
                break;

            case 3:
                Console.WriteLine("You choose exit");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Invalid Choice try one more time");
    }

} while (usingAccessChoice != 0);

