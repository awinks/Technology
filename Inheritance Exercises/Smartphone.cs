using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Smartphone : Computer
    {
        public int NumberOfSelfies { get; set; }
        public Smartphone(double ram, double storage, bool hasKeyboard) : base(ram, storage, hasKeyboard)
        {
        }
        public int TakeSelfies(int numberOfSelfies) {
            return NumberOfSelfies += numberOfSelfies;
        }

    }
}
