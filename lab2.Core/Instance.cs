using lab2_partOne.Data.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_partOne.Data.Core
{
    public abstract class Instance<T> where T : IEntity
    {
        public IProvider<T> _provider;
        public List<T> Items { get; set; }

        protected Instance(IProvider<T> provider) {
            _provider = provider;

            InitializeData();
        }

        private void InitializeData()
        {
            Items = _provider.GetContent();
            var result = ComputeSmallestWithTargetProperties();
            PrintResult(result);
        }

        public void PreventConsole()
        {
            Console.WriteLine("Program finished...");
            Console.ReadLine();
        }

        private T ComputeSmallestWithTargetProperties()
        {
            var minSpread = decimal.MaxValue;
            var indexFound = -1;
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                if (minSpread > item.GetDifferenceBetweenTargetProperties())
                {
                    minSpread = item.GetDifferenceBetweenTargetProperties();
                    indexFound = i;
                };
            }

            return indexFound > -1 ? Items[indexFound] : default(T);
        }

        public abstract void PrintResult(T result);
    }
}
