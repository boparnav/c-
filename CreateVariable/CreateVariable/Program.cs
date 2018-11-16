using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateVariable
{
    class Program
    {
        static void Main(string[] args)
        {

            //use of var in c#
           // var a = 1;
           // var s = "Wecome !";
            var ch = 'c';
           // Console.WriteLine("The values are {0},"+"{1},"+"{2}",a,s,ch);
      


            //Min Value andMaxValue
           // Console.WriteLine("The max value for datatyep byte is {0}", byte.MaxValue);
            //Console.WriteLine("The max value for datatyep byte is {0}", byte.MinValue);
            Console.WriteLine("The max value for datatype int is {0}", int.MaxValue);
            Console.WriteLine("The max value for datatype int is {0}", int.MinValue);

            ///escape Sequences
            // Console.WriteLine("\"Navdeep Boparai\"\n 230,  dougall ave\n caledon\n Ontario");
            //implicit type conversion
            // byte b = 3;
            //  int a = b;
            // Console.WriteLine("{0}", a);
            // float f1 = 3.2f;
            // int a1 = (int) f1;
            // Console.WriteLine("{0}", a1);



            //not compatiable conversion

            String s = "123";
            //int y = int.Parse(s);
            // int y = Convert.ToInt16(s);
            // int y = Convert.ToInt32(s);
            /*int y = Convert.ToInt64(s);*/
           //Console.WriteLine("{0}", y);

            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine("{0}", b);
            var number = "45";
            int j = Convert.ToInt32(number);
            Console.WriteLine(j);

            try
            {
                var num = "12345";
                byte z = Convert.ToByte(num);
                Console.WriteLine(z);
            }
            catch(System.OverflowException e)
            {
                Console.WriteLine("The no. could not be converted to byte");
            }

          //  Console.WriteLine("{0}", y);
            Console.ReadKey();



        }
    }
}
