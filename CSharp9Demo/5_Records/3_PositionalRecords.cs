using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Records
{
	// Record (positional)
	public sealed class Student(string Name, decimal Gpa);		  // `data` ?

	// Equivalent implementation
	public sealed class Student : IEquatable<Student>
	{
		public string Name { get; }
		public decimal Gpa { get; }
		public Student(string Name, decimal Gpa)
		{
			this.Name = Name;
			this.Gpa = Gpa;
		}
		public bool Equals(Student other) // for IEquatable<Student>
		{
			return other != null && Equals(Name, other.Name) && Equals(Gpa, other.Gpa);
		}
		public override bool Equals(object other)
		{
			return this.Equals(other as Student);
		}
		public override int GetHashCode()
		{
			return (Name?.GetHashCode() * 17 + Gpa?.GetHashCode()).GetValueOrDefault();
		}
		public Student With(string Name = this.Name, decimal Gpa = this.Gpa) => new Student(Name, Gpa);
		public void Deconstruct(out string Name, out decimal Gpa)
		{
			Name = this.Name;
			Gpa = this.Gpa;
		}

		// operator !=
		// operator ==
		// override ToString()
	}

	public class RecordsUsage
	{
		public void Demo()
		{
			var student = new Student("Petr", 3.2m);
			
			// with-mutation
			student = student with { Gpa = 4m };                

			// deconstruction
			(string name, decimal gpa) = student;			
			
			// pattern matching (deconstuction)
			if (student is ("Petr", decimal g))
			{
				Console.WriteLine(g);
			}
		}
	}
}
// https://github.com/dotnet/csharplang/issues/39
// https://github.com/dotnet/csharplang/blob/master/proposals/records.md
// (https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct)