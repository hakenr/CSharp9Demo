using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharp9Demo
{
	public class TargetTypedNew
	{
		public static void Demo()
		{
			// C# 8.0
			var reader = XmlReader.Create("https://knowledge-base.havit.eu/feed/", new XmlReaderSettings() { IgnoreWhitespace = true });

			// Didn't make it into the C# 8.0 - currently "C# 9.0 Candidate"
			//var reader2 = XmlReader.Create("https://knowledge-base.havit.eu/feed/", new () { IgnoreWhitespace = true });

			//Point[] ps = { new (1, 4), new (3,-2), new (9, 5) };
			//List<string> list = new (10);
		}
	}

	public struct Point
	{
		public Point(int x, int y) { }
	}
}

// https://github.com/dotnet/csharplang/blob/master/proposals/target-typed-new.md
// https://github.com/dotnet/csharplang/issues/100
// https://sharplab.io/#v2:EYLgZgpghgLgrgJwgZwLQygg5hG6CeADhACaoB2EA7gDQkgDUAPgAIAMABCwIwB0AGgFsANgG4AsACh2XbgBYJkqSwDMXAEwcAKphwwtRUgDlqUgN5SOVrmp4A2LnI4ARCIID2ACgCUl6xclrII4AehCOAGEAYg4ADl42P2COADdMDiQoEggEDgBeDiFhACVobIReCMyYCE8AIgALGBhCZBAwgGtydyphUhxUYChkCF4GqBSASxheCDgQyFIQupoOSipCkVKsnIBlXBhJ8ixkHw4zDgBJLG6kAHUG6ZRCKABjCHyOGAQ4D4BfbyKJLBMIuSYkcgAchgHEEUA6H2mHCOMHcXwaH2icQSHFQHFeiCQ5BgwnwHDqWIAnDiIlByCRwbAIHVgUE0rlMuVNAUittypVqrVGs1Wu0Ql0en0SAMhiMxhNprN5osSMtVusOGcLtdbhAHk9kC93p9vr8OACgYFkhwAAruFEAbQAuhxWp8LhrPNxVnJvOrqJqVDRUOo/WsA55KasAKzec2Ka0cAAyk2QMAAPDw2AA+DjCVMwgqe7hsQHAv5SCtKaRqNM/V4wu0o8zA1S2+3EzwojgAD1W3fwcbMVarQA===	