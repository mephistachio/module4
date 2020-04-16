using System;
using System.Text;


namespace module4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please enter the text: ");
			StringBuilder stringbuilder = new StringBuilder();
			otherMain();
			try
			{
				while (true)
				{
					var str = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(str))
					{
						throw new NullReferenceException("NullReferenceException: string is empty");
					}
					if (str.IndexOf("-quit", StringComparison.Ordinal) != -1)
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

		static void otherMain()
		{
			var str = Console.ReadLine();
			var t = str[0];
		}
	}
}
        
