internal struct ElementWriter // TypeDefIndex: 5845
{
	private XmlWriter writer; 
	private NamespaceResolver resolver; 


	public void .ctor(XmlWriter writer) { }

	public void WriteElement(XElement e) { }

	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	private void PushAncestors(XElement e) { }

	private void PushElement(XElement e) { }

	private void WriteEndElement() { }

	private void WriteFullEndElement() { }

	private void WriteStartElement(XElement e) { }

}

