internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 1859
{
	private XmlRawWriter wrapped; 
	private bool inCDataSection; 
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; 
	private BitStack bitsCData; 
	private XmlQualifiedName qnameCData; 
	private bool outputDocType; 
	private bool checkWellFormedDoc; 
	private bool hasDocElem; 
	private bool inAttr; 
	private string systemId; 
	private string publicId; 
	private int depth; 

internal override IXmlNamespaceResolver NamespaceResolver { set; }
internal override bool SupportsNamespaceDeclarationInChunks { get; }


public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

internal override void WriteXmlDeclaration(string xmldecl) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

internal override void StartElementContent() { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

internal override bool get_SupportsNamespaceDeclarationInChunks() { }

internal override void WriteStartNamespaceDeclaration(string prefix) { }

internal override void WriteEndNamespaceDeclaration() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void Close() { }

public override void Flush() { }

private bool StartCDataSection() { }

private void EndCDataSection() { }

}

