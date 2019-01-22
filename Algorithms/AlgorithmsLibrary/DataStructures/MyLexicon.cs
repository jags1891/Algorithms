using System;
using System.Collections.Generic;
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

        private MyLexicon()
        {

        }

        
        static List<string> words = System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory()+ @"\Data\Words.txt").Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

        /// <summary>
        /// Find out if the string exist in the Lexicon.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool WordExists(string str)
        {
            return (words.Contains(str) || words.Contains(str.ToLower()) || words.Contains(str.ToUpper())) ;
        }

        /// <summary>
        /// Returns the list of words which contains the sting that is passed
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public  List<string> WordsLike(string str)
        {
            return words.FindAll(s => {return s.Contains(str);});
        }
    }
}
