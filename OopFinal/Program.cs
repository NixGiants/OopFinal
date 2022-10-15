// See https://aka.ms/new-console-template for more information
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


IPaymentMethod googlePay = new GooglePay();
IPaymentMethod privatBank = new PrivatBankPay();
List<IPaymentMethod> listOfPaymentMethods = new List<IPaymentMethod>();

ApplicationUser Customer = new("Vasya", "Vasiliev", listOfPaymentMethods, "Vasya", "12345", Access.Customer);
ApplicationUser Admin = new ApplicationUser("Gerakl", "Greece", listOfPaymentMethods, "admin", "admin", Access.Admin);
List<ApplicationUser> RegisteredUsers = new List<ApplicationUser> { Customer, Admin };

//Console.WriteLine("Hello! We are Happy to see you in E-Shop!\n\n");
//int enteringChoice = -1;
//do
//{
//    Console.WriteLine("\n\nIf you want to\n1) Enter application -- 1\n0) Exit from application -- press 0");

//    enteringChoice = Convert.ToInt32(Console.ReadLine());
//    switch (enteringChoice)
//    {
//        case 0:
//            Exit();
//            break;
//        case 1:
//            ApplicationUser? currentUser = null;
//            int AuthorizationChoice = -1;
//            do
//            {
//                Console.WriteLine("Enter Login or Enter 0 if you are new user");
//                string? Login = Console.ReadLine();
//                switch (Login)
//                {
//                    case "0":
//                        Console.WriteLine("Enter First Name: ");
//                        string FirstName = Console.ReadLine()!;
//                        Console.WriteLine("Enter Last Name");
//                        string LastName = Console.ReadLine()!;
//                        Console.WriteLine("Enter login: ");
//                        string login = Console.ReadLine()!;
//                        Console.WriteLine("Enter Password");
//                        string password = Console.ReadLine()!;

//                        currentUser = new ApplicationUser(FirstName, LastName, null, login, password, Access.Customer);
//                        Console.WriteLine($"Hello {currentUser.FirstName} {currentUser.LastName}");
//                        AuthorizationChoice = 0;
//                        break;

//                    default:
//                        Console.WriteLine("Enter Password :");
//                        string? Password = Console.ReadLine();
//                        foreach (ApplicationUser appUser in RegisteredUsers)
//                        {
//                            if (appUser.CheckIsRegistered(Login!, Password!))
//                            {
//                                currentUser = appUser;
//                                AuthorizationChoice = 0;
//                            }
//                        }
//                        if (currentUser == null)
//                        {
//                            Console.WriteLine("Sorry, You are not registered yet");
//                            Console.WriteLine("If you want try one more time\tpress 1\nFor Exit\tPress 0");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Hello {currentUser.FirstName} {currentUser.LastName}");
//                        }
//                        break;
//                }
//            } while (AuthorizationChoice != 0);
//            switch (currentUser!.Access)
//            {
//                case Access.Customer:
//                    Basket currentBasket = new Basket();
//                    int categoryIndex = 0;
//                    do
//                    {
//                        Console.WriteLine("Choose:\n1) Look at milk products\n2) look at Head Sets\n3)Pay For Order\n0) to Exit -- 0");
//                        categoryIndex = Convert.ToInt32(Console.ReadLine());
//                        int counter = 0;
//                        switch (categoryIndex)
//                        {
//                            case 0:
//                                Exit();
//                                break;

//                            case 1:
//                                foreach (Product pr in listOfMilkProducts)
//                                {
//                                    counter++;
//                                    Console.WriteLine($"\n{counter}) {pr}");
//                                }
//                                counter = 0;
//                                int productNumber = 0;
//                                do
//                                {
//                                    Console.WriteLine("For add product to cart press number of this product\npress 0 to exit");
//                                    productNumber = Convert.ToInt32(Console.ReadLine());
//                                    if (productNumber == 0) { continue; }
//                                    Product product = listOfMilkProducts[productNumber - 1];
//                                    currentBasket.AddProduct(product);
//                                } while (productNumber != 0);
//                                break;

