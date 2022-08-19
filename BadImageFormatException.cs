public class BadImageFormatException : SystemException // TypeDefIndex: 177
{	// Fields
	private string _fileName; // 0x88
	private string _fusionLog; // 0x90

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x158B8F0 Offset: 0x158ACF0 VA: 0x18158B8F0
	public void .ctor() { }

	// RVA: 0x158BA40 Offset: 0x158AE40 VA: 0x18158BA40
	public void .ctor(string message) { }

	// RVA: 0x158B8C0 Offset: 0x158ACC0 VA: 0x18158B8C0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x158B870 Offset: 0x158AC70 VA: 0x18158B870
	public void .ctor(string message, string fileName) { }

	// RVA: 0x158BA70 Offset: 0x158AE70 VA: 0x18158BA70 Slot: 5
	public override string get_Message() { }

	// RVA: 0x158B570 Offset: 0x158A970 VA: 0x18158B570
	private void SetMessageField() { }

	// RVA: 0x158B5F0 Offset: 0x158A9F0 VA: 0x18158B5F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x158B950 Offset: 0x158AD50 VA: 0x18158B950
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public string get_FusionLog() { }

	// RVA: 0x158B430 Offset: 0x158A830 VA: 0x18158B430 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

