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
		public override MyCloneableClassBase Clone() // C# 8.0
		public override MyCloneableClass Clone() // C# vNext
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
			MyCloneableClass c2 = (MyCloneableClass)c.Clone(); // C# 8.0
			MyCloneableClass c3 = c.Clone(); // C# vNext
		}
	}
}
