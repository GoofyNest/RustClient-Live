public class MapNoteList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MapNote> notes; // 0x18

	// Methods

	// RVA: 0x1F3AC70 Offset: 0x1F3A070 VA: 0x181F3AC70
	public static void ResetToPool(MapNoteList instance) { }

	// RVA: 0x1F3AE20 Offset: 0x1F3A220 VA: 0x181F3AE20
	public void ResetToPool() { }

	// RVA: 0x1F3A9F0 Offset: 0x1F39DF0 VA: 0x181F3A9F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F39B60 Offset: 0x1F38F60 VA: 0x181F39B60
	public void CopyTo(MapNoteList instance) { }

	// RVA: 0x1F39CF0 Offset: 0x1F390F0 VA: 0x181F39CF0
	public MapNoteList Copy() { }

	// RVA: 0x1F3A970 Offset: 0x1F39D70 VA: 0x181F3A970
	public static MapNoteList Deserialize(Stream stream) { }

	// RVA: 0x1F39EE0 Offset: 0x1F392E0 VA: 0x181F39EE0
	public static MapNoteList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3A230 Offset: 0x1F39630 VA: 0x181F3A230
	public static MapNoteList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3A560 Offset: 0x1F39960 VA: 0x181F3A560
	public static MapNoteList Deserialize(byte[] buffer) { }

	// RVA: 0x1F3AC30 Offset: 0x1F3A030 VA: 0x181F3AC30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3B560 Offset: 0x1F3A960 VA: 0x181F3B560 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3B580 Offset: 0x1F3A980 VA: 0x181F3B580 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNoteList previous) { }

	// RVA: 0x1F3AC50 Offset: 0x1F3A050 VA: 0x181F3AC50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3A870 Offset: 0x1F39C70 VA: 0x181F3A870
	public static MapNoteList Deserialize(byte[] buffer, MapNoteList instance, bool isDelta = False) { }

	// RVA: 0x1F3A680 Offset: 0x1F39A80 VA: 0x181F3A680
	public static MapNoteList Deserialize(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F39F60 Offset: 0x1F39360 VA: 0x181F39F60
	public static MapNoteList DeserializeLengthDelimited(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3A2C0 Offset: 0x1F396C0 VA: 0x181F3A2C0
	public static MapNoteList DeserializeLength(Stream stream, int length, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3AFD0 Offset: 0x1F3A3D0 VA: 0x181F3AFD0
	public static void SerializeDelta(Stream stream, MapNoteList instance, MapNoteList previous) { }

	// RVA: 0x1F3B370 Offset: 0x1F3A770 VA: 0x181F3B370
	public static void Serialize(Stream stream, MapNoteList instance) { }

	// RVA: 0x1F3B550 Offset: 0x1F3A950 VA: 0x181F3B550
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3B560 Offset: 0x1F3A960 VA: 0x181F3B560
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3B260 Offset: 0x1F3A660 VA: 0x181F3B260
	public static byte[] SerializeToBytes(MapNoteList instance) { }

	// RVA: 0x1F3B1B0 Offset: 0x1F3A5B0 VA: 0x181F3B1B0
	public static void SerializeLengthDelimited(Stream stream, MapNoteList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

