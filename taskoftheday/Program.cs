using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace taskoftheday
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            // employee data
            employeeDetails user1 = new employeeDetails() { employee_id = 3222, firsName="thomas",lastName="Edison",emailId="thomas@gmail.com" };
            employeeDetails user2 = new employeeDetails() { employee_id = 3223, firsName = "Henry", lastName = "Paul", emailId = "henry@gmail.com" };
            employeeDetails user3 = new employeeDetails() { employee_id = 3224, firsName = "Issac", lastName = "Newton", emailId = "issac@gmail.com" };
            Dictionary<int, employeeDetails> details = new Dictionary<int, employeeDetails>();
            details.Add(user1.employee_id, user1);
            details.Add(user2.employee_id, user2);
            details.Add(user3.employee_id, user3);

            // site data
            siteDetails site1 = new siteDetails() { employeeId = 3222 ,siteId = "23234" };
            siteDetails site2 = new siteDetails() { employeeId = 3223, siteId = "23235" };
            siteDetails site3 = new siteDetails() { employeeId = 3224, siteId = "23234" };
            Dictionary<int,string> sdetails= new Dictionary<int,string>();
            sdetails.Add( site1.employeeId, site1.siteId);
            sdetails.Add(site2.employeeId ,site2.siteId);
            sdetails.Add(site3.employeeId, site3.siteId);


            Console.WriteLine("enter the site id:");
            string temp = Console.ReadLine();
            int flag = 0;
            foreach (var data in sdetails)
            {
                string temp11 = data.Value;
                int temp12;
                if (temp == temp11)
                {
                    temp12 = data.Key;
                    Console.WriteLine("", temp12);
                    Console.WriteLine("employeeID: {0} firstName: {1}    lastName:  {2}    emailID:  {3} ", temp12, details[temp12].firsName, details[temp12].lastName, details[temp12].emailId);
                    Console.WriteLine();
                    flag = 1;
                }
                
                
            }
            if(flag == 0)
            {
                Console.WriteLine("Invalid Key");
            }
           
        }
    
    }

}
