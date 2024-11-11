using System;

namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
           Manager m = new Manager(2020189,"Bakr",195,7500);
            
            Maintance ms = new Maintance(2022,"Beco",180,5000);

            Sales s = new Sales(2025,"Khaled",190,3000,0.05m,10);

            Developer d = new Developer(2023,"elsawy",185,9000,true);
            
            Employee[] employees = { m, ms, s, d };
            foreach (var e in employees)
            {
                Console.WriteLine("\n======================\n");
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
    

}