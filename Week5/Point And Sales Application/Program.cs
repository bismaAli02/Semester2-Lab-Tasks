using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Point_And_Sales_Application.BL;
using Point_And_Sales_Application.DL;
using Point_And_Sales_Application.UI;

namespace Point_And_Sales_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadUsers();
            char op;
            while (true)
            {
                op = PointSaleUI.MainMenu();
                if (op == '1')
                {
                    MUser user = PointSaleUI.Sign_In();

                    if (user != null)
                    {
                        if (user.Role == "Admin")
                        {
                            while (true)
                            {

                                char AdminOption = PointSaleUI.AdminMenu();
                                if (AdminOption == '1')
                                {
                                    Product product = PointSaleUI.AddProduct();
                                    PointSaleUI.AddProductInList(product);
                                }
                                else if (AdminOption == '2')
                                {
                                    PointSaleUI.ViewAllProducts();
                                }
                                else if (AdminOption == '3')
                                {
                                    PointSaleUI.ProductWithHighestPrice();
                                }
                                else if (AdminOption == '4')
                                {
                                    PointSaleUI.ViewProductsWithTax();
                                }
                                else if (AdminOption == '5')
                                {
                                    PointSaleUI.ProductsToBeOrdered();
                                }
                                else if (AdminOption == '6')
                                {
                                    break;
                                }
                                Console.WriteLine("Enter any character to continue!");
                                Console.ReadKey();
                                Console.Clear();

                            }
                        }
                        else if (user.Role == "Customer")
                        {
                            Customer cust = CustomerDL.FindCustomer(user);
                            while (true)
                            {
                                char CustOption = PointSaleUI.CustomerMenu();
                                if (CustOption == '1')
                                {
                                    PointSaleUI.ViewAllProducts();
                                }
                                else if (CustOption == '2')
                                {
                                    PointSaleUI.BuyProduct(cust);
                                }
                                else if (CustOption == '3')
                                {
                                    PointSaleUI.GenerateInvoice(cust);
                                }
                                else if (CustOption == '4')
                                {
                                    break;
                                }
                                Console.WriteLine("Enter any character to continue!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Record not Found!!");
                    }
                }
                else if (op == '2')
                {
                    MUser user = PointSaleUI.Sign_Up();
                    PointSaleUI.AddUserInList(user);
                    LoadInFile(user);
                }
                else if (op == '3')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You Entered Wrong Input!!");
                }
                Console.WriteLine("Enter any character to continue!");
                Console.ReadKey();
                Console.Clear();
            }
            //Console.Read();
        }
        static void ReadUsers()
        {
            string Name, Pass, Role;
            string path = "D:\\Semester2\\VIVA Tasks\\Point And Sales Application\\Stored.txt";
            if (File.Exists(path))
            {
                StreamReader R = new StreamReader(path);
                string record;
                while ((record = R.ReadLine()) != null)
                {
                    Name = PointSaleUI.ParseRecord(record, 1);
                    Pass = PointSaleUI.ParseRecord(record, 2);
                    Role = PointSaleUI.ParseRecord(record, 3);
                    MUser user = new MUser(Name, Pass, Role);
                    PointSaleUI.AddUserInList(user);
                }
                R.Close();

            }
        }
        static void LoadInFile(MUser user)
        {
            string path = "D:\\Semester2\\VIVA Tasks\\Point And Sales Application\\Stored.txt";
            StreamWriter S = new StreamWriter(path, true);
            S.Write("\n" + user.Name + "," + user.Pass + "," + user.Role);
            S.Flush();
            S.Close();
        }


    }
}
