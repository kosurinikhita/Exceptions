using System;
using System.Collections.Generic;

namespace Exceptions
{
    class NameAlreadyExistsException : Exception
    {
        public NameAlreadyExistsException()
        {
            Console.WriteLine("Employee Name Already Exists");
        }
        public NameAlreadyExistsException(string message) : base(message)
        {
        }
    }

    class NameNotFoundException : Exception
    {
        public NameNotFoundException()
        {
            Console.WriteLine("[Warn] Employee Namee Not found!\nPlease check the Employee Name");

        }
        public NameNotFoundException(string message) : base(message)
        {

        }

    }
    public class EmployeeDetail
    {
        List<string> list = new List<string>();
        public void AddDetail()
        {
            string result;
            do
            {
                Console.WriteLine("Enter the Employee Name");
                string employeeName = Console.ReadLine();

                if (list.Contains(employeeName))
                {
                    throw new NameAlreadyExistsException("Employee Name " + employeeName + " is already exist");
                }
                else
                    list.Add(employeeName);
                Console.WriteLine("Do you Continue adding Employee Name[yes/no]");
                result = Console.ReadLine();
            } while (result == "yes");

        }

        public void SearchAnEmployee()
        {
            Console.WriteLine("Enter a Employee Name to search");
            string employeeName = Console.ReadLine();

            if (list.Contains(employeeName))
            {
                Console.WriteLine("Employee {0} is present in the DataBase", employeeName);
            }
            else
            {
                throw new NameNotFoundException();
            }
        }

        public void DisplayList()
        {
            Console.WriteLine("Displaying the Employee Name");
            foreach (string name in list)
                Console.WriteLine(name);

        }
    }

}

//using System;

//namespace Exceptions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}
