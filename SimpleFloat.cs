public class SimpleFloat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6360
{
	public bool ShouldPool;
	private bool _disposed;
	public float value;


	public static void ResetToPool(SimpleFloat instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SimpleFloat instance) { }

	public SimpleFloat Copy() { }

	public static SimpleFloat Deserialize(Stream stream) { }

	public static SimpleFloat DeserializeLengthDelimited(Stream stream) { }

	public static SimpleFloat DeserializeLength(Stream stream, int length) { }

	public static SimpleFloat Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SimpleFloat previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SimpleFloat Deserialize(byte[] buffer, SimpleFloat instance, bool isDelta = False) { }

	public static SimpleFloat Deserialize(Stream stream, SimpleFloat instance, bool isDelta) { }

	public static SimpleFloat DeserializeLengthDelimited(Stream stream, SimpleFloat instance, bool isDelta) { }

	public static SimpleFloat DeserializeLength(Stream stream, int length, SimpleFloat instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SimpleFloat instance, SimpleFloat previous) { }

	public static void Serialize(Stream stream, SimpleFloat instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SimpleFloat instance) { }

	public static void SerializeLengthDelimited(Stream stream, SimpleFloat instance) { }

	public void .ctor() { }

}

