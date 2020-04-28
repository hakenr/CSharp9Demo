using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
	public class MyCloneableClassBase
	{
		public virtual MyCloneableClassBase Clone()
		{
			return new MyCloneableClassBase();
		}
	}

	public class MyCloneableClass : MyCloneableClassBase
	{
		public override MyCloneableClass Clone() // C# 9.0 Candidate
		{
			return new MyCloneableClass()
			{
				// copy values
			};
		}
	}

	public class CovariantReturnTypes
	{
		public void Demo()
		{
			MyCloneableClass c = new MyCloneableClass();
			MyCloneableClass c3 = c.Clone(); // C# 9.0 Candidate
		}
	}
}
