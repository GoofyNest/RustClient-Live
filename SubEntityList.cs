public class SubEntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> subEntityIds; // 0x18

	// Methods

	// RVA: 0x1DBD180 Offset: 0x1DBC580 VA: 0x181DBD180
	public static void ResetToPool(SubEntityList instance) { }

	// RVA: 0x1DBD0A0 Offset: 0x1DBC4A0 VA: 0x181DBD0A0
	public void ResetToPool() { }

	// RVA: 0x1DBCF10 Offset: 0x1DBC310 VA: 0x181DBCF10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBC220 Offset: 0x1DBB620 VA: 0x181DBC220
	public void CopyTo(SubEntityList instance) { }

	// RVA: 0x1DBC340 Offset: 0x1DBB740 VA: 0x181DBC340
	public SubEntityList Copy() { }

	// RVA: 0x1DBCD70 Offset: 0x1DBC170 VA: 0x181DBCD70
	public static SubEntityList Deserialize(Stream stream) { }

	// RVA: 0x1DBC4A0 Offset: 0x1DBB8A0 VA: 0x181DBC4A0
	public static SubEntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBCA20 Offset: 0x1DBBE20 VA: 0x181DBCA20
	public static SubEntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBCDF0 Offset: 0x1DBC1F0 VA: 0x181DBCDF0
	public static SubEntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1DBD060 Offset: 0x1DBC460 VA: 0x181DBD060
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBD6B0 Offset: 0x1DBCAB0 VA: 0x181DBD6B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBD6D0 Offset: 0x1DBCAD0 VA: 0x181DBD6D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SubEntityList previous) { }

	// RVA: 0x1DBD080 Offset: 0x1DBC480 VA: 0x181DBD080 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBCAB0 Offset: 0x1DBBEB0 VA: 0x181DBCAB0
	public static SubEntityList Deserialize(byte[] buffer, SubEntityList instance, bool isDelta = False) { }

	// RVA: 0x1DBCBB0 Offset: 0x1DBBFB0 VA: 0x181DBCBB0
	public static SubEntityList Deserialize(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DBC520 Offset: 0x1DBB920 VA: 0x181DBC520
	public static SubEntityList DeserializeLengthDelimited(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DBC7B0 Offset: 0x1DBBBB0 VA: 0x181DBC7B0
	public static SubEntityList DeserializeLength(Stream stream, int length, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DBD260 Offset: 0x1DBC660 VA: 0x181DBD260
	public static void SerializeDelta(Stream stream, SubEntityList instance, SubEntityList previous) { }

	// RVA: 0x1DBD560 Offset: 0x1DBC960 VA: 0x181DBD560
	public static void Serialize(Stream stream, SubEntityList instance) { }

	// RVA: 0x1DBD6A0 Offset: 0x1DBCAA0 VA: 0x181DBD6A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBD6B0 Offset: 0x1DBCAB0 VA: 0x181DBD6B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBD450 Offset: 0x1DBC850 VA: 0x181DBD450
	public static byte[] SerializeToBytes(SubEntityList instance) { }

	// RVA: 0x1DBD3A0 Offset: 0x1DBC7A0 VA: 0x181DBD3A0
	public static void SerializeLengthDelimited(Stream stream, SubEntityList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

