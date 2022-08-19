public class TakeDamage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6480
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float amount; // 0x14
	public Vector3 direction; // 0x18
	public int type; // 0x24

	// Methods

	// RVA: 0x1DC1270 Offset: 0x1DC0670 VA: 0x181DC1270
	public static void ResetToPool(TakeDamage instance) { }

	// RVA: 0x1DC11D0 Offset: 0x1DC05D0 VA: 0x181DC11D0
	public void ResetToPool() { }

	// RVA: 0x1DC0EC0 Offset: 0x1DC02C0 VA: 0x181DC0EC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBFF10 Offset: 0x1DBF310 VA: 0x181DBFF10
	public void CopyTo(TakeDamage instance) { }

	// RVA: 0x1DBFF40 Offset: 0x1DBF340 VA: 0x181DBFF40
	public TakeDamage Copy() { }

	// RVA: 0x1DC0CC0 Offset: 0x1DC00C0 VA: 0x181DC0CC0
	public static TakeDamage Deserialize(Stream stream) { }

	// RVA: 0x1DC0250 Offset: 0x1DBF650 VA: 0x181DC0250
	public static TakeDamage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC02D0 Offset: 0x1DBF6D0 VA: 0x181DC02D0
	public static TakeDamage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC07A0 Offset: 0x1DBFBA0 VA: 0x181DC07A0
	public static TakeDamage Deserialize(byte[] buffer) { }

	// RVA: 0x1DC0FE0 Offset: 0x1DC03E0 VA: 0x181DC0FE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC19B0 Offset: 0x1DC0DB0 VA: 0x181DC19B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC19D0 Offset: 0x1DC0DD0 VA: 0x181DC19D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TakeDamage previous) { }

	// RVA: 0x1DC11B0 Offset: 0x1DC05B0 VA: 0x181DC11B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC0A40 Offset: 0x1DBFE40 VA: 0x181DC0A40
	public static TakeDamage Deserialize(byte[] buffer, TakeDamage instance, bool isDelta = False) { }

	// RVA: 0x1DC05D0 Offset: 0x1DBF9D0 VA: 0x181DC05D0
	public static TakeDamage Deserialize(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DBFFC0 Offset: 0x1DBF3C0 VA: 0x181DBFFC0
	public static TakeDamage DeserializeLengthDelimited(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC0360 Offset: 0x1DBF760 VA: 0x181DC0360
	public static TakeDamage DeserializeLength(Stream stream, int length, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC1310 Offset: 0x1DC0710 VA: 0x181DC1310
	public static void SerializeDelta(Stream stream, TakeDamage instance, TakeDamage previous) { }

	// RVA: 0x1DC17D0 Offset: 0x1DC0BD0 VA: 0x181DC17D0
	public static void Serialize(Stream stream, TakeDamage instance) { }

	// RVA: 0x1DC19A0 Offset: 0x1DC0DA0 VA: 0x181DC19A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC19B0 Offset: 0x1DC0DB0 VA: 0x181DC19B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC16C0 Offset: 0x1DC0AC0 VA: 0x181DC16C0
	public static byte[] SerializeToBytes(TakeDamage instance) { }

	// RVA: 0x1DC1610 Offset: 0x1DC0A10 VA: 0x181DC1610
	public static void SerializeLengthDelimited(Stream stream, TakeDamage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

