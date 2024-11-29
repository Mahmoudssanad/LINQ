using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public static class ExtensionFunctional
    {
        // LINQ مباشر في where الا بنعوض عنها ب  
        public static IEnumerable<Employee> Filter
            (this IEnumerable<Employee> source, Func<Employee, bool> predicate)
        {
            // Extention method من جوا بس انا بستخدمها علطول لانها بتكون where يعني يعتبر الكود دا بتاع ال 
            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);
            }
        }
    }
}
