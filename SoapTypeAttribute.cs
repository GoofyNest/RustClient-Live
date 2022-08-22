public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 1214
{	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }


	public void .ctor() { }

	public override bool get_UseAttribute() { }

	public string get_XmlElementName() { }

	public override string get_XmlNamespace() { }

	public string get_XmlTypeName() { }

	public string get_XmlTypeNamespace() { }

	internal bool get_IsInteropXmlElement() { }

	internal bool get_IsInteropXmlType() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

