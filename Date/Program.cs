// See https://aka.ms/new-console-template for more information
namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime class
            DateTime customDate = new DateTime(1999, 1, 28);
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            Console.WriteLine("Houre: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = today.AddDays(-1);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString(""));

            //TimeSpan creating
            TimeSpan timeSpan = new TimeSpan(1, 1, 1);
            TimeSpan timeSpan1 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration.ToString());

            //Properties
            Console.WriteLine("Minutes: "+ timeSpan.Minutes);
            Console.WriteLine("Total Minutes: "+ timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example:"+ timeSpan.Add(TimeSpan.FromMinutes(8)));
            //subtrack
            Console.WriteLine("Add Example:" + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));





        }
    }
}
