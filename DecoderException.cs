public class DecoderException : MP3SharpException // TypeDefIndex: 7390
{	// Fields
	private int _ErrorCode; // 0x88

	// Methods

	// RVA: 0x5F6580 Offset: 0x5F5980 VA: 0x1805F6580
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x5F64E0 Offset: 0x5F58E0 VA: 0x1805F64E0
	internal void .ctor(int errorcode, Exception inner) { }

	// RVA: 0x5F65B0 Offset: 0x5F59B0 VA: 0x1805F65B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5F6420 Offset: 0x5F5820 VA: 0x1805F6420 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5F64D0 Offset: 0x5F58D0 VA: 0x1805F64D0
	private void InitBlock() { }

	// RVA: 0x5F63B0 Offset: 0x5F57B0 VA: 0x1805F63B0
	internal static string GetErrorString(int errorcode) { }

}

