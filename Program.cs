using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to add an organisation");
            int choice = 1;
            switch(choice)
            {
                case 1:
                    Organization OrgObj = new Organization();
                    OrgObj.AddOrgDetails();
                    break;

            }
            Employee EmpObj = new Employee();
            EmpObj.AddDetails();
        }
    }
}
