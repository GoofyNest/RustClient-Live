public class TreeList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Tree> trees; // 0x18

	// Methods

	// RVA: 0x1EEE4E0 Offset: 0x1EED8E0 VA: 0x181EEE4E0
	public static void ResetToPool(TreeList instance) { }

	// RVA: 0x1EEE330 Offset: 0x1EED730 VA: 0x181EEE330
	public void ResetToPool() { }

	// RVA: 0x1EEE0B0 Offset: 0x1EED4B0 VA: 0x181EEE0B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EED200 Offset: 0x1EEC600 VA: 0x181EED200
	public void CopyTo(TreeList instance) { }

	// RVA: 0x1EED3A0 Offset: 0x1EEC7A0 VA: 0x181EED3A0
	public TreeList Copy() { }

	// RVA: 0x1EEDD20 Offset: 0x1EED120 VA: 0x181EEDD20
	public static TreeList Deserialize(Stream stream) { }

	// RVA: 0x1EED870 Offset: 0x1EECC70 VA: 0x181EED870
	public static TreeList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEDB90 Offset: 0x1EECF90 VA: 0x181EEDB90
	public static TreeList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEDF90 Offset: 0x1EED390 VA: 0x181EEDF90
	public static TreeList Deserialize(byte[] buffer) { }

	// RVA: 0x1EEE2F0 Offset: 0x1EED6F0 VA: 0x181EEE2F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEEC20 Offset: 0x1EEE020 VA: 0x181EEEC20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEEC40 Offset: 0x1EEE040 VA: 0x181EEEC40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TreeList previous) { }

	// RVA: 0x1EEE310 Offset: 0x1EED710 VA: 0x181EEE310 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEDC20 Offset: 0x1EED020 VA: 0x181EEDC20
	public static TreeList Deserialize(byte[] buffer, TreeList instance, bool isDelta = False) { }

	// RVA: 0x1EEDDA0 Offset: 0x1EED1A0 VA: 0x181EEDDA0
	public static TreeList Deserialize(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EED5A0 Offset: 0x1EEC9A0 VA: 0x181EED5A0
	public static TreeList DeserializeLengthDelimited(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EED8F0 Offset: 0x1EECCF0 VA: 0x181EED8F0
	public static TreeList DeserializeLength(Stream stream, int length, TreeList instance, bool isDelta) { }

	// RVA: 0x1EEE690 Offset: 0x1EEDA90 VA: 0x181EEE690
	public static void SerializeDelta(Stream stream, TreeList instance, TreeList previous) { }

	// RVA: 0x1EEEA30 Offset: 0x1EEDE30 VA: 0x181EEEA30
	public static void Serialize(Stream stream, TreeList instance) { }

	// RVA: 0x1EEEC10 Offset: 0x1EEE010 VA: 0x181EEEC10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEEC20 Offset: 0x1EEE020 VA: 0x181EEEC20
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEE920 Offset: 0x1EEDD20 VA: 0x181EEE920
	public static byte[] SerializeToBytes(TreeList instance) { }

	// RVA: 0x1EEE870 Offset: 0x1EEDC70 VA: 0x181EEE870
	public static void SerializeLengthDelimited(Stream stream, TreeList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

