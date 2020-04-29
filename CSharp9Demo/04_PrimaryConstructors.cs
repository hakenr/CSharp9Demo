namespace CSharp9Demo
{
	// Primary Constructor
	public class MyClass(int i, string s) : MyClassBase(s)
	{
		int[] a = new int[i];					// i not captured (init only)
		public int S => s;						// s captured (private field created)
	}

	
	// Equivalent implementation
	public class MyClassImplementation : MyClassBase
	{
		public MyClassImplementation(int i, string s) : base(s)
		{
			__s = s;							// store parameter s for captured use
			a = new int[i];						// initialize a
		}
		int __s;								// generated field for capture of s

		int[] a;
		public int S => __s;					// s replaced with captured __s
	}
}

// https://github.com/dotnet/csharplang/blob/master/proposals/primary-constructors.md
