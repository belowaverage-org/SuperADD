using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperADD
{
    class RandChars
    {
        private static Random ran = new Random();
        private static char[] AlphaNum = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        public static char AlphaLower()
        {
            return AlphaNum[ran.Next(26)];
        }
        public static char AlphaNumLower()
        {
            return AlphaNum[ran.Next(36)];
        }
        public static char AlphaUpper()
        {
            return AlphaNum[ran.Next(36, 62)];
        }
        public static char AlphaNumUpper()
        {
            return AlphaNum[ran.Next(26, 62)];
        }
        public static char AlphaNumAny()
        {
            return AlphaNum[ran.Next(0, 62)];
        }
        public static char AlphaAny()
        {
            if(ran.Next(2) == 0)
            {
                return AlphaUpper();
            }
            else
            {
                return AlphaLower();
            }
        }
        public static char Number()
        {
            return AlphaNum[ran.Next(26, 36)];
        }
    }
}
