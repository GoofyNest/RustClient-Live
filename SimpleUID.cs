public class SimpleUID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6350
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14

	// Methods

	// RVA: 0x1E07E70 Offset: 0x1E07270 VA: 0x181E07E70
	public static void ResetToPool(SimpleUID instance) { }

	// RVA: 0x1E07EF0 Offset: 0x1E072F0 VA: 0x181E07EF0
	public void ResetToPool() { }

	// RVA: 0x1E07D40 Offset: 0x1E07140 VA: 0x181E07D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(SimpleUID instance) { }

	// RVA: 0x1E073C0 Offset: 0x1E067C0 VA: 0x181E073C0
	public SimpleUID Copy() { }

	// RVA: 0x1E07960 Offset: 0x1E06D60 VA: 0x181E07960
	public static SimpleUID Deserialize(Stream stream) { }

	// RVA: 0x1E07430 Offset: 0x1E06830 VA: 0x181E07430
	public static SimpleUID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E078D0 Offset: 0x1E06CD0 VA: 0x181E078D0
	public static SimpleUID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E07C20 Offset: 0x1E07020 VA: 0x181E07C20
	public static SimpleUID Deserialize(byte[] buffer) { }

	// RVA: 0x1E07E30 Offset: 0x1E07230 VA: 0x181E07E30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E083C0 Offset: 0x1E077C0 VA: 0x181E083C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E08490 Offset: 0x1E07890 VA: 0x181E08490 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleUID previous) { }

	// RVA: 0x1E07E50 Offset: 0x1E07250 VA: 0x181E07E50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E07B20 Offset: 0x1E06F20 VA: 0x181E07B20
	public static SimpleUID Deserialize(byte[] buffer, SimpleUID instance, bool isDelta = False) { }

	// RVA: 0x1E079E0 Offset: 0x1E06DE0 VA: 0x181E079E0
	public static SimpleUID Deserialize(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E074B0 Offset: 0x1E068B0 VA: 0x181E074B0
	public static SimpleUID DeserializeLengthDelimited(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E076D0 Offset: 0x1E06AD0 VA: 0x181E076D0
	public static SimpleUID DeserializeLength(Stream stream, int length, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E07F70 Offset: 0x1E07370 VA: 0x181E07F70
	public static void SerializeDelta(Stream stream, SimpleUID instance, SimpleUID previous) { }

	// RVA: 0x1E082E0 Offset: 0x1E076E0 VA: 0x181E082E0
	public static void Serialize(Stream stream, SimpleUID instance) { }

	// RVA: 0x1E083B0 Offset: 0x1E077B0 VA: 0x181E083B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E083C0 Offset: 0x1E077C0 VA: 0x181E083C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E08130 Offset: 0x1E07530 VA: 0x181E08130
	public static byte[] SerializeToBytes(SimpleUID instance) { }

	// RVA: 0x1E08080 Offset: 0x1E07480 VA: 0x181E08080
	public static void SerializeLengthDelimited(Stream stream, SimpleUID instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

