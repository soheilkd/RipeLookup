using System;
using System.Linq;
using System.Net;

namespace RipeLookup
{
	class Program
	{
		static void WriteParsedXml(string xml)
		{
			foreach (var item in Parser.Parse(xml))
			{
				if (item.Value == "")
					Console.WriteLine();
				Console.WriteLine(item.ToString());
			}
		}

		static void Main()
		{
			while (true)
			{
				Console.WriteLine("1: Host by DNS");
				Console.WriteLine("2: IP\\Host");
				Console.WriteLine("\r\nQuery <typeNumber>:<value>");
				var query = Console.ReadLine();
				try
				{
					Console.WriteLine("Processing...");
					switch (query[0])
					{
						case '1':
							var ips = Dns.GetHostEntry(query.Substring(2));
							var firstIp = ips.AddressList.First() ?? new IPAddress(new byte[] { 0, 0, 0, 0 });
							var xml = WhoisOperator.RequestXml(firstIp.ToString());
							WriteParsedXml(xml);
							break;
						case '2':
							WriteParsedXml(WhoisOperator.RequestXml(query.Substring(2)));
							break;
						default:
							Console.WriteLine("Wrong type");
							break;
					}
				}
				catch (Exception f)
				{
					Console.WriteLine(f.Message);
				}
			}
		}
	}
}
