using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace WordCount
{
    public class TextCount
    {
        private int _counter = 0;
        public int LineCounter(List<string> textList)
        {
            _counter = 0;

            _counter = (from line in textList
                        select line).Count();

            return _counter;
        }
        public int WordCounter(List<string> textList)
        {
            _counter = 0;

            foreach (var textSentenc in textList)
            {
                var sentenc = textSentenc.Replace("'", " ").Split(' ');
                _counter += (from word in sentenc
                             where word != ""
                             select word).Count();
            }

            return _counter;
        }
        public int LetterCounter(List<string> textList)
        {
            _counter = 0;
            Regex regex = new Regex("[\\~#%&*{}/:<>?|\"-]");

            foreach (var sentenc in textList)
            {
                var word = Regex.Replace(sentenc, regex.ToString(), " ").ToCharArray();
                _counter += (from letter in word
                             select letter).Count();
            }

            return _counter;
        }
    }
}
