public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 272
{	// Fields
	private string signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1671210 Offset: 0x1670610 VA: 0x181671210
	public void .ctor() { }

	// RVA: 0x1671290 Offset: 0x1670690 VA: 0x181671290
	public void .ctor(string message) { }

	// RVA: 0x1670A60 Offset: 0x166FE60 VA: 0x181670A60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16712E0 Offset: 0x16706E0 VA: 0x1816712E0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1670AD0 Offset: 0x166FED0 VA: 0x181670AD0
	public void .ctor(string className, string methodName) { }

	// RVA: 0x1671170 Offset: 0x1670570 VA: 0x181671170
	private void .ctor(string className, string methodName, string signature, string message) { }

}

