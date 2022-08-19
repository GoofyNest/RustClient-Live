public class RadioList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6505
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<string> stationUrls; // 0x18
	public List<string> stationNames; // 0x20

	// Methods

	// RVA: 0x204BE90 Offset: 0x204B290 VA: 0x18204BE90
	public static void ResetToPool(RadioList instance) { }

	// RVA: 0x204BFE0 Offset: 0x204B3E0 VA: 0x18204BFE0
	public void ResetToPool() { }

	// RVA: 0x204BC90 Offset: 0x204B090 VA: 0x18204BC90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204AE90 Offset: 0x204A290 VA: 0x18204AE90
	public void CopyTo(RadioList instance) { }

	// RVA: 0x204B090 Offset: 0x204A490 VA: 0x18204B090
	public RadioList Copy() { }

	// RVA: 0x204B8E0 Offset: 0x204ACE0 VA: 0x18204B8E0
	public static RadioList Deserialize(Stream stream) { }

	// RVA: 0x204B110 Offset: 0x204A510 VA: 0x18204B110
	public static RadioList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204B750 Offset: 0x204AB50 VA: 0x18204B750
	public static RadioList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204B960 Offset: 0x204AD60 VA: 0x18204B960
	public static RadioList Deserialize(byte[] buffer) { }

	// RVA: 0x204BE50 Offset: 0x204B250 VA: 0x18204BE50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204C6E0 Offset: 0x204BAE0 VA: 0x18204C6E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204C700 Offset: 0x204BB00 VA: 0x18204C700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RadioList previous) { }

	// RVA: 0x204BE70 Offset: 0x204B270 VA: 0x18204BE70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204B7E0 Offset: 0x204ABE0 VA: 0x18204B7E0
	public static RadioList Deserialize(byte[] buffer, RadioList instance, bool isDelta = False) { }

	// RVA: 0x204BA80 Offset: 0x204AE80 VA: 0x18204BA80
	public static RadioList Deserialize(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x204B190 Offset: 0x204A590 VA: 0x18204B190
	public static RadioList DeserializeLengthDelimited(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x204B480 Offset: 0x204A880 VA: 0x18204B480
	public static RadioList DeserializeLength(Stream stream, int length, RadioList instance, bool isDelta) { }

	// RVA: 0x204C130 Offset: 0x204B530 VA: 0x18204C130
	public static void SerializeDelta(Stream stream, RadioList instance, RadioList previous) { }

	// RVA: 0x204C4E0 Offset: 0x204B8E0 VA: 0x18204C4E0
	public static void Serialize(Stream stream, RadioList instance) { }

	// RVA: 0x204C6D0 Offset: 0x204BAD0 VA: 0x18204C6D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x204C6E0 Offset: 0x204BAE0 VA: 0x18204C6E0
	public void ToProto(Stream stream) { }

	// RVA: 0x204C3D0 Offset: 0x204B7D0 VA: 0x18204C3D0
	public static byte[] SerializeToBytes(RadioList instance) { }

	// RVA: 0x204C320 Offset: 0x204B720 VA: 0x18204C320
	public static void SerializeLengthDelimited(Stream stream, RadioList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

