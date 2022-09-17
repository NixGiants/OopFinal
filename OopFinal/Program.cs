// See https://aka.ms/new-console-template for more information
using BussinesLogic.Interfaces;
using BussinesLogic.Models;
using BussinesLogic.Models.Payment;
using BussinesLogic.Enums;
using System.Runtime.CompilerServices;

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

ApplicationUser Customer = new("Vasya", "Vasiliev", listOfPaymentMethods, "Vasya", "12345", Access.Customer);
ApplicationUser Admin = new ApplicationUser("Gerakl", "Greece", listOfPaymentMethods, "admin", "admin", Access.Admin);
List<ApplicationUser> RegisteredUsers = new List<ApplicationUser> { Customer, Admin };

Console.WriteLine("Hello! We are Happy to see you in E-Shop!\n\n");
int enteringChoice = -1;
do
{ 
    Console.WriteLine("If you want to\n1) Enter press -- 1\n0) For Exit -- press 0");

    try
    {
        enteringChoice = Convert.ToInt32(Console.ReadLine());
        switch (enteringChoice)
        {
            case 0:
                Exit();
                break;
            case 1:
                ApplicationUser? currentUser = null;
                int AuthorizationChoice = -1;
                do
                {
                    Console.WriteLine("Enter Login or Enter 0 if you are new user");
                    string Login = Console.ReadLine();
                    switch (Login)
                    {
                        case "0":
                            Console.WriteLine("Enter First Name: ");
                            string FirstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            string LastName = Console.ReadLine();
                            Console.WriteLine("Enter login: ");
                            string login = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string password = Console.ReadLine();

                            currentUser = new ApplicationUser(FirstName, LastName, null, login ,password, Access.Customer);
                            Console.WriteLine($"Hello {currentUser.FirstName} {currentUser.LastName}");
                            AuthorizationChoice = 0;
                            break;

                        default:
                            string Password = "";
                            Console.WriteLine("Enter Password :");
                            Password = Console.ReadLine();
                            foreach (ApplicationUser appUser in RegisteredUsers)
                            {
                                if (appUser.CheckIsRegistered(Login, Password))
                                {
                                    currentUser = appUser;
                                    AuthorizationChoice = 0;
                                }
                            }
                            if(currentUser == null)
                            {
                                Console.WriteLine("Sorry, You are not registered yet");
                                Console.WriteLine("If you want try one more time\tpress 1\nFor Exit\tPress 0");
                            }
                            else
                            {
                                Console.WriteLine($"Hello {currentUser.FirstName} {currentUser.LastName}");
                            }
                            break;
                    }
                } while (AuthorizationChoice != 0);
                switch (currentUser.Access)
                {
                    case Access.Customer:
                        Basket currentBasket = new Basket();
                        int categoryIndex = 0;
                        do
                        {
                            Console.WriteLine("Categories:\n 1) milk products\n2)Head Sets\n0)Exit");
                            try
                            {
                                categoryIndex = Convert.ToInt32(Console.ReadLine());
                                int counter = 0;
                                switch (categoryIndex)
                                {
                                    case 0:
                                        Exit();
                                        break;

                                    case 1:
                                        foreach (Product pr in listOfMilkProducts)
                                        {
                                            counter++;
                                            Console.WriteLine($"{counter}) {pr}");
                                        }
                                        counter = 0;
                                        break;

                                    case 2:
                                        foreach (Product pr in listOfHeadSets)
                                        {
                                            counter++;
                                            Console.WriteLine($"{counter}) {pr}");
                                        }
                                        counter = 0;
                                        break;
                                }
                                Console.WriteLine();
                                {

                                }

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(" Invalid choice. Try one more time");
                            }
                        } while (categoryIndex != 0);
                        break;
                    case Access.Admin:

                        break;
                }
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Invalid Choice try one more time");
    }

} while (enteringChoice != 0);


void Exit()
{
    Console.WriteLine("You choose Exit Program Will close soon");
    Thread.Sleep(500);
    Console.WriteLine("Closing...");
    Thread.Sleep(2000);
    Console.WriteLine("Closed");
}

