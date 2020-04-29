using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
	public class TargetTypedExpressions
	{
		public void Demo(bool condition, List<int> list, uint? u)
		{
			// C# 8.0 - Error CS0019  Operator '??' cannot be applied to operands of type 'List<int>' and 'int[]'
			IEnumerable<int> x = list ?? Array.Empty<int>();

			// C# 8.0 - Errror CS0019  Operator '??' cannot be applied to operands of type 'uint?' and 'int'
			long l = u ?? -1;

			// C# 8.0 - Rrror CS0173  Type of conditional expression cannot be determined because there is no implicit conversion between 'System.Collections.Generic.List<int>' and 'int[]'
			IEnumerable<int> y = condition ? list : Array.Empty<int>();


			// C# 8.0 Error CS0173  Type of conditional expression cannot be determined because there is no implicit conversion between 'uint?' and 'int'	CSharp9Demo D:\Development\_Prezentace\CSharp9Demo\CSharp9Demo\8_TargetTypedExpressions.cs  23	N/A
			long z = condition ? u : -1;
		}
	}
}
// https://github.com/dotnet/csharplang/blob/master/proposals/target-typed-conditional-expression.md
// https://github.com/dotnet/csharplang/issues/2473
// https://github.com/dotnet/csharplang/issues/2460
// https://github.com/dotnet/csharplang/issues/881