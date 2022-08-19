public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 1214
{	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_XmlElementName() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_XmlTypeName() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_XmlTypeNamespace() { }

	// RVA: 0xE9FA80 Offset: 0xE9EE80 VA: 0x180E9FA80
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x1488160 Offset: 0x1487560 VA: 0x181488160 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }

}

