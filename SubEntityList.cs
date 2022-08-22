public class SubEntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> subEntityIds; // 0x18


	public static void ResetToPool(SubEntityList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SubEntityList instance) { }

	public SubEntityList Copy() { }

	public static SubEntityList Deserialize(Stream stream) { }

	public static SubEntityList DeserializeLengthDelimited(Stream stream) { }

	public static SubEntityList DeserializeLength(Stream stream, int length) { }

	public static SubEntityList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SubEntityList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SubEntityList Deserialize(byte[] buffer, SubEntityList instance, bool isDelta = False) { }

	public static SubEntityList Deserialize(Stream stream, SubEntityList instance, bool isDelta) { }

	public static SubEntityList DeserializeLengthDelimited(Stream stream, SubEntityList instance, bool isDelta) { }

	public static SubEntityList DeserializeLength(Stream stream, int length, SubEntityList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SubEntityList instance, SubEntityList previous) { }

	public static void Serialize(Stream stream, SubEntityList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SubEntityList instance) { }

	public static void SerializeLengthDelimited(Stream stream, SubEntityList instance) { }

	public void .ctor() { }

}

