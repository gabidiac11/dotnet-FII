using System.Collections.Generic;

namespace lab2_partOne.Data.Core.Interfaces
{
    public interface IProvider<T>
    {
        public List<T> GetContent();
    }
}
