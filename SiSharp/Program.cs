using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start ... ");

            var customer = new Customer(1);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var customer2 = new Customer(1,"Tito");

            var Order = new Order();
            
            customer2.Orders.Add(Order);


            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);


            var order = new Order { TotalOrders = 10, TotalDolars = Convert.ToDecimal("23400.20")};
            Console.WriteLine("Total Number of Orders : {0} equals Total Number of Dollars ${1}", order.TotalOrders, order.TotalDolars);


            var calc = new Calculate();
            int i = calc.Add(1, 2, 3, 4, 5);
            Console.WriteLine("My result is {0}", i);
            int x = calc.Add(new int[] { 1, 2, 3 });
            Console.WriteLine("My result is {0}", x);

            int a = 1;
            calc.ParameterByRef(ref a);  // "a" will be return as 3
            Console.WriteLine("My result is {0}", a);


            int b;
            calc.OutParameters(out b);
            Console.WriteLine("My result is {0}", b);


            var cookie = new HttpCookie();
            cookie["name"] = "Jaime";
            cookie["age"] = "49";
            cookie["gender"] = "Male";
            cookie["team"] = "Cowboys";
            Console.WriteLine("{0}-{1}-{2}-{3}",cookie["name"], cookie["age"], cookie["gender"], cookie["team"]);

            var StopWatch = new StopWatch();
            Console.WriteLine("Press any key to continue...");
            Console.Read();
            var span = StopWatch.TimeSpan();
            Console.WriteLine("My Time span is {0}", span);

            Console.Read();
            Console.ReadLine();
        }
    }

    
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;

        }
    }


}
