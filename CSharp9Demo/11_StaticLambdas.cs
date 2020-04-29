using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
    public class StaticLambdas
    {
        public void Demo()
		{
			int y = 10;
			SomeMethod(x => x + y);				// captures 'y', causing unintended allocation.

			SomeMethod(static x => x + y);      // disallow capturing state from the enclosing scope

			const int z = 10;
			someMethod(static x => x + z);		// okay :-)
		}

		public void SomeMethod(Func<int, int> func)
		{
		}
    }
}
// https://github.com/dotnet/csharplang/issues/275
// https://github.com/dotnet/csharplang/blob/master/proposals/static-lambdas.md 