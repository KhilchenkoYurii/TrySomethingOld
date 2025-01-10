// See https://aka.ms/new-console-template for more information
namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //data types
            byte bNumber = 255; // 1b 0-255
            short sNumber = 0; // 2b +-32 767
            int iNumber = 1; // 4b ...
            long lNumber = 2; // 8b ...
            const float Pi = 3.14f; // 4b ...
            float fNumber = 3f; // 4b ...
            double dNumber = 2; // 8b ...
            decimal mNymber = 3m; // 16b ...
            char character = 'a'; // 2b unicode
            bool bValue = false; // 1b true\false
            string str = "keks";
            var something = 2; // var can replace all variable's types
            // overflows
           // bNumber = bNumber + 1;//0

            //checked
            //{
            //    bNumber = bNumber + 1;//returns exception with checked
            //}

            //scope
            {
                byte a = 1;
                {
                    byte b = 1;
                    {
                        byte c = 1;
                    }
                }
            }
            //format string
            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);

            //implicit type conversion 

            byte byte1 = 1; //                              00000001
            int int1 = byte1; // 00000000 00000000 00000000 00000001

            //explicit type conversion 

            int int2 = 1; //00000000 00000000 00000000 00000001
            byte byte2;// = int2; //                      00000001 won't compile

            // explicit casting
            byte2 = (byte)int2;

            //non-compitible type
            string s = "1";

            int sInt = Convert.ToInt32(s);

            int sIntParse = int.Parse(s);

            // try catch
            try
            {
                var strNumber = "1234";
                byte strToByteNumber = Convert.ToByte(strNumber);
                Console.WriteLine(strToByteNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            /*operators
                Arithmetic +, -, *, /, %, ++, --
                postfix 
                 a = 1
                 b = a++
                 a = 2 , b = 1
                prefix 
                 a = 1
                 b = ++a
                 a = 2 , b = 2
                comparison operators
                 == , !=, >, >=, <, <=
                assignment operators
                 =, +=, -=, *=, /=
                Logical operators
                 && - and, || - or, ! - not
                Bitwise operators
                 & - and, | - or
            */
        }


    }
}

