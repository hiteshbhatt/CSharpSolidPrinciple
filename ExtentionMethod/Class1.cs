namespace ExtentionMethod
{

    /**
     * Create extention method for string 
     * 
     */
    public class StringHelper
    {

        public static string ChangeFirstLetter(string str)
        {

            if (str.Length > 0)
            {
                char[] charArray = str.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ?
               char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);

            }
            return str;
        }

    }
}
