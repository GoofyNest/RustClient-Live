public class MapNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6460
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteType; // 0x14
	public Vector3 worldPosition; // 0x18

	// Methods

	// RVA: 0x1F3C140 Offset: 0x1F3B540 VA: 0x181F3C140
	public static void ResetToPool(MapNote instance) { }

	// RVA: 0x1F3C0B0 Offset: 0x1F3B4B0 VA: 0x181F3C0B0
	public void ResetToPool() { }

	// RVA: 0x1F3BFF0 Offset: 0x1F3B3F0 VA: 0x181F3BFF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF7F00 Offset: 0x1BF7300 VA: 0x181BF7F00
	public void CopyTo(MapNote instance) { }

	// RVA: 0x1F3B5A0 Offset: 0x1F3A9A0 VA: 0x181F3B5A0
	public MapNote Copy() { }

	// RVA: 0x1F3BD50 Offset: 0x1F3B150 VA: 0x181F3BD50
	public static MapNote Deserialize(Stream stream) { }

	// RVA: 0x1F3B880 Offset: 0x1F3AC80 VA: 0x181F3B880
	public static MapNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3BB30 Offset: 0x1F3AF30 VA: 0x181F3BB30
	public static MapNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3BED0 Offset: 0x1F3B2D0 VA: 0x181F3BED0
	public static MapNote Deserialize(byte[] buffer) { }

	// RVA: 0x1F3C070 Offset: 0x1F3B470 VA: 0x181F3C070
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3C7D0 Offset: 0x1F3BBD0 VA: 0x181F3C7D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3C7F0 Offset: 0x1F3BBF0 VA: 0x181F3C7F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNote previous) { }

	// RVA: 0x1F3C090 Offset: 0x1F3B490 VA: 0x181F3C090 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3BDD0 Offset: 0x1F3B1D0 VA: 0x181F3BDD0
	public static MapNote Deserialize(byte[] buffer, MapNote instance, bool isDelta = False) { }

	// RVA: 0x1F3BBC0 Offset: 0x1F3AFC0 VA: 0x181F3BBC0
	public static MapNote Deserialize(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F3B620 Offset: 0x1F3AA20 VA: 0x181F3B620
	public static MapNote DeserializeLengthDelimited(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F3B900 Offset: 0x1F3AD00 VA: 0x181F3B900
	public static MapNote DeserializeLength(Stream stream, int length, MapNote instance, bool isDelta) { }

	// RVA: 0x1F3C1D0 Offset: 0x1F3B5D0 VA: 0x181F3C1D0
	public static void SerializeDelta(Stream stream, MapNote instance, MapNote previous) { }

	// RVA: 0x1F3C620 Offset: 0x1F3BA20 VA: 0x181F3C620
	public static void Serialize(Stream stream, MapNote instance) { }

	// RVA: 0x1F3C7C0 Offset: 0x1F3BBC0 VA: 0x181F3C7C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3C7D0 Offset: 0x1F3BBD0 VA: 0x181F3C7D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3C510 Offset: 0x1F3B910 VA: 0x181F3C510
	public static byte[] SerializeToBytes(MapNote instance) { }

	// RVA: 0x1F3C460 Offset: 0x1F3B860 VA: 0x181F3C460
	public static void SerializeLengthDelimited(Stream stream, MapNote instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

