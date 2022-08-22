public class MapNoteList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MapNote> notes; // 0x18


	public static void ResetToPool(MapNoteList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MapNoteList instance) { }

	public MapNoteList Copy() { }

	public static MapNoteList Deserialize(Stream stream) { }

	public static MapNoteList DeserializeLengthDelimited(Stream stream) { }

	public static MapNoteList DeserializeLength(Stream stream, int length) { }

	public static MapNoteList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MapNoteList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MapNoteList Deserialize(byte[] buffer, MapNoteList instance, bool isDelta = False) { }

	public static MapNoteList Deserialize(Stream stream, MapNoteList instance, bool isDelta) { }

	public static MapNoteList DeserializeLengthDelimited(Stream stream, MapNoteList instance, bool isDelta) { }

	public static MapNoteList DeserializeLength(Stream stream, int length, MapNoteList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MapNoteList instance, MapNoteList previous) { }

	public static void Serialize(Stream stream, MapNoteList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MapNoteList instance) { }

	public static void SerializeLengthDelimited(Stream stream, MapNoteList instance) { }

	public void .ctor() { }

}

