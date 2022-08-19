public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 1212
{	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x1487F60 Offset: 0x1487360 VA: 0x181487F60 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }

}

