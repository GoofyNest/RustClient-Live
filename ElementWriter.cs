internal struct ElementWriter // TypeDefIndex: 5838
{	// Fields
	private XmlWriter writer; // 0x0
	private NamespaceResolver resolver; // 0x8

	// Methods

	// RVA: 0x237410 Offset: 0x236810 VA: 0x180237410
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x237370 Offset: 0x236770 VA: 0x180237370
	public void WriteElement(XElement e) { }

	// RVA: 0x237340 Offset: 0x236740 VA: 0x180237340
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x237350 Offset: 0x236750 VA: 0x180237350
	private void PushAncestors(XElement e) { }

	// RVA: 0x237360 Offset: 0x236760 VA: 0x180237360
	private void PushElement(XElement e) { }

	// RVA: 0x237380 Offset: 0x236780 VA: 0x180237380
	private void WriteEndElement() { }

	// RVA: 0x2373C0 Offset: 0x2367C0 VA: 0x1802373C0
	private void WriteFullEndElement() { }

	// RVA: 0x237400 Offset: 0x236800 VA: 0x180237400
	private void WriteStartElement(XElement e) { }

}

