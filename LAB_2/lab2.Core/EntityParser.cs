using lab2_partOne.Data.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Data.Core
{
    public abstract class EntityParser<T> : IEntityParser<T>
    {
        public abstract T ParseEntity(List<string> values);
        public List<T> ParseList(List<List<string>> rows)
        {
            return rows.Select(i => ParseEntity(i)).ToList();
        }
    }
}
