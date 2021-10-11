using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// extracts values from dataset file using header columns (width based)
/// </summary>
namespace Helpers.DataExtractor
{
    public class DataExtractor
    {
        public static List<List<string>> Execute(string content)
        {
            var lines = content.Replace('-', ' ')
                               .Split("\n", StringSplitOptions.RemoveEmptyEntries)
                               .Where(line => Regex.IsMatch(line, @"[^\s]")).ToList();//remove useless rows (with only spaces)

            var headerRow = lines.First() + " ";
            var offsets = ExtractColumnOffsets(headerRow);

            var resultRows = new List<List<string>>();

            for (var i = 1; i < lines.Count; i++)
            {
                var currentRow = new List<string>();
                var line = lines[i].PadRight(headerRow.Length) + " ";
                foreach (var (startIndex, length) in offsets)
                {
                    var portion = line.Substring(startIndex, length).Replace("*", "");
                    var valuePrioritized = Regex.Match(portion, @"\s([\d]+\.\s[\w]+)\s").Groups.Values.FirstOrDefault();
                    var value = !string.IsNullOrEmpty(valuePrioritized.Value) ? valuePrioritized : Regex.Match(portion, @"\s([\w\d\.\*]+)\s").Groups.Values.FirstOrDefault();
                    
                    //Console.WriteLine($"'{portion}' '{value}'");

                    currentRow.Add(value?.Value != null ? value.Value.Trim() : "");
                }
                //Console.WriteLine();

                resultRows.Add(currentRow);
            }

            return resultRows;
        }

        private static List<Tuple<int, int>> ExtractColumnOffsets(string headerRow)
        {
            
            var headerCols = Regex.Matches(headerRow, @"[\s]*[\w]+[\s]*").Cast<Match>().Select(match => match.Value).ToList();
            var offsets = new List<Tuple<int, int>>(new Tuple<int, int>[] { });

            for (var i = 0; i < headerCols.Count(); i++)
            {
                //Console.Write($"'{headerCols[i]}', ");

                if (i > 0)
                {
                    var space = Regex.Match(headerCols[i - 1], @"[\w]+([\s]+)").Groups.Values.Last().Value;
                    var m = Regex.Match(headerCols[i - 1], @"[\w]+([\s]+)").Groups.Values.Last();
                    headerCols[i] = space + headerCols[i];
                }

                //Console.Write($"'{headerCols[i]}'");
                //Console.WriteLine();

                var indexStart = headerRow.IndexOf(headerCols[i]);
                var length = headerCols[i].Count();
                if (i == headerCols.Count() -1)
                {
                    indexStart -= 1;
                    length += 1;
                }

                offsets.Add(new Tuple<int, int>(indexStart, length));
            }

            return offsets;
        }
    }
}
