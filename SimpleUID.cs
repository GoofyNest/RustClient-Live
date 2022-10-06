public class SimpleUID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6354
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint uid; 


	public static void ResetToPool(SimpleUID instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SimpleUID instance) { }

	public SimpleUID Copy() { }

	public static SimpleUID Deserialize(Stream stream) { }

	public static SimpleUID DeserializeLengthDelimited(Stream stream) { }

	public static SimpleUID DeserializeLength(Stream stream, int length) { }

	public static SimpleUID Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SimpleUID previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SimpleUID Deserialize(byte[] buffer, SimpleUID instance, bool isDelta = False) { }

	public static SimpleUID Deserialize(Stream stream, SimpleUID instance, bool isDelta) { }

	public static SimpleUID DeserializeLengthDelimited(Stream stream, SimpleUID instance, bool isDelta) { }

	public static SimpleUID DeserializeLength(Stream stream, int length, SimpleUID instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SimpleUID instance, SimpleUID previous) { }

	public static void Serialize(Stream stream, SimpleUID instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SimpleUID instance) { }

	public static void SerializeLengthDelimited(Stream stream, SimpleUID instance) { }

	public void .ctor() { }

}

