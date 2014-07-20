using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInc.ExtensionsLib
{
    /// <summary>
    /// String Extension Methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Extension to find duplicate usage of word
        /// Should handle punctuation correctly like ','
        /// support case insensitive comparison 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<String> GetWordUsage(this String input)
        {
            var results = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length >= 1)
                .GroupBy(x => x, StringComparer.InvariantCultureIgnoreCase)
                .OrderByDescending(d => d.Count());

            return results.Select(word => word.Key + " - " + word.Count()).ToList();
        }
    }
}
