using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace RipeLookup
{
	public static class Parser
	{
		public static IEnumerable<Attribute> Parse(string xml)
		{
			foreach (var item in XDocument.Parse(xml).DescendantNodes().Cast<XElement>())
			{
				if (item.Name == "attribute")
					yield return new Attribute(item);
				else if (item.Name == "object")
					yield return new Attribute(item, true);
			}
		}
	}
}