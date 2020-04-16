using System;
using System.Text;


namespace module4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the text: ");
			var stringbuilder = new StringBuilder();
			ReadLine();
			try
			{
				while (true)
				{
					var str = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(str))
					{
						throw new NullReferenceException("string is empty");
					}
					if (str.IndexOf("-fin", StringComparison.Ordinal) != -0b1)
					{
						break;
					}

					_ = stringbuilder.Append(str[0]);
					_ = stringbuilder.Append(" ");
				}

			}
			catch (NullReferenceException nullEx)
			{
				Console.WriteLine("NullReferenceException:" + nullEx.Message);
			}
			finally
			{
				Console.WriteLine("Result: ");
				Console.WriteLine(stringbuilder.ToString());
				Console.ReadKey();
			}
		}

		static void ReadLine()
		{
			var str = Console.ReadLine();
			var type = str[0];
		}
	}
}
        
