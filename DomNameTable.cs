internal class DomNameTable // TypeDefIndex: 1946
{
	private XmlName[] entries; 
	private int count; 
	private int mask; 
	private XmlDocument ownerDocument; 
	private XmlNameTable nameTable; 


public void .ctor(XmlDocument document) { }

public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

private void Grow() { }

}

