internal class DomNameTable // TypeDefIndex: 1946
{	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x12DEC90 Offset: 0x12DE090 VA: 0x1812DEC90
	public void .ctor(XmlDocument document) { }

	// RVA: 0x12DE9D0 Offset: 0x12DDDD0 VA: 0x1812DE9D0
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12DE5A0 Offset: 0x12DD9A0 VA: 0x1812DE5A0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12DEB30 Offset: 0x12DDF30 VA: 0x1812DEB30
	private void Grow() { }

}

