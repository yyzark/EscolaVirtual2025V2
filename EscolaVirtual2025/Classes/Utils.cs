using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes
{
    public static class Utils
    {
        public static bool IsAllowedCharacter(char c)
        {
            char[] forbiden = new char[]
            {
                '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',',
                '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^',
                '`', '{', '|', '}', '~', ' '
            };

            if (forbiden.Contains(c))
            {
                return false;
            }
            return true;
        }

        public static bool IsAllowedNameCharacter(char c)
        {
            return char.IsLetter(c) || c == ' ';
        }

        public static bool IsAllowedCharacter(char c, char ignoreChar)
        {
            char[] forbiden = new char[]
            {
                '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',',
                '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^',
                '`', '{', '|', '}', '~', ' '
            };

            if (c == ignoreChar)
                return true;

            if (forbiden.Contains(c))
            {
                return false;
            }
            return true;
        }

        public static bool IsAllowedCharacter(char c, char[] ignoreChars)
        {
            char[] forbiden = new char[]
            {
                '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',',
                '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^',
                '`', '{', '|', '}', '~', ' '
            };

            if (ignoreChars.Contains(c))
                return true;

            if (forbiden.Contains(c))
            {
                return false;
            }
            return true;
        }

        public static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

    }
}
