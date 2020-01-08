using System;
using Operations;

namespace Divide
{
    public interface IDividing
{
    public dynamic Divide(dynamic a, dynamic b);
}
public class Dividing : IDividing
{
    public dynamic result;

    public dynamic Divide(dynamic a, dynamic b)
    {
        result = Division.Quotient(a, b);
        return result;
    }
}
}