public class StorageBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6311
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1DBBA10 Offset: 0x1DBAE10 VA: 0x181DBBA10
	public static void ResetToPool(StorageBox instance) { }

	// RVA: 0x1DBBAB0 Offset: 0x1DBAEB0 VA: 0x181DBBAB0
	public void ResetToPool() { }

	// RVA: 0x1DBB8B0 Offset: 0x1DBACB0 VA: 0x181DBB8B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBAE10 Offset: 0x1DBA210 VA: 0x181DBAE10
	public void CopyTo(StorageBox instance) { }

	// RVA: 0x1DBAE80 Offset: 0x1DBA280 VA: 0x181DBAE80
	public StorageBox Copy() { }

	// RVA: 0x1DBB730 Offset: 0x1DBAB30 VA: 0x181DBB730
	public static StorageBox Deserialize(Stream stream) { }

	// RVA: 0x1DBAF50 Offset: 0x1DBA350 VA: 0x181DBAF50
	public static StorageBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBB210 Offset: 0x1DBA610 VA: 0x181DBB210
	public static StorageBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBB4B0 Offset: 0x1DBA8B0 VA: 0x181DBB4B0
	public static StorageBox Deserialize(byte[] buffer) { }

	// RVA: 0x1DBB9D0 Offset: 0x1DBADD0 VA: 0x181DBB9D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBC040 Offset: 0x1DBB440 VA: 0x181DBC040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBC060 Offset: 0x1DBB460 VA: 0x181DBC060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StorageBox previous) { }

	// RVA: 0x1DBB9F0 Offset: 0x1DBADF0 VA: 0x181DBB9F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBB7B0 Offset: 0x1DBABB0 VA: 0x181DBB7B0
	public static StorageBox Deserialize(byte[] buffer, StorageBox instance, bool isDelta = False) { }

	// RVA: 0x1DBB5D0 Offset: 0x1DBA9D0 VA: 0x181DBB5D0
	public static StorageBox Deserialize(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DBAFD0 Offset: 0x1DBA3D0 VA: 0x181DBAFD0
	public static StorageBox DeserializeLengthDelimited(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DBB2A0 Offset: 0x1DBA6A0 VA: 0x181DBB2A0
	public static StorageBox DeserializeLength(Stream stream, int length, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DBBB50 Offset: 0x1DBAF50 VA: 0x181DBBB50
	public static void SerializeDelta(Stream stream, StorageBox instance, StorageBox previous) { }

	// RVA: 0x1DBBEB0 Offset: 0x1DBB2B0 VA: 0x181DBBEB0
	public static void Serialize(Stream stream, StorageBox instance) { }

	// RVA: 0x1DBC030 Offset: 0x1DBB430 VA: 0x181DBC030
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBC040 Offset: 0x1DBB440 VA: 0x181DBC040
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBBDA0 Offset: 0x1DBB1A0 VA: 0x181DBBDA0
	public static byte[] SerializeToBytes(StorageBox instance) { }

	// RVA: 0x1DBBCF0 Offset: 0x1DBB0F0 VA: 0x181DBBCF0
	public static void SerializeLengthDelimited(Stream stream, StorageBox instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

