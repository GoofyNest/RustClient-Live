public class PaintedItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6429
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageCrc; // 0x14
	public ulong editedBy; // 0x18

	// Methods

	// RVA: 0x1F8DC50 Offset: 0x1F8D050 VA: 0x181F8DC50
	public static void ResetToPool(PaintedItem instance) { }

	// RVA: 0x1F8DCD0 Offset: 0x1F8D0D0 VA: 0x181F8DCD0
	public void ResetToPool() { }

	// RVA: 0x1F8D9B0 Offset: 0x1F8CDB0 VA: 0x181F8D9B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8CB80 Offset: 0x1F8BF80 VA: 0x181F8CB80
	public void CopyTo(PaintedItem instance) { }

	// RVA: 0x1F8CBB0 Offset: 0x1F8BFB0 VA: 0x181F8CBB0
	public PaintedItem Copy() { }

	// RVA: 0x1F8D7F0 Offset: 0x1F8CBF0 VA: 0x181F8D7F0
	public static PaintedItem Deserialize(Stream stream) { }

	// RVA: 0x1F8CE70 Offset: 0x1F8C270 VA: 0x181F8CE70
	public static PaintedItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8CEF0 Offset: 0x1F8C2F0 VA: 0x181F8CEF0
	public static PaintedItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8D580 Offset: 0x1F8C980 VA: 0x181F8D580
	public static PaintedItem Deserialize(byte[] buffer) { }

	// RVA: 0x1F8DAB0 Offset: 0x1F8CEB0 VA: 0x181F8DAB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8E190 Offset: 0x1F8D590 VA: 0x181F8E190 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8E1B0 Offset: 0x1F8D5B0 VA: 0x181F8E1B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintedItem previous) { }

	// RVA: 0x1F8DC30 Offset: 0x1F8D030 VA: 0x181F8DC30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8D1B0 Offset: 0x1F8C5B0 VA: 0x181F8D1B0
	public static PaintedItem Deserialize(byte[] buffer, PaintedItem instance, bool isDelta = False) { }

	// RVA: 0x1F8D400 Offset: 0x1F8C800 VA: 0x181F8D400
	public static PaintedItem Deserialize(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F8CC20 Offset: 0x1F8C020 VA: 0x181F8CC20
	public static PaintedItem DeserializeLengthDelimited(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F8CF80 Offset: 0x1F8C380 VA: 0x181F8CF80
	public static PaintedItem DeserializeLength(Stream stream, int length, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F8DD50 Offset: 0x1F8D150 VA: 0x181F8DD50
	public static void SerializeDelta(Stream stream, PaintedItem instance, PaintedItem previous) { }

	// RVA: 0x1F8E080 Offset: 0x1F8D480 VA: 0x181F8E080
	public static void Serialize(Stream stream, PaintedItem instance) { }

	// RVA: 0x1F8E180 Offset: 0x1F8D580 VA: 0x181F8E180
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8E190 Offset: 0x1F8D590 VA: 0x181F8E190
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8DF70 Offset: 0x1F8D370 VA: 0x181F8DF70
	public static byte[] SerializeToBytes(PaintedItem instance) { }

	// RVA: 0x1F8DEC0 Offset: 0x1F8D2C0 VA: 0x181F8DEC0
	public static void SerializeLengthDelimited(Stream stream, PaintedItem instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

