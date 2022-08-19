public class PersistantPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6455
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> unlockedItems; // 0x18
	public int protocolVersion; // 0x20

	// Methods

	// RVA: 0x1EA1280 Offset: 0x1EA0680 VA: 0x181EA1280
	public static void ResetToPool(PersistantPlayer instance) { }

	// RVA: 0x1EA1190 Offset: 0x1EA0590 VA: 0x181EA1190
	public void ResetToPool() { }

	// RVA: 0x1EA0FE0 Offset: 0x1EA03E0 VA: 0x181EA0FE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA0210 Offset: 0x1E9F610 VA: 0x181EA0210
	public void CopyTo(PersistantPlayer instance) { }

	// RVA: 0x1EA0330 Offset: 0x1E9F730 VA: 0x181EA0330
	public PersistantPlayer Copy() { }

	// RVA: 0x1EA0D40 Offset: 0x1EA0140 VA: 0x181EA0D40
	public static PersistantPlayer Deserialize(Stream stream) { }

	// RVA: 0x1EA04A0 Offset: 0x1E9F8A0 VA: 0x181EA04A0
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA0AB0 Offset: 0x1E9FEB0 VA: 0x181EA0AB0
	public static PersistantPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA0DC0 Offset: 0x1EA01C0 VA: 0x181EA0DC0
	public static PersistantPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1EA1150 Offset: 0x1EA0550 VA: 0x181EA1150
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA18C0 Offset: 0x1EA0CC0 VA: 0x181EA18C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA18E0 Offset: 0x1EA0CE0 VA: 0x181EA18E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PersistantPlayer previous) { }

	// RVA: 0x1EA1170 Offset: 0x1EA0570 VA: 0x181EA1170 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA0EE0 Offset: 0x1EA02E0 VA: 0x181EA0EE0
	public static PersistantPlayer Deserialize(byte[] buffer, PersistantPlayer instance, bool isDelta = False) { }

	// RVA: 0x1EA0B40 Offset: 0x1E9FF40 VA: 0x181EA0B40
	public static PersistantPlayer Deserialize(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA0520 Offset: 0x1E9F920 VA: 0x181EA0520
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA07F0 Offset: 0x1E9FBF0 VA: 0x181EA07F0
	public static PersistantPlayer DeserializeLength(Stream stream, int length, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA1370 Offset: 0x1EA0770 VA: 0x181EA1370
	public static void SerializeDelta(Stream stream, PersistantPlayer instance, PersistantPlayer previous) { }

	// RVA: 0x1EA1700 Offset: 0x1EA0B00 VA: 0x181EA1700
	public static void Serialize(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1EA18B0 Offset: 0x1EA0CB0 VA: 0x181EA18B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA18C0 Offset: 0x1EA0CC0 VA: 0x181EA18C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA15F0 Offset: 0x1EA09F0 VA: 0x181EA15F0
	public static byte[] SerializeToBytes(PersistantPlayer instance) { }

	// RVA: 0x1EA1540 Offset: 0x1EA0940 VA: 0x181EA1540
	public static void SerializeLengthDelimited(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

