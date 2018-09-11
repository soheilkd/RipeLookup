using System.Net;
using System.Text;

namespace RipeLookup
{
	public static class WhoisOperator
	{
		public static string RequestXml(string query)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://rest.db.ripe.net/search?query-string={query}");
			request.Method = WebRequestMethods.Http.Get;
			request.Accept = "application/xml";
			request.Timeout = 10000;
			HttpWebResponse response = null;
			response = (HttpWebResponse)request.GetResponse();

			System.IO.Stream stream = response.GetResponseStream();
			int currentByte = 0;
			if (response.ContentLength <= 0)
				throw new HttpListenerException(100);
			byte[] bytes = new byte[response.ContentLength];
			int i = 0;
			while (true)
			{
				currentByte = stream.ReadByte();
				if (currentByte == -1)
					break;
				bytes[i++] = (byte)currentByte;
			}
			return Encoding.UTF8.GetString(bytes);
		}
	}
}
