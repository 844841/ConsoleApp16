using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktodo15
{
    class Program
    {
        static void Main(string[] args)
        {
            employeecollection emp = new employeecollection();
            Console.WriteLine("enter no.of employees:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter details of employee:");
            for(int i=0;i< n;i++)
            {
                emp.adddata();
                //emp.getdata();
            }

            emp.getdata();
            Console.WriteLine("enter index value:");
            int z = int.Parse(Console.ReadLine());
            emp.remove(z);
            emp.getdata();

            
            

        }
    }
}
