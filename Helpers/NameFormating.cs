namespace ATC_BE.Helpers
{
    static public class NameFormating
    {

        static public string UpperCaseFirst(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }
}
