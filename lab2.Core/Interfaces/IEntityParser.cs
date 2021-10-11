using System.Collections.Generic;

namespace lab2_partOne.Data.Core.Interfaces
{
    public interface IEntityParser<T>
    {
        public T ParseEntity(List<string> values);
        public List<T> ParseList(List<List<string>> rows);
    }
}
