using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss12
{
    class Employee : DictionaryBase
    {
        public void Add(int id, string name)
        {
            Dictionary.Add(id, name);
        }
        public void OnRemove(int id)
        {
            Console.WriteLine("You are going to delete record containing ID: " + id);
            Dictionary.Remove(id);
        }
        public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator();
            while (objEnumerate.MoveNext())
            {
                Console.WriteLine(objEnumerate.Key.ToString() + “\t\t” +
                 objEnumerate.Value);
            }
        }
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.Add(102, "John");
            objEmployee.Add(105, "James");
            objEmployee.Add(106, "Peter");
            Console.WriteLine("Original values stored in Dictionary");
            objEmployee.GetDetails();
            objEmployee.OnRemove(106);
            Console.WriteLine("Modified values stored in Dictionary");
            objEmployee.GetDetails();
        }
    }
}