namespace CSharp9Demo.Records
{
	public class Point
	{
		readonly int x;
		readonly int y;

		public Point(int x, int y)
		{
			this.x = x;
			this.x = y;
		}

		public Point With(int x = this.x, int y = this.y)
		{
			return new Point(x, y);
		}
	}

	public class CallerReceiverParametersUsage
	{
		public void Demo()
		{
			var p = new Point(10, 20);
			var p2 = p.With(y: 10);
		}
	}
}

// https://github.com/dotnet/csharplang/blob/master/proposals/records.md#caller-receiver-parameters
