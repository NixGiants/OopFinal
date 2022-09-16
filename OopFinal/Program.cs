// See https://aka.ms/new-console-template for more information
using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;
using BussinesLogic.Enums;

IPaymentMethod payment = new GooglePay();
List<IPaymentMethod> list = new List<IPaymentMethod>();
list.Add(payment);
ApplicationUser User = new("Vasya","Vasin", list, "VasyaVasin", "123456",Access.Customer);

ICategory category = new Category("Milk Products");

ICategory category_Tech = new Category("head set");

Product product1 = new("Moloko", "Romol", "15% Milk", null, 40,category,true);

Product product2 = new Product("S128", "Philips", "Very expensive and good head set", null,1500,category_Tech,true);

List<Product> products = new List<Product>();
products.Add(product1);
products.Add(product2);

Basket basket = new(products);

Order order = new(User, basket, payment, null);

Console.WriteLine(order);



