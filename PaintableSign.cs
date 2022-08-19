public class PaintableSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> crcs; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1F8C460 Offset: 0x1F8B860 VA: 0x181F8C460
	public static void ResetToPool(PaintableSign instance) { }

	// RVA: 0x1F8C310 Offset: 0x1F8B710 VA: 0x181F8C310
	public void ResetToPool() { }

	// RVA: 0x1F8C110 Offset: 0x1F8B510 VA: 0x181F8C110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8B240 Offset: 0x1F8A640 VA: 0x181F8B240
	public void CopyTo(PaintableSign instance) { }

	// RVA: 0x1F8B440 Offset: 0x1F8A840 VA: 0x181F8B440
	public PaintableSign Copy() { }

	// RVA: 0x1F8BE40 Offset: 0x1F8B240 VA: 0x181F8BE40
	public static PaintableSign Deserialize(Stream stream) { }

	// RVA: 0x1F8B7F0 Offset: 0x1F8ABF0 VA: 0x181F8B7F0
	public static PaintableSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8B870 Offset: 0x1F8AC70 VA: 0x181F8B870
	public static PaintableSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8BD20 Offset: 0x1F8B120 VA: 0x181F8BD20
	public static PaintableSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F8C2D0 Offset: 0x1F8B6D0 VA: 0x181F8C2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8CB40 Offset: 0x1F8BF40 VA: 0x181F8CB40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8CB60 Offset: 0x1F8BF60 VA: 0x181F8CB60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintableSign previous) { }

	// RVA: 0x1F8C2F0 Offset: 0x1F8B6F0 VA: 0x181F8C2F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8BC20 Offset: 0x1F8B020 VA: 0x181F8BC20
	public static PaintableSign Deserialize(byte[] buffer, PaintableSign instance, bool isDelta = False) { }

	// RVA: 0x1F8BEC0 Offset: 0x1F8B2C0 VA: 0x181F8BEC0
	public static PaintableSign Deserialize(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F8B4C0 Offset: 0x1F8A8C0 VA: 0x181F8B4C0
	public static PaintableSign DeserializeLengthDelimited(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F8B900 Offset: 0x1F8AD00 VA: 0x181F8B900
	public static PaintableSign DeserializeLength(Stream stream, int length, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F8C5B0 Offset: 0x1F8B9B0 VA: 0x181F8C5B0
	public static void SerializeDelta(Stream stream, PaintableSign instance, PaintableSign previous) { }

	// RVA: 0x1F8C950 Offset: 0x1F8BD50 VA: 0x181F8C950
	public static void Serialize(Stream stream, PaintableSign instance) { }

	// RVA: 0x1F8CB30 Offset: 0x1F8BF30 VA: 0x181F8CB30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8CB40 Offset: 0x1F8BF40 VA: 0x181F8CB40
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8C840 Offset: 0x1F8BC40 VA: 0x181F8C840
	public static byte[] SerializeToBytes(PaintableSign instance) { }

	// RVA: 0x1F8C790 Offset: 0x1F8BB90 VA: 0x181F8C790
	public static void SerializeLengthDelimited(Stream stream, PaintableSign instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

