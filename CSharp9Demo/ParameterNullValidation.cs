using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
    public class ParameterNullValidation
    {
        public void DoSomething8(string text)
		{
			if (text is null)
			{
				throw new ArgumentNullException(nameof(text));
			}
		}

		public void DoSomething9(string text!) // syntax still not decided
		{
			// done
		}
    }
}

// https://github.com/dotnet/csharplang/issues/2145
// https://github.com/dotnet/csharplang/blob/master/meetings/2019/LDM-2019-07-10.md#param
