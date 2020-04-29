using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
	public class NullableEnhancedCommonType
	{
		public void Demo(bool condition)
		{
			// int?
			var x = condition ? 1 : (int?)null;     // C# 8.0
			var y = condition ? 1 : null;           // C# 9.0 Candidate

			// double?
			var a = condition ? x : (double?)1.0;   // C# 8.0
			var b = condition ? x : 1.0;            // C# 9.0 Candidate

		}
    }
}
// https://github.com/dotnet/csharplang/blob/master/proposals/nullable-enhanced-common-type.md
// https://github.com/dotnet/csharplang/issues/33