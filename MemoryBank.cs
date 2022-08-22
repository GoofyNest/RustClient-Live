public class MemoryBank : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int slotCount; // 0x18
	public List<int> slots; // 0x20


	public static void ResetToPool(MemoryBank instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MemoryBank instance) { }

	public MemoryBank Copy() { }

	public static MemoryBank Deserialize(Stream stream) { }

	public static MemoryBank DeserializeLengthDelimited(Stream stream) { }

	public static MemoryBank DeserializeLength(Stream stream, int length) { }

	public static MemoryBank Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MemoryBank previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MemoryBank Deserialize(byte[] buffer, MemoryBank instance, bool isDelta = False) { }

	public static MemoryBank Deserialize(Stream stream, MemoryBank instance, bool isDelta) { }

	public static MemoryBank DeserializeLengthDelimited(Stream stream, MemoryBank instance, bool isDelta) { }

	public static MemoryBank DeserializeLength(Stream stream, int length, MemoryBank instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MemoryBank instance, MemoryBank previous) { }

	public static void Serialize(Stream stream, MemoryBank instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MemoryBank instance) { }

	public static void SerializeLengthDelimited(Stream stream, MemoryBank instance) { }

	public void .ctor() { }

}

