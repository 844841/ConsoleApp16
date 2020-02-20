using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktodo15
{
    class employeecollection
    {
        List<employee> e = new List<employee>();

        public void adddata()
        {
            e.Add(new employee
            {
                Eid = int.Parse(Console.ReadLine()),
                Ename = (Console.ReadLine()),
                Designation = (Console.ReadLine()),
                Salary = int.Parse(Console.ReadLine()),
            });
        }

            public void getdata()
            {
                foreach (employee cr in e)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.Eid, cr.Ename, cr.Designation, cr.Salary);
                }
            }

            public void remove(int r)
            {
                e.RemoveAt(r);
            }


        }
    }




   

