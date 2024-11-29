using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select_Operation
{
    internal class EmployeeDto // Data Transefer Object => الا ببعته للعميل 
    {
        //فيه return ده عشان ا class عملت ال 
        public string Name { get; set; }
        public int totalSkills { get; set; }

        public override string ToString()
        {
            return $"{ Name} => {totalSkills}";
        }
    }
}
