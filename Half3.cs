public struct Half3 : IProto // TypeDefIndex: 6475
{	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetToPool(Half3 instance) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void CopyTo(Half3 instance) { }

	// RVA: 0xFAED0 Offset: 0xFA2D0 VA: 0x1800FAED0
	public Half3 Copy() { }

	// RVA: 0x1D5DC90 Offset: 0x1D5D090 VA: 0x181D5DC90
	public static Half3 Deserialize(Stream stream) { }

	// RVA: 0x1D5D6D0 Offset: 0x1D5CAD0 VA: 0x181D5D6D0
	public static Half3 DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5D970 Offset: 0x1D5CD70 VA: 0x181D5D970
	public static Half3 DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5DCC0 Offset: 0x1D5D0C0 VA: 0x181D5DCC0
	public static Half3 Deserialize(byte[] buffer) { }

	// RVA: 0x22E3E0 Offset: 0x22D7E0 VA: 0x18022E3E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x22E470 Offset: 0x22D870 VA: 0x18022E470 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x22E4A0 Offset: 0x22D8A0 VA: 0x18022E4A0
	public void WriteToStreamDelta(Stream stream, Half3 previous) { }

	// RVA: 0x22E410 Offset: 0x22D810 VA: 0x18022E410 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5D9A0 Offset: 0x1D5CDA0 VA: 0x181D5D9A0
	public static Half3 Deserialize(byte[] buffer, ref Half3 instance, bool isDelta = False) { }

	// RVA: 0x1D5DAD0 Offset: 0x1D5CED0 VA: 0x181D5DAD0
	public static Half3 Deserialize(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D5D430 Offset: 0x1D5C830 VA: 0x181D5D430
	public static Half3 DeserializeLengthDelimited(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D5D700 Offset: 0x1D5CB00 VA: 0x181D5D700
	public static Half3 DeserializeLength(Stream stream, int length, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D5DDC0 Offset: 0x1D5D1C0 VA: 0x181D5DDC0
	public static void SerializeDelta(Stream stream, Half3 instance, Half3 previous) { }

	// RVA: 0x1D5E180 Offset: 0x1D5D580 VA: 0x181D5E180
	public static void Serialize(Stream stream, Half3 instance) { }

	// RVA: 0x22E440 Offset: 0x22D840 VA: 0x18022E440
	public byte[] ToProtoBytes() { }

	// RVA: 0x22E470 Offset: 0x22D870 VA: 0x18022E470
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5E060 Offset: 0x1D5D460 VA: 0x181D5E060
	public static byte[] SerializeToBytes(Half3 instance) { }

	// RVA: 0x1D5DFA0 Offset: 0x1D5D3A0 VA: 0x181D5DFA0
	public static void SerializeLengthDelimited(Stream stream, Half3 instance) { }

}

public struct Half3 // TypeDefIndex: 11416
{	// Fields
	public ushort x; // 0x0
	public ushort y; // 0x2
	public ushort z; // 0x4

	// Methods

	// RVA: 0xF4DB0 Offset: 0xF41B0 VA: 0x1800F4DB0
	public void .ctor(Vector3 vec) { }

	// RVA: 0x74EA80 Offset: 0x74DE80 VA: 0x18074EA80
	public static Vector3 op_Explicit(Half3 vec) { }

}

