public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 1212
{	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }


	public void .ctor() { }

	public override bool get_UseAttribute() { }

	public override string get_XmlNamespace() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

