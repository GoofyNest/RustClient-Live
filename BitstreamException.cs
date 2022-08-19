public class BitstreamException : MP3SharpException // TypeDefIndex: 7385
{	// Fields
	private int _ErrorCode; // 0x88

	// Properties
	internal virtual int ErrorCode { get; }

	// Methods

	// RVA: 0x5F4440 Offset: 0x5F3840 VA: 0x1805F4440
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x5F4500 Offset: 0x5F3900 VA: 0x1805F4500
	internal void .ctor(int errorcode, Exception inner) { }

	// RVA: 0x5F4470 Offset: 0x5F3870 VA: 0x1805F4470
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0 Slot: 12
	internal virtual int get_ErrorCode() { }

	// RVA: 0x5F4380 Offset: 0x5F3780 VA: 0x1805F4380 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5F4430 Offset: 0x5F3830 VA: 0x1805F4430
	private void InitBlock() { }

	// RVA: 0x5F4310 Offset: 0x5F3710 VA: 0x1805F4310
	internal static string GetErrorString(int errorcode) { }

}

