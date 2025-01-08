namespace Classes
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                checkPost();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static void checkPost()
        {
            Post post;
            Console.WriteLine("Hi, please, enter the Title of the post:");
            string title = Console.ReadLine();
            Console.WriteLine("Hi, please, enter the Description of the post:");
            string description = Console.ReadLine();
            post = new Post(title, description);
            string input = "";
            while (input != "E")
            {
                Console.WriteLine("Press E to exit and + or - to vote");
                input = Console.ReadLine();
                if (input == "E")
                    break;
                if(input == "+")
                    post.UpVote();
                if (input == "-")
                    post.DownVote();
            }
            post.Represent();
        }

        public static void checkStopwatch()
        {
            Stopwatch st = new Stopwatch();
            string input = "";
            while (input != "E")
            {
                Console.WriteLine("Press Enter to start");
                input = Console.ReadLine();
                st.Start();
                Console.WriteLine("Press Enter to stop");
                input = Console.ReadLine();
                st.Stop();
                Console.WriteLine("Press E to exit and R to restart");
                input = Console.ReadLine();
                if(input == "R")
                    st.Reset();
            }
        }

        public static void checkHttpCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Yurii";
            Console.WriteLine(cookie["name"]);
        }
        public static void checkCustomer()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }

        public static void checkPerson()
        {
            Person person = new Person(new DateTime(1999, 1, 28));
            person.Introduce("Keksik");
            Customer customer1 = new Customer
            {
                Id = 2,
                Name = "Lian"
            };
            Customer customer = new Customer(1, "Jhon");
            Console.WriteLine(person.Age);

        }

        public static void checkPoints()
        {
            try
            {
                var point = new Point(1, 2);
                point.Move(2, 1);
                point.Move(null);

                Console.WriteLine("Point now at ({0},{1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void checkCalculator()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1, 2,3));
            Console.WriteLine(calculator.Add(1, 2,3,4));

        }

    }
}
