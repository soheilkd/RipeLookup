using System.Xml.Linq;

namespace RipeLookup
{
	public class Attribute
	{
		public string Name { get; set; }
		public string Value { get; set; }

		private Attribute() { }
		public Attribute(XElement element, bool isObject = false)
		{
			if (!isObject)
			{
				Name = element.Attribute("name").Value;
				Value = element.Attribute("value").Value;
			}
			else
			{
				Name = element.Attribute("type").Value;
				Value = "";
			}
		}

		public override string ToString() => $"{Name}: {Value}";
	}
}
