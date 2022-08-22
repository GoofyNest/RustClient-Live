public class PersistantPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6455
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> unlockedItems; // 0x18
	public int protocolVersion; // 0x20


	public static void ResetToPool(PersistantPlayer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PersistantPlayer instance) { }

	public PersistantPlayer Copy() { }

	public static PersistantPlayer Deserialize(Stream stream) { }

	public static PersistantPlayer DeserializeLengthDelimited(Stream stream) { }

	public static PersistantPlayer DeserializeLength(Stream stream, int length) { }

	public static PersistantPlayer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PersistantPlayer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PersistantPlayer Deserialize(byte[] buffer, PersistantPlayer instance, bool isDelta = False) { }

	public static PersistantPlayer Deserialize(Stream stream, PersistantPlayer instance, bool isDelta) { }

	public static PersistantPlayer DeserializeLengthDelimited(Stream stream, PersistantPlayer instance, bool isDelta) { }

	public static PersistantPlayer DeserializeLength(Stream stream, int length, PersistantPlayer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PersistantPlayer instance, PersistantPlayer previous) { }

	public static void Serialize(Stream stream, PersistantPlayer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PersistantPlayer instance) { }

	public static void SerializeLengthDelimited(Stream stream, PersistantPlayer instance) { }

	public void .ctor() { }

}

