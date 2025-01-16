namespace ExtensionMethods;

public static class StringExtension
{
    public static string Shorten(this String str, int numbersOfWords)
    {
        if (numbersOfWords <= 0)
        {
            return "";
        }

        var words = str.Split(' ');

        if (words.Length < numbersOfWords)
        {
            return str;
        }

        return string.Join(" ", words.Take(numbersOfWords));
    }
}