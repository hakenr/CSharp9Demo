using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Records
{
	// Record (nominal)
	public data class Student(string Name, decimal Gpa);		  // `data` ?

	// Equivalent implementation
	public sealed class Student : IEquatable<Student>
	{
		public string Name { get; init; }                       // initonly properties (no setter)
		public decimal Gpa { get; init; }
		public Student(string name, decimal gpa)                // ? generated constructor
		{
			this.Name = name;
			this.Gpa = gpa;
		}

		[WithConstructor]
		public virtual Student With() => new Student(this);

		// generated deconstructor
		// Equals()
		// GetHashCode()
		// operator !=
		// operator ==
		// override ToString()
	}

	public class NominalRecordsUsage
	{
		public void Demo()
		{
			var student = new Student { Name = "Petr", Gpa = 3.2m };

			// with-mutation
			student = student with { Gpa = 4m };				// object initializer syntax
		}
	}
}
// https://github.com/dotnet/csharplang/issues/3226
// https://github.com/dotnet/csharplang/blob/master/proposals/recordsv2.md
// https://github.com/dotnet/csharplang/issues/3137 - Records as collection of features
// https://github.com/dotnet/csharplang/issues/3213 - Natural value equality