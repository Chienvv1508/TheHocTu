using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectPrn211
{
    public class Vali
    {
        public static bool CheckUserName(string userName)
        {   if(userName != null)
            {
                string pattern = @"^\w{8,}$";
                Regex re = new Regex(pattern);
                return re.IsMatch(userName);

            }

                return false;
            
        }
        public static bool CheckName(string name)
        {
            if (name != null)
            {
                string pattern = @"^(\p{Lu}\p{Ll}*\s?)+$";
                Regex re = new Regex(pattern);
                return re.IsMatch(name);
            }

            return false;
        }
        public static bool CheckTenChuDe(string name)
        {
            if (name != null)
            {
                string pattern = @"^(\w+\s?)+$";
                Regex re = new Regex(pattern);
                return re.IsMatch(name);
            }

            return false;
        }
        public static bool CheckTu(string name)
        {
            if (name != null)
            {
                string pattern = @"^([A-Za-z][a-z]+\s?)+$";
                Regex re = new Regex(pattern);
                return re.IsMatch(name);
            }

            return false;
        }
        public static bool CheckCau(string name)
        {
            if (name != null)
            {
                string pattern = @"^([A-Za-z][a-z]+\s)([A-Za-z][a-z]+\s?)+$";
                Regex re = new Regex(pattern);
                return re.IsMatch(name);
            }

            return false;
        }
    }
}
