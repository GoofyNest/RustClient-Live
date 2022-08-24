public class ValidationEventArgs : EventArgs // TypeDefIndex: 2287
{
	private XmlSchemaException ex; 
	private XmlSeverityType severity; 

	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }


	internal void .ctor(XmlSchemaException ex) { }

	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	public XmlSeverityType get_Severity() { }

	public XmlSchemaException get_Exception() { }

}

