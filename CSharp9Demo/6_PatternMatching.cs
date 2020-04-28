using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
	public class PatternMatching
	{
		// Type Patterns
		public void TypePatterns(object o1, object o2)
		{
			var t = (o1, o2);
			if (t is (int, string)) { }                 // test if o1 is an int and o2 is a string
			switch (o1)
			{
				case int: break;                        // test if o1 is an int
				case System.String: break;              // test if o1 is a string
			}
		}

		// Relational Patterns
		public static LifeStage LifeStageAtAge(int age)
		{
			return age switch
			{
				< 0 => LiftStage.Prenatal,
				< 2 => LifeStage.Infant,
				< 4 => LifeStage.Toddler,
				< 6 => LifeStage.EarlyChild,
				< 12 => LifeStage.MiddleChild,
				< 20 => LifeStage.Adolescent,
				< 40 => LifeStage.EarlyAdult,
				< 65 => LifeStage.MiddleAdult,
				_ => LifeStage.LateAdult,
			};
		}

		// Pettern Combinators - and, or, not
		public bool IsLetter(char? c)
		{
			if (c is not null)
			{
				return c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
			}
			return false;
		}
	}
}
// https://github.com/dotnet/csharplang/issues/2850
// https://github.com/dotnet/csharplang/blob/master/proposals/patterns3.md
// https://github.com/dotnet/csharplang/issues/2925
// https://github.com/dotnet/csharplang/issues/812