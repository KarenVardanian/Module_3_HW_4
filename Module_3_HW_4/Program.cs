using Module_3_HW_4.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_HW_4
{
  
    
    public class Program
    {
        static void Main()
        {
            var f = new First();
            Func<int, int, int> a;
            a = f.Method_two;
            f.Try(a, 1, 1);

            List<Contact> list = new List<Contact>();
            var Ivan = new Contact
            {
                Name = "Ivan",
                Age = 25,
                Phone = "380987345123"
            };
            var Petr = new Contact
            {
                Name = "Petr",
                Age = 21,
                Phone = "380661759854"
            };
            var Ivan_Vodaphone = new Contact
            {
                Name = "Ivan",
                Age = 25,
                Phone = "380991759854"
            };
            var Kiril = new Contact
            {
                Name = "Kiril",
                Age = 25,
                Phone = "380991759643"
            };
            var Nikita = new Contact
            {
                Name = "Nikita",
                Age = 43,
                Phone = "380671759814"
            };
            var Sergey = new Contact
            {
                Name = "Sergey",
                Age = 19,
                Phone = "380738329833"
            };
            list.Add(Kiril);
            list.Add(Ivan);
            list.Add(Sergey);
            list.Add(Nikita);
            list.Add(Ivan_Vodaphone);
            list.Add(Petr);

            var FirstList = list.Where(x => x.Phone.StartsWith("38099"));
            var SecondList = list.Where(x => x.Phone.Contains("99")).OrderBy(o=>o.Name);
            var ThirdList = list.FirstOrDefault(x => x.Age < 22 && x.Name != "Sergey");
            var FourList = list.FirstOrDefault(x => x.Name.Contains("I"));
            var FifthList =list.Select(x => x.Name);
            var ListSix = list.Take(4).Where(x => !x.Phone.StartsWith("38099"));
            var ListSeven = list.Where(x => x.Age>20).OrderByDescending(o=>o.Age);
            var ListEight = list.Count(x => x.Age > 21);
        }
    }
}
