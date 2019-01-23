using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.DataStructures
{
    /// <summary>
    /// English Dictionary
    /// To to enhanced....
    /// </summary>
    public class MyLexicon
    {
        private static MyLexicon _myLexicon;

        /// <summary>
        /// 
        /// </summary>
        public static MyLexicon Instance
        {
            get
            {
                if (_myLexicon == null)
                    _myLexicon = new MyLexicon();

                return _myLexicon;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public  HashSet<string> Dictionary
        {
            get
            {
                return new HashSet<string>(_words);
            }
        }


        private MyLexicon()
        {

        }

        
         List<string> _words = System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory()+ @"\Data\Words.txt").Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

        /// <summary>
        /// Find out if the string exist in the Lexicon.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool WordExists(string str)
        {
            return (Dictionary.Contains(str) || Dictionary.Contains(str.ToLower()) || Dictionary.Contains(str.ToUpper()) || Dictionary.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str))) ;
        }

        
    }
}
