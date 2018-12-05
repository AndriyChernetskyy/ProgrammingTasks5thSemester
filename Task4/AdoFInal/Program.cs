using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoFInal
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> commands = new List<string>();
            commands.Add("SELECT * FROM Employees WHERE EmployeeID = 8");
            commands.Add("SELECT FirstName,LastName FROM Employees WHERE City = 'London'");
            commands.Add("SELECT FirstName,LastName FROM Employees WHERE FirstName Like 'A%'");
            //14
            commands.Add("SELECT  (FirstName + ' ' + LastName) as Name , Count(Orders.EmployeeID) as OrdersCount FROM Employees " +
                "left join  Orders on Employees.EmployeeID = Orders.EmployeeID" +
                " group by(FirstName + ' ' + LastName)");
            commands.Add("SELECT Count(EmployeeID) as AmountOfLondoners FROM Employees WHERE City = 'London'");
            //16
            commands.Add("SELECT  (FirstName + ' ' + LastName) as Name, Count(Orders.EmployeeID) as OrdersCount FROM Employees " +
                "left join  Orders on Employees.EmployeeID = Orders.EmployeeID and Orders.RequiredDate > Orders.ShippedDate and(Orders.ShippedDate between '1997-01-01' and '1997-12-31') " +
               "group by(FirstName + ' ' + LastName)");
            //17
            commands.Add("SELECT(Customers.ContactName) as Name, Count(Orders.CustomerID) as OrdersCount FROM Customers " +
            "inner join Orders on Orders.CustomerID = Customers.CustomerID  and Customers.Country = 'France'" +
             " group by Customers.ContactName");

            //18
            commands.Add("SELECT  (Customers.ContactName) as Name  , Count(Orders.CustomerID) as OrdersCount FROM Customers " +
               "inner join Orders on Orders.CustomerID = Customers.CustomerID  and Country = 'France'" +
                " group by Customers.ContactName having Count(Orders.CustomerID) > 1");
            //19
            commands.Add("SELECT  (Customers.ContactName) as Name  , Count(Orders.CustomerID) as OrdersCount FROM Customers " +
                 "inner join Orders on Orders.CustomerID = Customers.CustomerID  and Country = 'France'" +
                  " group by Customers.ContactName having Count(Orders.CustomerID) > 1");
            commands.Add("select Customers.ContactName from Customers " +
                           " where Customers.CustomerID in " +
                           "(select CustomerID from Orders where OrderID in " +
                            "(select OrderID from[Order Details] inner join Products on[Order Details].ProductID = Products.ProductID and Products.ProductName = 'Tofu'))");


            string connectionString = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                
                int numberToEnter = 1;
               
                while (numberToEnter >= 1 && numberToEnter <= 10)
                {
                    Console.WriteLine("Enter number of query(from 1 to 10): ");
                    numberToEnter = Convert.ToInt32(Console.ReadLine());
                    SqlCommand command = new SqlCommand(commands[numberToEnter-1], connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Result:\n");
                       
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader.GetName(i) + ":\t" + reader.GetValue(i));
                                Console.WriteLine();

                            }
                            Console.WriteLine();

                        }
                    }

                    reader.Close();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            } 

            Console.ReadLine();
        }
    }
}
