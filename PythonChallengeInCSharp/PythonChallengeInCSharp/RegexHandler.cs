using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PythonChallengeInCSharp
{
    class RegexHandler
    {
        // For a collection of multiple matches within a string
        public MatchCollection ReturnMatches(string pattern, string text)
        {
            Regex rgx = new Regex(pattern);

            return rgx.Matches(text);
        }


    }
}
