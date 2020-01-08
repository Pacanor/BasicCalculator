using System;
using Operations;

namespace Sum
{
    public interface IAdding
    {
        public dynamic Add(dynamic a, dynamic b);
    }
    public class Adding : IAdding
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }
    }
}
