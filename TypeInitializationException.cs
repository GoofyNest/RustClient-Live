public sealed class TypeInitializationException : SystemException // TypeDefIndex: 324
{	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x2138390 Offset: 0x2137790 VA: 0x182138390
	private void .ctor() { }

	// RVA: 0x2138280 Offset: 0x2137680 VA: 0x182138280
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x21383F0 Offset: 0x21377F0 VA: 0x1821383F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2138480 Offset: 0x2137880 VA: 0x182138480
	public string get_TypeName() { }

	// RVA: 0x2138140 Offset: 0x2137540 VA: 0x182138140 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

