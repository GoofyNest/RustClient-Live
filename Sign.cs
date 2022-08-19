public class Sign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6319
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageid; // 0x14
	public List<uint> imageIds; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1E05AF0 Offset: 0x1E04EF0 VA: 0x181E05AF0
	public static void ResetToPool(Sign instance) { }

	// RVA: 0x1E05990 Offset: 0x1E04D90 VA: 0x181E05990
	public void ResetToPool() { }

	// RVA: 0x1E05780 Offset: 0x1E04B80 VA: 0x181E05780 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E04800 Offset: 0x1E03C00 VA: 0x181E04800
	public void CopyTo(Sign instance) { }

	// RVA: 0x1E04A00 Offset: 0x1E03E00 VA: 0x181E04A00
	public Sign Copy() { }

	// RVA: 0x1E05700 Offset: 0x1E04B00 VA: 0x181E05700
	public static Sign Deserialize(Stream stream) { }

	// RVA: 0x1E04A80 Offset: 0x1E03E80 VA: 0x181E04A80
	public static Sign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E051C0 Offset: 0x1E045C0 VA: 0x181E051C0
	public static Sign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E055E0 Offset: 0x1E049E0 VA: 0x181E055E0
	public static Sign Deserialize(byte[] buffer) { }

	// RVA: 0x1E05950 Offset: 0x1E04D50 VA: 0x181E05950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E06290 Offset: 0x1E05690 VA: 0x181E06290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E062B0 Offset: 0x1E056B0 VA: 0x181E062B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Sign previous) { }

	// RVA: 0x1E05970 Offset: 0x1E04D70 VA: 0x181E05970 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E05250 Offset: 0x1E04650 VA: 0x181E05250
	public static Sign Deserialize(byte[] buffer, Sign instance, bool isDelta = False) { }

	// RVA: 0x1E05350 Offset: 0x1E04750 VA: 0x181E05350
	public static Sign Deserialize(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E04B00 Offset: 0x1E03F00 VA: 0x181E04B00
	public static Sign DeserializeLengthDelimited(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E04E70 Offset: 0x1E04270 VA: 0x181E04E70
	public static Sign DeserializeLength(Stream stream, int length, Sign instance, bool isDelta) { }

	// RVA: 0x1E05C50 Offset: 0x1E05050 VA: 0x181E05C50
	public static void SerializeDelta(Stream stream, Sign instance, Sign previous) { }

	// RVA: 0x1E06050 Offset: 0x1E05450 VA: 0x181E06050
	public static void Serialize(Stream stream, Sign instance) { }

	// RVA: 0x1E06280 Offset: 0x1E05680 VA: 0x181E06280
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E06290 Offset: 0x1E05690 VA: 0x181E06290
	public void ToProto(Stream stream) { }

	// RVA: 0x1E05F40 Offset: 0x1E05340 VA: 0x181E05F40
	public static byte[] SerializeToBytes(Sign instance) { }

	// RVA: 0x1E05E90 Offset: 0x1E05290 VA: 0x181E05E90
	public static void SerializeLengthDelimited(Stream stream, Sign instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

