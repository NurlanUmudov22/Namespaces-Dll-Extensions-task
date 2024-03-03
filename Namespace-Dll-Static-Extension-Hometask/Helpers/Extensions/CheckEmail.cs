using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extension_Hometask.Helpers.Extensions
{
    internal static class CheckEmail
    {

        public static bool CheckEmailSymbol(this string email, char symbol)
        {
           return email.Contains(symbol);
        }



        public static string CheckPasswordLength(this string password)
        {
            if (password.Length == 8)
            {
                return "Passwordun uzunlugu 8-dir.";
            }
            else if (password.Length > 8)
            {
                return "Passwordun uzunlugu 8-den coxdur";
            }
            else
            {
                return "Passwordun uzunlugu 8den azdir";
            }
             
        }



        public static int MultiOfNums(this int[] arr)
        {
            int multi = 1;

            for ( int i = 0; i < arr.Length; i++ )
            {
                if (arr[i] > 0)
                {
                    multi *= arr[i];
                } 
            }
            return multi;
        }








    }
}
