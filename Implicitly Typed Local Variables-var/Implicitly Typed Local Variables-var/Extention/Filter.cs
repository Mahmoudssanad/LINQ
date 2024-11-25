using Seed_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicitly_Typed_Local_Variables_var.Extention
{
    public static class Filter
    {
        // Extention Method => static method, frist parameter start with (this) keyword
        public static List<Customer> getByName(this List<Customer> _list, string name)
        {
            // Customer => class in seed Data project
            List<Customer> names = new List<Customer>();
            foreach (var item in _list)
            {
                if (item.name.ToLower().Contains(name))
                {
                    names.Add(item);
                }
            }
            return names;
        }

    }
}
