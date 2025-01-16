namespace Dynamic;

public class Program
{
    public static void Main(string[] args)
    {
        CheckDynamicBindig();
    }

    public static void CheckDynamicBindig()
    {
        object obj = "Yurii";

        //var methodInfo = obj.GetType().GetMethod("GetHashCode");
        
        //methodInfo.Invoke(null,null);

        dynamic excelObj = "Yurii";
        
        //excelObj.Optimize();

        dynamic name = "Yurii";

        name = 10;

        dynamic a = 10;
        dynamic b = 10;

        var c = a + b; // c will be dynamic too

        int i = 5;

        dynamic dynamicI = i;

        long l = dynamicI;
    }
}