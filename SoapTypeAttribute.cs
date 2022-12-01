public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 1214
{
	private bool _useAttribute;
	private string _xmlElementName;
	private string _xmlNamespace;
	private string _xmlTypeName;
	private string _xmlTypeNamespace;
	private bool _isType;
	private bool _isElement;

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

