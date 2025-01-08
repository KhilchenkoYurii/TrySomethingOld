using Non_Primitive_types;
namespace Solution

{

    class Program
    {
        static void Main(string[] args)
        {
            Person kek = new Person();
            kek.Name = "Test";
            kek.introduce();
            int result = Person.calculate(1, 2);

            int[] array1 = new int[3] { 1, 2, 3 };
            /*
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            */

            string formatExample = string.Format("{0},{1}", ["Josh", "Smith"]);
            string list = string.Join(",", array1);
            string ex = "Keks";
            char firstLetter = ex[0];
            //ex[0] = 'k'; - we can`t change it
            // \n - new line; \t - tabulation; \\ - backslash; \' and \" - quotion

            // verbatim strings
            string path = "c:\\project\\main\\path.exe";
            string path2 = @"c:\project\main\path.exe";

            //Enum
            int enumValue = (int)EnumExample.Success;
            var enumValue2 = EnumExample.Success;
            Console.WriteLine(enumValue2.ToString());
            int status = 3;
            Console.WriteLine((EnumExample)status);
            var customEnumValue = "Success";
            var enumMethod = (EnumExample)Enum.Parse(typeof(EnumExample), customEnumValue);
            Console.WriteLine((EnumExample)enumMethod);

            //Reference types and Value types
            //Value types
            int a = 10;
            int b = a;
            b++;
            Console.WriteLine("a: {0}, b: {1}", a, b); // значення b в стеку незалежне від значення а, воно його просто скопіювало

            //Reference type

            var array12 = new int[3] { 1,2,3 };
            var array2 = array12;
            array2[0] = 0;
            Console.WriteLine(array12[0]);// 0
            // масив це структура, яка зберігається в heap і має адресу, коли ми створюємо нову сруктуру і посилаємося
            // на попередній об'єкт, то там копіюється тільки адреса першого об'єку і після такого ми можемо з обох об'єктів 
            // редагувати одну і ту саму ділянку пам'яті


        }
    }
}