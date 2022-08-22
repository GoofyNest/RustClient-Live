public class ValidationEventArgs : EventArgs // TypeDefIndex: 2287
{	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }


	internal void .ctor(XmlSchemaException ex) { }

	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	public XmlSeverityType get_Severity() { }

	public XmlSchemaException get_Exception() { }

}

