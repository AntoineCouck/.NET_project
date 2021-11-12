using System.Security.Cryptography;
using System.Text;

namespace Logo_Manager2
{
    internal class Utils
    {


     
        public static bool IsEveritingADigit(string text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }



    }

}
