using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_HW_4
{
    public class First
    {
        public EventHandler Handler;
        public Func<int, int, int> SumHandler;
        public int result;
        public int Sum(int a, int b)
        {

            return a + b;

        }
        public int Method_two(int a, int b)
        {
            SumHandler = Sum;
            SumHandler += Sum;
            var tmp = 0;
            var listOfDelegate = SumHandler.GetInvocationList();
            foreach (var item in listOfDelegate)
            {
                var r = item.DynamicInvoke(a, b);
                tmp += Convert.ToInt32(r);
            }
            Console.WriteLine("Result: " + tmp);
            return tmp;
        }
        public void Try(Func<int, int, int> predicate, int a, int b)
        {
            predicate = Method_two;
            try
            {
                predicate.Invoke(a, b);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}