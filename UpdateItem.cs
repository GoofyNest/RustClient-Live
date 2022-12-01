public class UpdateItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{
	public bool ShouldPool;
	private bool _disposed;
	public Item item;


	public static void ResetToPool(UpdateItem instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(UpdateItem instance) { }

	public UpdateItem Copy() { }

	public static UpdateItem Deserialize(Stream stream) { }

	public static UpdateItem DeserializeLengthDelimited(Stream stream) { }

	public static UpdateItem DeserializeLength(Stream stream, int length) { }

	public static UpdateItem Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, UpdateItem previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static UpdateItem Deserialize(byte[] buffer, UpdateItem instance, bool isDelta = False) { }

	public static UpdateItem Deserialize(Stream stream, UpdateItem instance, bool isDelta) { }

	public static UpdateItem DeserializeLengthDelimited(Stream stream, UpdateItem instance, bool isDelta) { }

	public static UpdateItem DeserializeLength(Stream stream, int length, UpdateItem instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, UpdateItem instance, UpdateItem previous) { }

	public static void Serialize(Stream stream, UpdateItem instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(UpdateItem instance) { }

	public static void SerializeLengthDelimited(Stream stream, UpdateItem instance) { }

	public void .ctor() { }

}

