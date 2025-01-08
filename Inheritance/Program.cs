using System.Collections;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            checkStack();
        }

        public static void checkStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            Console.WriteLine(stack.Pop());
        }

        public static void checkBoxing()
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Yura");
            list.Add(new DateTime());

            var anotherList = new List<int>();
            var names = new List<string>();
        }

        public static void checkCasting()
        {
            Text text = new Text();
            PresentationObject obj = text;
            obj.Height = 200;
            text.Height = 100;
            Console.WriteLine(obj.Height);
        }
        public static void checkConstructors()
        {
            var car = new Car(123);

        }
        public static void checkComposition()
        {
            DbMigrator dbMigrator = new DbMigrator(new Logger());

            Logger logger = new Logger();

            Installer installer = new Installer(logger);

            installer.Install();

            dbMigrator.Migrate();
        }
    }
}
