using Helpers.DataExtractor;
using System.Collections.Generic;
using lab2_partOne.Data.Core.Interfaces;

namespace lab2_partOne.Data.Core
{
    public abstract class Provider<T> : IProvider<T>
    {
        public string Source { get; protected set; }
        public IEntityParser<T> Parser { get; protected set; }

        public List<T> GetContent()
        {
            return Parser.ParseList(DataExtractor.Execute(System.IO.File.ReadAllText(Source)));
        }
    }
}
