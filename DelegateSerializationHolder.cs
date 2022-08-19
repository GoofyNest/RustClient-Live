internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 357
{	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0xD6BE70 Offset: 0xD6B270 VA: 0x180D6BE70
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD6BC00 Offset: 0xD6B000 VA: 0x180D6BC00
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0xD6BE20 Offset: 0xD6B220 VA: 0x180D6BE20 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 5
	public object GetRealObject(StreamingContext context) { }

}

private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 358
{	// Fields
	private string type; // 0x10
	private string assembly; // 0x18
	private object target; // 0x20
	private string targetTypeAssembly; // 0x28
	private string targetTypeName; // 0x30
	private string methodName; // 0x38
	public DelegateSerializationHolder.DelegateEntry delegateEntry; // 0x40

	// Methods

	// RVA: 0xD6BA10 Offset: 0xD6AE10 VA: 0x180D6BA10
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0xD6B670 Offset: 0xD6AA70 VA: 0x180D6B670
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

}

