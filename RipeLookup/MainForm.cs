using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RipeLookup
{
	public partial class MainForm : Form
	{
		IPAddress[] DNS;

		public MainForm() => InitializeComponent();

		private void DNSLookupRequest_Click(object sender, EventArgs e)
		{
			LookupDNS();
			if (DNS.Length >= 1)
			{
				XMLBox.Text = Get("xml");
				JSONBox.Text = Get("json");
				tabControl1.SelectedIndex = 0;
			}
		}

		private string Get(string type)
		{
			HttpWebRequest request =
				(HttpWebRequest)WebRequest.Create($"http://rest.db.ripe.net/search?query-string=" +
												  $"{DNS.First() ?? new IPAddress(new byte[] { 0, 0, 0, 0 })}");

			request.Method = WebRequestMethods.Http.Get;
			request.Accept = "application/" + type;
			request.Timeout = 10000;
			HttpWebResponse response = null;
			try
			{
				response = (HttpWebResponse)request.GetResponse();
			}
			catch (Exception f)
			{
				return f.Message;
			}

			var stream = response.GetResponseStream();
			int currentByte = 0;
			if (response.ContentLength <= 0)
				return "Error Occurred, HTTP Response returned empty";
			byte[] bytes = new byte[response.ContentLength];
			int i = 0;
			while (true)
			{
				currentByte = stream.ReadByte();
				if (currentByte == -1)
					break;
				bytes[i++] = (byte)currentByte;
			}
			var text = Encoding.UTF8.GetString(bytes);
			return text.Replace("\n", "\r\n");
		}

		private void LookupDNS()
		{
			try
			{
				DNS = new IPAddress[0];
				DNS = Dns.GetHostAddresses(DNSBox.Text);
				DNSResultBox.AppendLine("Found these for " + DNSBox.Text + ":");
				foreach (var item in DNS)
					DNSResultBox.AppendLine(item.ToString() + "\r\n");
				tabControl1.SelectedIndex = 2;
			}
			catch (Exception f)
			{
				DNSResultBox.AppendLine(f.Message);
			}
		}
	}

	public static class Extensions
	{
		public static void AppendLine(this TextBox textBox, string text)
			=> textBox.AppendText(text + "\r\n");
	}
}