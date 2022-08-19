public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x2138A40 Offset: 0x2137E40 VA: 0x182138A40
	public void .ctor() { }

	// RVA: 0x2138A10 Offset: 0x2137E10 VA: 0x182138A10
	public void .ctor(string message) { }

	// RVA: 0x2138AA0 Offset: 0x2137EA0 VA: 0x182138AA0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2138650 Offset: 0x2137A50 VA: 0x182138650
	private void SetMessageField() { }

	// RVA: 0x21387C0 Offset: 0x2137BC0 VA: 0x1821387C0
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x2138850 Offset: 0x2137C50 VA: 0x182138850
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x21388F0 Offset: 0x2137CF0 VA: 0x1821388F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x21384D0 Offset: 0x21378D0 VA: 0x1821384D0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

