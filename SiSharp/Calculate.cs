using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSharp
{
    public class Calculate
    {

        public Calculate()
        {

        }

        public int Add(params int[] numbers)
        {

            int result = 0;

            for(int i = 0; i < numbers.Count(); i++)
            {
                result = result + int.Parse(numbers[i].ToString());
            }

            return result;
        }

        public void ParameterByRef(ref int a)
        {
            a += 2;
        }


        public void OutParameters(out int res)
        {
            res = 100;
        }

    }
}
