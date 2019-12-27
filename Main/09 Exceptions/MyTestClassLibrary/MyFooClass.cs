using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestClassLibrary
{
    public class MyFooClass
    {
        public string CreateNewFoo(string val)
        {
            switch (val)
            {
                case "IndexOutOfRangeException":
                    throw new IndexOutOfRangeException("index out of range in createNewFoo");
                default:
                    throw new Exception("generic exception");
            }

        }
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }


    }
}
