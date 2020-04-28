#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;


namespace CSharp9Demo
{
	public class LocalFunctionAttributes
	{
		public void Demo(string[] args)
		{
			if (TryParse("gag", out var x))
			{
				Console.WriteLine(x.Length);
			}

			//  C# 8.0: CS8205 Attributes are not allowed on local function parameters or type parameters
			static bool TryParse(string input, [NotNullWhen(true)] out string? result)
			{
				result = null;
				return false;
			}
		}
	}
}

// https://github.com/dotnet/csharplang/issues/1888
// already in <LangVersion>preview</LangVersion>