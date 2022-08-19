public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 280
{	// Fields
	private string objectName; // 0x88

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x167E130 Offset: 0x167D530 VA: 0x18167E130
	private void .ctor() { }

	// RVA: 0x167E240 Offset: 0x167D640 VA: 0x18167E240
	public void .ctor(string objectName) { }

	// RVA: 0x167E0D0 Offset: 0x167D4D0 VA: 0x18167E0D0
	public void .ctor(string objectName, string message) { }

	// RVA: 0x167E2D0 Offset: 0x167D6D0 VA: 0x18167E2D0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x167E430 Offset: 0x167D830 VA: 0x18167E430
	public string get_ObjectName() { }

	// RVA: 0x167E1B0 Offset: 0x167D5B0 VA: 0x18167E1B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x167DFC0 Offset: 0x167D3C0 VA: 0x18167DFC0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

