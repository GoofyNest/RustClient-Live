public class Zipline : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> destinationPoints; // 0x18

	// Methods

	// RVA: 0x1E59330 Offset: 0x1E58730 VA: 0x181E59330
	public static void ResetToPool(Zipline instance) { }

	// RVA: 0x1E59250 Offset: 0x1E58650 VA: 0x181E59250
	public void ResetToPool() { }

	// RVA: 0x1E590C0 Offset: 0x1E584C0 VA: 0x181E590C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E58350 Offset: 0x1E57750 VA: 0x181E58350
	public void CopyTo(Zipline instance) { }

	// RVA: 0x1E584B0 Offset: 0x1E578B0 VA: 0x181E584B0
	public Zipline Copy() { }

	// RVA: 0x1E58C70 Offset: 0x1E58070 VA: 0x181E58C70
	public static Zipline Deserialize(Stream stream) { }

	// RVA: 0x1E58670 Offset: 0x1E57A70 VA: 0x181E58670
	public static Zipline DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E58970 Offset: 0x1E57D70 VA: 0x181E58970
	public static Zipline DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E58CF0 Offset: 0x1E580F0 VA: 0x181E58CF0
	public static Zipline Deserialize(byte[] buffer) { }

	// RVA: 0x1E59210 Offset: 0x1E58610 VA: 0x181E59210
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E59AF0 Offset: 0x1E58EF0 VA: 0x181E59AF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E59B10 Offset: 0x1E58F10 VA: 0x181E59B10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Zipline previous) { }

	// RVA: 0x1E59230 Offset: 0x1E58630 VA: 0x181E59230 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E58FC0 Offset: 0x1E583C0 VA: 0x181E58FC0
	public static Zipline Deserialize(byte[] buffer, Zipline instance, bool isDelta = False) { }

	// RVA: 0x1E58E10 Offset: 0x1E58210 VA: 0x181E58E10
	public static Zipline Deserialize(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E586F0 Offset: 0x1E57AF0 VA: 0x181E586F0
	public static Zipline DeserializeLengthDelimited(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E58A00 Offset: 0x1E57E00 VA: 0x181E58A00
	public static Zipline DeserializeLength(Stream stream, int length, Zipline instance, bool isDelta) { }

	// RVA: 0x1E59410 Offset: 0x1E58810 VA: 0x181E59410
	public static void SerializeDelta(Stream stream, Zipline instance, Zipline previous) { }

	// RVA: 0x1E59890 Offset: 0x1E58C90 VA: 0x181E59890
	public static void Serialize(Stream stream, Zipline instance) { }

	// RVA: 0x1E59AE0 Offset: 0x1E58EE0 VA: 0x181E59AE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E59AF0 Offset: 0x1E58EF0 VA: 0x181E59AF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E59780 Offset: 0x1E58B80 VA: 0x181E59780
	public static byte[] SerializeToBytes(Zipline instance) { }

	// RVA: 0x1E59690 Offset: 0x1E58A90 VA: 0x181E59690
	public static void SerializeLengthDelimited(Stream stream, Zipline instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

