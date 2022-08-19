public class DudExplosive : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fuseTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E69DD0 Offset: 0x1E691D0 VA: 0x181E69DD0
	public static void ResetToPool(DudExplosive instance) { }

	// RVA: 0x1E69E50 Offset: 0x1E69250 VA: 0x181E69E50
	public void ResetToPool() { }

	// RVA: 0x1E69CA0 Offset: 0x1E690A0 VA: 0x181E69CA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(DudExplosive instance) { }

	// RVA: 0x1E69310 Offset: 0x1E68710 VA: 0x181E69310
	public DudExplosive Copy() { }

	// RVA: 0x1E699B0 Offset: 0x1E68DB0 VA: 0x181E699B0
	public static DudExplosive Deserialize(Stream stream) { }

	// RVA: 0x1E695A0 Offset: 0x1E689A0 VA: 0x181E695A0
	public static DudExplosive DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E69620 Offset: 0x1E68A20 VA: 0x181E69620
	public static DudExplosive DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E69A30 Offset: 0x1E68E30 VA: 0x181E69A30
	public static DudExplosive Deserialize(byte[] buffer) { }

	// RVA: 0x1E69D90 Offset: 0x1E69190 VA: 0x181E69D90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6A2A0 Offset: 0x1E696A0 VA: 0x181E6A2A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6A2C0 Offset: 0x1E696C0 VA: 0x181E6A2C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DudExplosive previous) { }

	// RVA: 0x1E69DB0 Offset: 0x1E691B0 VA: 0x181E69DB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E698B0 Offset: 0x1E68CB0 VA: 0x181E698B0
	public static DudExplosive Deserialize(byte[] buffer, DudExplosive instance, bool isDelta = False) { }

	// RVA: 0x1E69B50 Offset: 0x1E68F50 VA: 0x181E69B50
	public static DudExplosive Deserialize(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E69380 Offset: 0x1E68780 VA: 0x181E69380
	public static DudExplosive DeserializeLengthDelimited(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E696B0 Offset: 0x1E68AB0 VA: 0x181E696B0
	public static DudExplosive DeserializeLength(Stream stream, int length, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E69ED0 Offset: 0x1E692D0 VA: 0x181E69ED0
	public static void SerializeDelta(Stream stream, DudExplosive instance, DudExplosive previous) { }

	// RVA: 0x1E6A1B0 Offset: 0x1E695B0 VA: 0x181E6A1B0
	public static void Serialize(Stream stream, DudExplosive instance) { }

	// RVA: 0x1E6A290 Offset: 0x1E69690 VA: 0x181E6A290
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6A2A0 Offset: 0x1E696A0 VA: 0x181E6A2A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6A0A0 Offset: 0x1E694A0 VA: 0x181E6A0A0
	public static byte[] SerializeToBytes(DudExplosive instance) { }

	// RVA: 0x1E69FF0 Offset: 0x1E693F0 VA: 0x181E69FF0
	public static void SerializeLengthDelimited(Stream stream, DudExplosive instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

