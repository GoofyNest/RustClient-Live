public class ValidationEventArgs : EventArgs // TypeDefIndex: 2287
{	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0xEECD20 Offset: 0xEEC120 VA: 0x180EECD20
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0xEECCA0 Offset: 0xEEC0A0 VA: 0x180EECCA0
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public XmlSeverityType get_Severity() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlSchemaException get_Exception() { }

}