//                            case 2:
//                                foreach (Product pr in listOfHeadSets)
//                                {
//                                    counter++;
//                                    Console.WriteLine($"\n{counter}) {pr}");
//                                }
//                                counter = 0;
//                                int productNumber1 = 0;
//                                do
//                                {
//                                    Console.WriteLine("For add product to cart press number of this product\npress 0 to exit");
//                                    productNumber1 = Convert.ToInt32(Console.ReadLine());
//                                    if(productNumber1 == 0) { continue; }
//                                    Product product = listOfHeadSets[productNumber1 - 1];
//                                    currentBasket.AddProduct(product);
//                                } while (productNumber1 != 0);
//                                break;
//                            case 3:
//                                int indexOfPaymentMethod = 0;
//                                IPaymentMethod? paymentMethod = null;
//                                do
//                                {
//                                    Console.WriteLine("Choose Method for payment:\n1) Google Pay\n2) Private Bank");
//                                    indexOfPaymentMethod = Convert.ToInt32(Console.ReadLine());
//                                    switch (indexOfPaymentMethod)
//                                    {
//                                        case 1:
//                                            paymentMethod = new GooglePay();
//                                            break;
//                                        case 2:
//                                            paymentMethod = new PrivatBankPay();
//                                            break;
//                                        default:
//                                            Console.WriteLine("Wrong method");
//                                            break;
//                                    }
//                                } while (paymentMethod == null);
//                                int indexOfShipment = 0;
//                                IShipmentMethod? shipmentMethod = null;
//                                do
//                                {
//                                    Console.WriteLine("Choose method for Ship:\n1)Curier\n2) Self Pick up");
//                                    indexOfShipment = Convert.ToInt32(Console.ReadLine());
//                                    switch (indexOfShipment)
//                                    {
//                                        case 1:
//                                            shipmentMethod = new CurierShipment();
//                                            break;
//                                        case 2:
//                                            shipmentMethod = new SelfPickupShipment();
//                                            break;
//                                        default:
//                                            Console.WriteLine("Wrong method");
//                                            break;
//                                    }

//                                } while (shipmentMethod == null);

//                                Order currentOrder = new Order(currentUser, currentBasket, paymentMethod, shipmentMethod);
//                                currentOrder.PayForOrder();
//                                Console.WriteLine(currentOrder);
//                                categoryIndex = 0;
//                                break;
//                        }
//                    } while (categoryIndex != 0);
//                    break;
//                case Access.Admin:
//                    int adminChoice = 0;
//                    do
//                    {
//                        Console.WriteLine("For\n1)add new category pres 1;\n2)add new product press 2\n0) for Exit");
//                        adminChoice = Convert.ToInt32(Console.ReadLine());
//                        switch (adminChoice)
//                        {
//                            case 1:
//                                Console.WriteLine("Enter Name of Categorie");
//                                string categoryName = Console.ReadLine()!;
//                                ICategory newCategory = new Category(categoryName);
//                                if (newCategory != null)
//                                {
//                                    listOfCategories.Add(newCategory);
//                                    Console.WriteLine("Category was created");
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Something went wrong...");
//                                }
//                                break;

//                            case 2:
//                                Console.WriteLine("Enter Name of product: ");
//                                string name = Console.ReadLine()!;
//                                Console.WriteLine("Enter Brand: ");
//                                string brand = Console.ReadLine()!;
//                                Console.WriteLine("Enter Description: ");
//                                string description = Console.ReadLine()!;
//                                Console.WriteLine("Enter integer Price");
//                                int price = Convert.ToInt32(Console.ReadLine());
//                                int counter = 0;
//                                Console.WriteLine("Choose Category");
//                                foreach(ICategory cat in listOfCategories)
//                                {
//                                    counter++;
//                                    Console.WriteLine($"{counter}) {cat.Name}");
//                                }
//                                int ChoosenCategory = Convert.ToInt32(Console.ReadLine());
//                                ICategory choseCategory = listOfCategories[ChoosenCategory - 1];
//                                Product newProduct = new (name, brand,description, null, price, choseCategory, true);
//                                Console.WriteLine($"{newProduct}\nWas created");
//                                break;

//                            case 0:
//                                Console.WriteLine("Exiting");
//                                break;

//                            default:
//                                Console.WriteLine("Invalid Choice");
//                                break;
//                        }
//                    }while (adminChoice != 0);

//                    break;
//            }
//            break;
//        default:
//            Console.WriteLine("Wrong Choice");
//            break;
//    }

//} while (enteringChoice != 0);


//void Exit()
//{
//    Console.WriteLine("You choose Exit Program Will close soon");
//    Thread.Sleep(500);
//    Console.WriteLine("Closing...");
//    Thread.Sleep(2000);
//    Console.WriteLine("Closed");
//    return;
//}

