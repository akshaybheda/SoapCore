using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SoapCore.Tests.Wsdl.Services
{
	public class ComplexType
	{
		public int IntProperty { get; set; }
		[XmlElement(ElementName = "stringprop")]
		public string StringProperty { get; set; }
	}
}
