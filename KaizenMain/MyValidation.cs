using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenMain
{
    class MyValidation
    {
        public static bool validLength(string txt, int min, int max)
        {
            bool ok = true;
            if (string.IsNullOrEmpty(txt))
                ok = false;
            else if (txt.Length < min || txt.Length > max)
                ok = false;
            return ok;

        }

        public static bool validDoubNumber(Double number)
        {

            bool ok = true;
            if (number <= 0.00) 
            {
                ok = false;
            }
            return ok;
        }

        public static bool validIntNumber(int number)
        {

            bool ok = true;
            if (number >= 0)
            {
                ok = false;
            }
            
            return ok;
        }
        public static bool validNumber(string txt)
        {

            bool ok = true;
            for (int x = 0; x < txt.Length; x++)
            {
                if (!(char.IsNumber(txt[x])))
                {
                    ok = false;
                }
            }

            return ok;
        }

        public static bool validLetter(string txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))
                    {
                        ok = false;
                    }

                }
            }
            return ok;

        }

        public static bool validTitle(string txt)
        {
            bool ok = true;

            if (txt.Trim() == "Title")
            {
                ok = false;
            }
            else
                ok = true;
            return ok;

        }

        public static bool vaidCustID(string txt)
        {
            bool ok = true;

            if (txt.Trim() == "      -ENTER-")
            {
                ok = false;
            }
            else
                ok = true;
            return ok;

        }

        public static bool validLetterWhitespace(string txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                    {
                        ok = false;
                    }

                }
            }
            return ok;




        }

        public static bool validEmail(string txt)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(txt);
                return addr.Address == txt;
            }
            catch
            {
                return false;
            }
        }

        public static bool validLetterNumberWhitespace(string txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsNumber(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                    {
                        ok = false;
                    }

                }
            }
            return ok;




        }

        public static bool validForename(string txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                    {
                        ok = false;
                    }

                }
            }
            return ok;

        }

        public static bool validSurname(string txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                    {
                        ok = false;
                    }

                }
            }
            return ok;

        }

        public static String firstLetterEachWordToUpper(string word)
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }

            for (int x = 1; x < array.Length; x++)
            {
                if (array[x - 1] == ' ')
                {
                    if (Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToUpper(array[x]);
                    }
                }
                else
                    array[x] = Char.ToLower(array[x]);
            }
            return new string(array);

        }

        public static String EachLetterToUpper(String word)
        {
            Char[] array = word.ToCharArray();

            for (int x = 0; x < array.Length; x++)
            {
                if (Char.IsLower(array[x]))
                {
                    array[x] = Char.ToUpper(array[x]);
                }

            }

            return new string(array);
        }

        public static bool VailidIDCode(string code, string iD)
        {
            bool ok= false;

            List<string> strList = iD.Split('-').ToList();
            string first = strList.First().ToString();

            if (iD.Equals(first)) 
            {
                ok = true;
            }
            return ok;
        }
    }



}

