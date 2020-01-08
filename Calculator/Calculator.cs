using Divide;
using Sum;

namespace Calculator
{
    public interface ICalculatorBasic{

        public dynamic Add(dynamic a, dynamic b);

        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Calculator : IAdding, IDividing, ICalculatorBasic
    {
        public dynamic result;
        private readonly Adding add = new Adding();
        private readonly Dividing divide = new Dividing();

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;
        }

    }
}